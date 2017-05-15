using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ApIJsonParser.Controllers
{
    public class HomeController : Controller
    {
        public JsonResult Index()
        {           
           // return Json();
            BookStoreEntities books = new BookStoreEntities();
            return Json(books.Books.Select(m => new { m.BookName,m.Author.AuthorName,m.Category.CategoryName,m.Price}).ToList(), JsonRequestBehavior.AllowGet);
        }

        public DataTable DerializeDataTable()
        {
            const string json = @"[{""Name"":""AAA"",""Age"":""22"",""Job"":""PPP""},"
                               + @"{""Name"":""BBB"",""Age"":""25"",""Job"":""QQQ""},"
                               + @"{""Name"":""CCC"",""Age"":""38"",""Job"":""RRR""}]";
            var table = JsonConvert.DeserializeObject<DataTable>(json);
            return table;
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}