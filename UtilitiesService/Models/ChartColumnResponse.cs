using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilitiesService.Models
{
    public class ChartColumnResponse
    {
        public string[] Catagories { get; set; }
        public SeriesItem[] Series { get; set; }
    }

    public class SeriesItem
    {
        public string name { get; set; }
        public int[] data { get; set; }
    }
}