using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Hotel_Managment_Studio.Models
{
    public class Hotel
    {
        public string Name { get; set; }
        public HotelAddress HotelAddress { get; set; }
        public string Price { get; set; }

    }

    public class HotelAddress
    {
        public string streetAddress { get; set; }
        public string locality { get; set; }
        public string region { get; set; }
        public string postalCode { get; set; }

        public HotelAddress(string streetAddress, string locality, string region, string postalCode)
        {
            this.streetAddress = streetAddress;
            this.locality = locality;
            this.region = region;
            this.postalCode = postalCode;
        }

    }
}
