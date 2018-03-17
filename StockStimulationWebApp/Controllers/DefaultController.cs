

using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using StockStimulationWebApp.Models;

namespace StockStimulationWebApp.Controllers
{
    [Route("Default")]
    public class DefaultController : Controller
    {
        private readonly ShareDataContext _db;

        public DefaultController(ShareDataContext db)
        {
            _db = db;
        }




        [Route("error")]
        public IActionResult error()
        {
            return View();
        }





        [Route("")]
        public IActionResult Index()
        {
//{
           
            // List<string> shareSymbol =new List<string>();
            // var shares = _db.companyShares;
            //var counter = 0;
            //foreach(var share in shares)
            //  {

            //    shareSymbol[counter]=share.companySymbol;
            //      counter++;
            //  }

            //shareSymbol info;
            //if (shareSymbol.Length == 0)
            //{
            //    info = new shareSymbol
            //    {
            //        ShareSymbol = shareSymbol
            //    };
            //    ViewData["data"] = info;
            //}
            // return View(shares);
            return View();
        }









        [Route("Details/{id}")]
        public IActionResult Details(string id)
        {
            return View();
        }






        [Route("Login")]
        public IActionResult Login()
        {
            return View();
        }






        [Route("SignUp")]
        public IActionResult SignUp()
        {
            return View();
        }






        [HttpPost]
        [Route("login")]
        public IActionResult Login(signUp signup)
        {
            _db.Signup.Add(signup);
            _db.SaveChanges();
            return View();
        }






        [Route("graph/{id}/{value}")]
        public async Task<IActionResult> graph(string id, string value)
        {
            /*
             * my Api key is INXNTP95U5EGWDQV
             */
            var ID = id;
            var Value = value;
            var apiKey = "INXNTP95U5EGWDQV";
            info info;
            var data = "";
            var page = "https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol=MSFT&apikey=" + apiKey;
            using (var client = new HttpClient())
            using (var response = await client.GetAsync(page))

            using (var content = response.Content)
            {
                data = await content.ReadAsStringAsync();
                if (data != null)
                {
                    info = new info
                    {
                        shareInfo = data
                    };
                    ViewData["data"] = info;
                }
            }
            return View();
        }






        [HttpPost]
        [Route("loadData/{id}")]
        public async Task<IActionResult> sharesData(string id)
        {
            var ID = id;
            var apiKey = "INXNTP95U5EGWDQV";
            string text = "";
            var page =
                "https://www.alphavantage.co/query?function=TIME_SERIES_INTRADAY&symbol="+id+"&interval=1min&apikey="+apiKey;
            //var page = "https://www.alphavantage.co/query?function=TIME_SERIES_MONTHLY&symbol=" + id + "&apikey=" +
            //         apiKey;
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    HttpResponseMessage response;
                    using (var client = new HttpClient())
                    {
                        response = await client.GetAsync(page);

                        if (response.StatusCode == HttpStatusCode.OK)
                        {
                            using (var content = response.Content)
                            {
                               var data = await content.ReadAsStringAsync();

                                return Json(data);
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                text = "error";
            }
            return Json(new { json = text });















            
           
        }




        [Route("load/shareshtml/{id}")]
        public IActionResult _shares(string id)
        {
            string Id = id;
            ViewBag.Symbol= Id;
            return View();
        }

        [Route("load/shareslist")]
        public IActionResult SharesList(string id)
        {
            string text="";
            try
            {
                var fileReader = System.IO.File.OpenText("wwwroot/json/shares.json");

                var json = fileReader.ReadToEnd();

                if (json != null)
                {
                    return Json(json);
                }
            }
            catch (Exception e)
            {
                text = "error";
            }
            return Json(new { json = text });
        }
    }
}
