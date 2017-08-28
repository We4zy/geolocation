using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UtilitiesService.Models
{
    public class JqGridResponse<T>
    {
        public int Total { get; set; }
        public int TotalRecords { get; set; }
        public T[] Rows { get; set; }
    }
}