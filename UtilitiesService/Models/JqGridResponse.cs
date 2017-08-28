using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilitiesService.Models
{
    public class JqGridResponse
    {
        public int Total { get; set; }
        public int TotalRecords { get; set; }
        public PropNoService[] Rows { get; set; }
    }
}