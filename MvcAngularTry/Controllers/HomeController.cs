using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcAngularTry.Controllers
{
    public class Fake
    {
        public int age { get; set; }
        public string name { get; set; }
        public string snippet { get; set; }
        public bool isActive { get; set; }
    }
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult JsonR() {
            List<Fake> dts = new List<Fake> { 
            new Fake{age=11,name="ka",snippet="blaaaaa",isActive=true},
            new Fake{age=12,name="aa",snippet="claaaaa",isActive=false},
            new Fake{age=13,name="da",snippet="dblaaaaa"},
            new Fake{age=14,name="fa",snippet="elaaaaa",isActive=true},
            };
            return Json(dts,JsonRequestBehavior.AllowGet);
        }

    }
}
