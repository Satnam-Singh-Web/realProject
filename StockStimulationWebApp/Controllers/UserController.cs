using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using  StockStimulationWebApp.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace StockStimulationWebApp.Controllers
{
    [Route("User")]
    public class UserController : Controller
    {
        private readonly ShareDataContext _db;

        public UserController(ShareDataContext db)
        {
            _db = db;
        }
        // GET: /<controller>/
        [HttpPost,Route("")]
        public IActionResult Index(Login login)
        {
           // if (ModelState.IsValid)
               // return View();
            //var loginUser = _db.Logins;
            //Login newLogin=new Login();
           // if (loginUser.Contains())
            {
                
            }
            var httpClient = new HttpClient();
          //var ip = await httpClient.GetStringAsync("https://api.ipify.org"); ;
            string[] values = login.info.Split(',');
            for (int i = 0; i < values.Length; i++)
            {
                values[i] = values[i].Trim();
            }

            login.dateTime = DateTime.Now.ToString();
            //login.IPAddress = ip;
            login.publicIp = values[0];
            login.CityName = values[1];
            login.RegionName = values[2];
            login.CountryName = values[3];
            login.browser = values[4];
            login.operatingsys= System.Runtime.InteropServices.RuntimeInformation.OSDescription;
            return View();

        }
    }
}
