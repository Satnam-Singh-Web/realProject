using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http.Headers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Net.Http.Server;

namespace StockStimulationWebApp.Models
{
    public class Login
    {
        [Key]
        public long id
        {
            get;
            set;
        }
        public string password { get; set; }
        [ForeignKey("signup")]
        public string userName { get; set; }
        public string browser { get; set; }
        public string IPAddress { get; set; }
        public string CountryName { get; set; }
        public string CityName { get; set; }
        public string RegionName { get; set; }
        public string dateTime;
        public string operatingsys;
        public string publicIp;

        public string info { get; set; }
        
   
        
       
    }
}
