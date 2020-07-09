using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace CoreWebRequest
{
    public static class WebRequest
    {
        public static async Task<string> POST(string URL, string Parameters, bool UseJSON = false, string SerializedJSON = "")
        {
            using (WebClient wc = new WebClient())
            {
                string HtmlResult = "";

                if(Uri.IsWellFormedUriString("https://www.google.com", UriKind.Absolute))
                {
                    try
                    {
                        if (UseJSON)
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/json";
                            HtmlResult = wc.UploadString(URL, "POST", SerializedJSON);
                        }
                        else
                        {
                            wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                            HtmlResult = wc.UploadString(URL, "POST", Parameters);
                        }
                    }
                    catch(Exception ex)
                    {

                    }
                    
                }

                return HtmlResult;
            }
        }
    }
}
