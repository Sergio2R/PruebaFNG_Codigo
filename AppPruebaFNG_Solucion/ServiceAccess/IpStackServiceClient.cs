using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ServiceAccess
{
    public class IpStackServiceClient
    {
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
