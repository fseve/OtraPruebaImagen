using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;

namespace OtraPruebaImagen.Controllers
{
    public class PruebaController : Controller
    {

        public ActionResult Index()
        {         
            return View();
        }

        [HttpPost]
        public ActionResult Create(HttpPostedFileBase file)
        {
            if (file != null && file.ContentLength > 0)
            { 
                    string path = Path.Combine(Server.MapPath("~/Images"),
                                                Guid.NewGuid() + Path.GetFileName(file.FileName));
                    file.SaveAs(path);
                    ViewBag.Message = "File uploaded successfully";
            }

            return RedirectToAction("Index");
        }
    }
}