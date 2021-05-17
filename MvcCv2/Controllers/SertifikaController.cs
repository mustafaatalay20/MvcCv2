using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcCv2.Models.Entity;
using MvcCv2.Repositories;

namespace MvcCv2.Controllers
{
    public class SertifikaController : Controller
    {
        // GET: Sertifika

        public ActionResult Index()
        {
            return View();
        }
    }
}