using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstProgram.Models;

namespace FirstProgram.Controllers
{
    public class ProduceController : Controller
    {
        // GET: Produce
        WebBanVaLiEntities2 db = new WebBanVaLiEntities2();
        public ActionResult Index()
        {
            

            return View();
        }
        public PartialViewResult ChuDePartial()
        {
            return PartialView(db.tLoaiSPs.ToList());
        }
        public ViewResult SanPhamTheoLoai(String MaLoai = "vali")
        {
            tLoaiSP lsp = db.tLoaiSPs.SingleOrDefault(n => n.MaLoai == MaLoai);
            if (lsp == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            List<tDanhMucSP> lstSanPham = db.tDanhMucSPs.Where(n => n.MaLoai == MaLoai).OrderBy(n => n.TenSP).ToList();
            if (lstSanPham.Count == 0)
            {
                ViewBag.lstSanPham = "No Produce";
            }
            ViewBag.lstSanPham = db.tDanhMucSPs.ToList();
            return View(lstSanPham);
        }
        public ViewResult ChiTietSanPham(string MaSP)
        {
            tDanhMucSP sanpham = db.tDanhMucSPs.Single(n => n.MaSP == MaSP);
            if (sanpham == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(sanpham);
        }
    }
}