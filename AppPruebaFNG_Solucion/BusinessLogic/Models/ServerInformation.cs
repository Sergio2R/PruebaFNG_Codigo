using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Models
{
    public class ServerInformation
    {
        public string ServerDate { get; set; }
        public string ServerHour { get; set; }
        public string PrivateIpServer { get; set; }
        public string PublicIpServer { get; set; }
        public string CountryName { get; set; }
        public string RegionName { get; set; }
        public string CityName { get; set; }
    }
}
