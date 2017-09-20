using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using UtilitiesService.Models;

namespace UtilitiesService.Controllers
{
    public class UtilitiesAPIController : ApiController
    {
        [HttpGet]
        public ChartColumnResponse GetOutagesOverview()
        {
            UtilitiesServiceDataContext db = new UtilitiesServiceDataContext();
            ChartColumnResponse response = new ChartColumnResponse();

            response.Catagories = new string[] { "PowerOutages", "WaterOutages" };

            var outages = db.vwUtilitiesOutagesOverviews.FirstOrDefault();

            response.Series = new SeriesItem[] {
                new SeriesItem() { name = "Service Outages", data = new int[] { (int)outages.PowerOutages, (int)outages.WaterOutages } },
                //new SeriesItem() { Name = "Water Outages", Data = (int)outages.WaterOutages  }
                };

            return response;
        }

        [HttpGet]
        public JqGridResponse<vwMeterStatus> GetWaterOutages()
        {
            UtilitiesServiceDataContext db = new UtilitiesServiceDataContext();
            JqGridResponse<vwMeterStatus> response = new JqGridResponse<vwMeterStatus>();

            response.Rows = db.vwMeterStatus.ToArray(); //.Where(p => p.Customer_Name == p.SvcLocCity).ToArray();
            response.Total = (response.Rows.Count()) / 50;
            response.TotalRecords = response.Rows.Count();

            return response;
        }

        [HttpGet]
        public JqGridResponse<PropNoService> GetPowerOutages()
        {
            UtilitiesServiceDataContext db = new UtilitiesServiceDataContext();
            JqGridResponse<PropNoService> response = new JqGridResponse<PropNoService>();

            response.Rows = db.PropNoServices.ToArray(); //.Where(p => p.ServiceAsOfDate > DateTime.Now.AddDays(-14)).ToArray();
            response.Total = (response.Rows.Count()) / 50;
            response.TotalRecords = response.Rows.Count();

            return response;
        }
    }
}