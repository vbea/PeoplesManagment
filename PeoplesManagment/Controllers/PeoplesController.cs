using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PeoplesManagment.Models;

namespace PeoplesManagment.Controllers
{
    public class PeoplesController : Controller
    {
        // GET: Peoples
        public ActionResult Index()
        {
            //ModelContext db = new ModelContext();
            VillageInfoEntities db = new VillageInfoEntities();
            List<Peoples> list = db.Peoples.ToList();
            //var list2 = from data in db.Peoples where data.id > 1 orderby data.id descending select data;
            return View(list);
        }
    }
}