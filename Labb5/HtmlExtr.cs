using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Labb5
{
    class HtmlExtr
    {
        public async Task<List<string>> CallURL(String url)
        {
            HttpClient client = new HttpClient();
            HttpResponseMessage response = await client.GetAsync(url).ConfigureAwait(false);
            response.EnsureSuccessStatusCode();
            string responseBody = await response.Content.ReadAsStringAsync();
            List<string> listValues = SeperateImg(responseBody);
            return listValues;
        }

        public static List<string> SeperateImg(string s)
        {
            List<string> list = new List<string>();
            string regexImgSrc = @"<img[^>]*?src\s*=\s*[""']?([^'"" >]+?)[ '""][^>]*?>";
            MatchCollection collection = Regex.Matches(s, regexImgSrc, RegexOptions.IgnoreCase | RegexOptions.Singleline | RegexOptions.Compiled);
            foreach (Match item in collection)
            {
                string reference = item.Groups[1].Value;
                list.Add(reference);
            }
            return list;
        }
    }
}
