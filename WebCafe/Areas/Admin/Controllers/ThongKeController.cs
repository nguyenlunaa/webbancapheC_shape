using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Mvc;
using WebCafe.Models;
using WebCafe.App_Start;

namespace WebCafe.Areas.Admin.Controllers
{
    public class ThongKeController : Controller
    {
        QuanLyCaPheEntities db = new QuanLyCaPheEntities();
        // GET: Admin/ThongKe

        [AdminAuthorize]
        public ActionResult Index()
        {
            List<WebCafe.Models.DonDatHang> donDatHangs = db.DonDatHangs.OrderByDescending(row => row.NgayDat).ToList();
            return View(donDatHangs);
        }
    }
}