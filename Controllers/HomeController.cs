using Portfolio.Models.Context;
using Portfolio.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        MyContext _db = new MyContext();
        // GET: Home
        public ActionResult Index(int? id)
        {
            ArticleVM av = new ArticleVM()
            {
                User = _db.Users.Where(x=>x.ID == id).FirstOrDefault(),
                Article = _db.Articles.Where(x => x.ID == id).FirstOrDefault(),
                Articles = _db.Articles.ToList(),
            };

            return View(av);
        }

        
    }
}