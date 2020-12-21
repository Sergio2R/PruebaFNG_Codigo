using BusinessLogic.Models;
using Newtonsoft.Json.Linq;
using ServiceAccess;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BusinessLogic
{
    public class ServerInformer
    {
        public CheckIpServiceClient CheckIpServiceClient { get; set; }
        public IpInfoDbServiceClient IpInfoDbServiceClient { get; set; }
        public IpStackServiceClient IpStackServiceClient { get; set; }

        public ServerInformation GetServerInformation()
        {
            ServerInformation serverInformation = new ServerInformation();
            string publicIpServer = GetIpServidorPublica();
            String serverDate = DateTime.Now.ToString("dd-MM-yyyy");
            String serverHour = DateTime.Now.ToString("HH:mm");

            string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
            string privateIpServer = Dns.GetHostByName(hostName).AddressList[0].ToString();
            string ipServidorPublica = GetIpServidorPublica();

            JObject informacionGeografica = GetInformacionGeografica(ipServidorPublica);
            string countryName = informacionGeografica["country_name"].ToString();
            string regionName = informacionGeografica["region_name"].ToString();
            string cityName = informacionGeografica["city"].ToString();

            serverInformation.ServerDate = serverDate;
            serverInformation.ServerHour = serverHour;
            serverInformation.PublicIpServer = publicIpServer;
            serverInformation.PrivateIpServer = privateIpServer;
            serverInformation.CountryName = countryName;
            serverInformation.RegionName = regionName;
            serverInformation.CityName = cityName;



            return serverInformation;
        }

        public string GetIpServidorPublica()
        {
            String address = "";
            WebRequest request = WebRequest.Create("http://checkip.dyndns.org/");
            using (WebResponse response = request.GetResponse())
            using (StreamReader stream = new StreamReader(response.GetResponseStream()))
            {
                address = stream.ReadToEnd();
            }

            int first = address.IndexOf("Address: ") + 9;
            int last = address.LastIndexOf("</body>");
            address = address.Substring(first, last - first);

            return address;
        }

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

        public XmlTextReader GetUbicacionPorIp(string ipaddress)
        {
            // Register at ipinfodb.com for a free key and put it here
            string myKey = "f7e879c8b442fb1763e4c4885d0c6a2530f4f9ef634412faeceb76d2911757c2";

            //Create a WebRequest
            WebRequest rssReq = WebRequest.Create("http://api.ipinfodb.com/v3/ip-city/?key=" + myKey + "&ip=" + ipaddress + "&format=xml");

            //Create a Proxy
            WebProxy px = new WebProxy("http://api.ipinfodb.com/v3/ip-city/?key=" + myKey + "&ip=" + ipaddress + "&format=xml", true);

            //Assign the proxy to the WebRequest
            rssReq.Proxy = px;

            //Set the timeout in Seconds for the WebRequest
            rssReq.Timeout = 2000;
            try
            {
                //Get the WebResponse 
                WebResponse rep = rssReq.GetResponse();

                //Read the Response in a XMLTextReader
                XmlTextReader xtr = new XmlTextReader(rep.GetResponseStream());
                return xtr;

            }
            catch
            {
                return null;
            }
        }
    }
}
