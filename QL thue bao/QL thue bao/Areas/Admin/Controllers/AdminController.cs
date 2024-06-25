using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QL_thue_bao.Models;

namespace QL_thue_bao.Areas.Admin.Controllers
{
    public class AdminController : Controller
    {
        QLTHUEBAOEntities db =new QLTHUEBAOEntities();
        // GET: Admin/Admin


        public ActionResult THUEBAO()
        {
            List<THUEBAO> tb = db.THUEBAOs.ToList();
            return View(tb);
        } 
        public ActionResult DIENTHOAI()
        {
            List<DIENTHOAI> dt = db.DIENTHOAIs.ToList();
            return View(dt);
        }

        public ActionResult LOAITHUEBAO()
        {
            List<LOAITHUEBAO> dt = db.LOAITHUEBAOs.ToList();
            return View(dt);
        }

        public ActionResult THETRATRUOC()
        {
            List<THETRATRUOC> t = db.THETRATRUOCs.ToList();
            return View(t);
        }

        public ActionResult TRASAU()
        {
            List<TRASAU> t = db.TRASAUs.ToList();
            return View(t);
        }

        


    }
}