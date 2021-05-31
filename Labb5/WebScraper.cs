using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Labb5
{
    public partial class Form1 : Form
    {
        public List<string> stringList = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private async void saveImgButton_Click(object sender, EventArgs e)
        {

            ExtractButton.Enabled = false;
            var selectedImages = ListBox.SelectedItems.Cast<string>().ToList();

            var client = new HttpClient();
            Dictionary<Task<byte[]>, string> downloads = new Dictionary<Task<byte[]>, string>();
            string folder = FolderPath();
            int amountOfPictures = 0;
            int savedImages = 0;
            foreach (var url in selectedImages)
            {
                string fileExtension = Regex.Match(url, @"(?<=\.)(jpg|jpeg|png|gif|bmp)(?=(""|\?|$))").Value;
                downloads.Add(Task.Run(() => client.GetByteArrayAsync(url)), fileExtension);
            }
            while (downloads.Count > 0)
            {
                Task<byte[]> task = await Task.WhenAny(downloads.Keys);

                amountOfPictures++;
                if (task.Exception == null)
                {
                    savedImages++;
                    string fileExtension = downloads[task];
                    string fileName = $"Image{savedImages,000}.{fileExtension}";
                    string fullPath = "";
                    try
                    {
                        fullPath = Path.Combine(folder, fileName);
                    }
                    catch (ArgumentNullException)
                    {
                        return;
                    }
                    await SaveImage(fullPath, task.Result);
                    SavedImagesLabel.Text = "Saved images: " + Convert.ToString(savedImages) + " of " + Convert.ToString(selectedImages.Count);
                }
                downloads.Remove(task);
            }
            ListBox.ClearSelected();
            ExtractButton.Enabled = true;
        }


        private async void ExtractButton_Click(object sender, EventArgs e)
        {
            string input = UrlBox.Text;
            if (input == " " || input == "")
            {
                MessageBox.Show("URL can't be empty", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UrlBox.Text = "";
                return;
            }
            if (!Uri.IsWellFormedUriString(input, UriKind.Absolute))
            {
                MessageBox.Show("The URL must be structured correct", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                UrlBox.Text = "";
                return;
            }
            var extract = new HtmlExtr();
            try
            {
                stringList = await extract.CallURL(input);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (stringList.Count <= 0)
            {
                MessageBox.Show("No Pictures", "Found Pictures", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                groupBox1.Visible = true;
                for (int i = 0; i < stringList.Count; i++)
                {
                    if (stringList[i].Contains("http://") || stringList[i].Contains("https://"))
                    {
                        continue;
                    }
                    else
                    {
                        stringList[i] = UrlBox.Text + stringList[i];
                    }
                }
                ListBox.DataSource = stringList;
                ItemsLoadedLabel.Text = "Pictures loaded: " + stringList.Count;
                ItemsLoadedLabel.Visible = true;
            }
        }
        private async Task SaveImage(string path, byte[] data)
        {
            var fs = new FileStream(path, FileMode.Create);
            await fs.WriteAsync(data, 0, data.Length);
            fs.Close();
        }
        public string FolderPath()
        {
            string folder = "";
            using (var folderBrowser = new FolderBrowserDialog())
            {
                DialogResult dialog = folderBrowser.ShowDialog();
                if (dialog == DialogResult.OK && !string.IsNullOrWhiteSpace(folderBrowser.SelectedPath))
                {
                    folder = folderBrowser.SelectedPath;
                    return folder;
                }
                else
                {
                    return null;
                }
            }
        }

        private void ListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListBox.SelectedItems.Count > 0)
            {
                saveImgButton.Enabled = true;
            }
            else
            {
                saveImgButton.Enabled = false;
            }
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < ListBox.Items.Count; i++)
            {
                ListBox.SetSelected(i, true);
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            saveImgButton.Enabled = false;
            ListBox.ClearSelected();
        }

       
    }
}
