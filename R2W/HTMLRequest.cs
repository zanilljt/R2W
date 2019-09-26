using System;
using System.IO;
using System.Net;
using Newtonsoft.Json.Linq;

namespace R2W
{
    public class HTMLRequest
    {
        public HTMLRequest()
        {
        }

        public static string GETRequest(string username, string password)
        {
            string html = string.Empty;
            string url = @"https://r2wmobile4.running2win.com/api.asmx/login?vendorId=" + Globals.API_VENDOR + "&appId=" + Globals.API_ID + "&userNameOrEmail=" + username + "&password=" + password;

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.AutomaticDecompression = DecompressionMethods.GZip;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                html = reader.ReadToEnd();
            }
            JObject json = JObject.Parse(html);

            return ((string)json["token"]);
        }
    }
}
