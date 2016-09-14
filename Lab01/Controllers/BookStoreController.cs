using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01.Models;

namespace Lab01.Controllers
{
    public class BookStoreController : Controller
    {
        dbQLBanSachDataContext data = new dbQLBanSachDataContext();

        private List<SACH> LaySachMoi(int count)
        {
            // Lay count sach giam dan theo ngay cap nhat
            return data.SACHes.OrderByDescending(a => a.NgayCapNhat).Take(count).ToList();
        }

        // GET: BookStore
        public ActionResult Index()
        {
            List<SACH> SachMoi = LaySachMoi(5);

            return View();
        }


    }
}