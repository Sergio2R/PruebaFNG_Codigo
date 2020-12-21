using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ServiceAccess
{
    public class IpInfoDbServiceClient
    {
        public JObject GetInformacionGeografica(string ip)
        {
            string uri = "http://api.ipstack.com/" + ip + "?access_key=f215b99ee0f5cd275126753f4c8407c2&format=1";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            using (Stream stream = response.GetResponseStream())
            using (StreamReader reader = new StreamReader(stream))
            {
                string read = reader.ReadToEnd();
                return JObject.Parse(read);
            }
        }
    }
}
