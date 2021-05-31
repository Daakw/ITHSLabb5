
namespace Labb5
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.UrlBox = new System.Windows.Forms.TextBox();
            this.ExtractButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ListBox = new System.Windows.Forms.ListBox();
            this.saveImgButton = new System.Windows.Forms.Button();
            this.SelectButton = new System.Windows.Forms.Button();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemsLoadedLabel = new System.Windows.Forms.Label();
            this.SavedImagesLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // UrlBox
            // 
            this.UrlBox.Location = new System.Drawing.Point(240, 55);
            this.UrlBox.Name = "UrlBox";
            this.UrlBox.Size = new System.Drawing.Size(425, 27);
            this.UrlBox.TabIndex = 1;
            // 
            // ExtractButton
            // 
            this.ExtractButton.Location = new System.Drawing.Point(671, 55);
            this.ExtractButton.Name = "ExtractButton";
            this.ExtractButton.Size = new System.Drawing.Size(65, 27);
            this.ExtractButton.TabIndex = 2;
            this.ExtractButton.Text = "Extract";
            this.ExtractButton.UseVisualStyleBackColor = true;
            this.ExtractButton.Click += new System.EventHandler(this.ExtractButton_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.groupBox1.Controls.Add(this.ListBox);
            this.groupBox1.Location = new System.Drawing.Point(212, 108);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(470, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Html";
            // 
            // ListBox
            // 
            this.ListBox.FormattingEnabled = true;
            this.ListBox.ItemHeight = 20;
            this.ListBox.Location = new System.Drawing.Point(6, 26);
            this.ListBox.Name = "ListBox";
            this.ListBox.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.ListBox.Size = new System.Drawing.Size(458, 244);
            this.ListBox.TabIndex = 4;
            this.ListBox.Click += new System.EventHandler(this.ListBox_SelectedIndexChanged);
            // 
            // saveImgButton
            // 
            this.saveImgButton.Location = new System.Drawing.Point(688, 269);
            this.saveImgButton.Name = "saveImgButton";
            this.saveImgButton.Size = new System.Drawing.Size(94, 29);
            this.saveImgButton.TabIndex = 7;
            this.saveImgButton.Text = "Save";
            this.saveImgButton.UseVisualStyleBackColor = true;
            this.saveImgButton.Click += new System.EventHandler(this.saveImgButton_Click);
            // 
            // SelectButton
            // 
            this.SelectButton.Location = new System.Drawing.Point(688, 199);
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(94, 29);
            this.SelectButton.TabIndex = 5;
            this.SelectButton.Text = "Select all";
            this.SelectButton.UseVisualStyleBackColor = true;
            this.SelectButton.Click += new System.EventHandler(this.selectButton_Click);
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(688, 234);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(94, 29);
            this.ClearButton.TabIndex = 6;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            this.ClearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(198, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "URL";
            // 
            // ItemsLoadedLabel
            // 
            this.ItemsLoadedLabel.AutoSize = true;
            this.ItemsLoadedLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ItemsLoadedLabel.Location = new System.Drawing.Point(212, 390);
            this.ItemsLoadedLabel.Name = "ItemsLoadedLabel";
            this.ItemsLoadedLabel.Size = new System.Drawing.Size(106, 20);
            this.ItemsLoadedLabel.TabIndex = 6;
            this.ItemsLoadedLabel.Text = "Images found:";
            // 
            // SavedImagesLabel
            // 
            this.SavedImagesLabel.AutoSize = true;
            this.SavedImagesLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SavedImagesLabel.Location = new System.Drawing.Point(468, 390);
            this.SavedImagesLabel.Name = "SavedImagesLabel";
            this.SavedImagesLabel.Size = new System.Drawing.Size(108, 20);
            this.SavedImagesLabel.TabIndex = 5;
            this.SavedImagesLabel.Text = "Images saved: ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(920, 472);
            this.Controls.Add(this.SavedImagesLabel);
            this.Controls.Add(this.ItemsLoadedLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.saveImgButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ExtractButton);
            this.Controls.Add(this.UrlBox);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "Form1";
            this.Text = "Web Scraper";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox UrlBox;
        private System.Windows.Forms.Button ExtractButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox ListBox;
        private System.Windows.Forms.Button saveImgButton;
        private System.Windows.Forms.Button SelectButton;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label ItemsLoadedLabel;
        private System.Windows.Forms.Label SavedImagesLabel;
    }
}

