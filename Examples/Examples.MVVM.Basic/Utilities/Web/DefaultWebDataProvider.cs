using System;
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Examples.MVVM.Basic.Utilities.Web
{
    public class DefaultWebDataProvider : IWebDataProvider
    {
        public string GetResponse(string uri)
        {
            try
            {
                string output = string.Empty;

                HttpWebRequest request = WebRequest.CreateHttp(uri);
                request.Method = "GET";
                using (var response = request.GetResponse())
                using (var stream = response.GetResponseStream())
                using (StreamReader reader = new StreamReader(stream))
                    output = reader.ReadToEnd();

                return output;
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public Task<string> GetResponseAsync(string uri)
        {
            return Task.Factory.StartNew(() =>
            {
                return GetResponse(uri);
            });
        }
    }
}
