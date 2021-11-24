using InterviewProject.Models;
using System;
using System.Net;
using System.Text;

namespace InterviewProject.Translators
{
    public class TranslatorLanguage
    {
        public static string GetTranslateText(string text, string url)
        {
            string TextTransalted = "";

            string link = url;

            link = link + text;
            HttpWebRequest request = HttpWebRequest.Create(link) as HttpWebRequest;
            request.Method = "GET";
            /* Sart browser signature */
            request.UserAgent = "Mozilla/5.0 (Windows NT 6.3; WOW64; rv:31.0) Gecko/20100101 Firefox/31.0";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,*/*;q=0.8";
            request.Headers.Add(HttpRequestHeader.AcceptLanguage, "en-us,en;q=0.5");

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (var reader = new System.IO.StreamReader(response.GetResponseStream(), ASCIIEncoding.UTF8))
            {
                string responseText = reader.ReadToEnd();

                //Root res = JsonConvert.DeserializeObject<Root>(responseText);

                Root res2 = Newtonsoft.Json.JsonConvert.DeserializeObject<Root>(responseText);

                //Console.Clear();
                //Console.WriteLine(res2.Result.Entries.ToString());
                if (res2.success.total == 1)
                    TextTransalted = res2.contents.translated;
            }

            return TextTransalted;
        }

    }
}
