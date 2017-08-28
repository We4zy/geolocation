using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilitiesService.Models
{
    public class PowerOutage
    {
        public string ServiceAddress { get; set; }
        public string ServiceCity { get; set; }
        public string ServiceState { get; set; }
        public string ServiceAsOfDate { get; set; }
    }

    public class WaterOutage
    {
        public string Address { get; set; }
        public string City { get; set; }
        public DateTime LastServiceDate { get; set; }
    }
}