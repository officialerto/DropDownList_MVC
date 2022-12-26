using DropDownList_MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DropDownList_MVC.Controllers
{
    public class StockController : Controller
    {
        // GET: Stock
        public ActionResult AddOrEdit(int id=0)
        {
            Stock stockModel = new Stock();

            using (DbModel db = new DbModel())
            {
                if (id != 0)
                    stockModel = db.Stocks.Where(x => x.StockID == id).FirstOrDefault();
                stockModel.ProductCollection = db.Products.ToList<Product>();
            }

            //--------------------We want to add new property to dropdown instead of database properties-----------------------------------
            //stockModel.ProductCollection = new List<Product>()
            //{
            //    new Product(){ProductID=1, ProductName="Computer"},
            //    new Product(){ProductID=2, ProductName="Mobile Phone"},
            //};

            return View(stockModel);

        }

        [HttpPost]
        public ActionResult AddOrEdit(Stock stock)
        {
            //Save ProductID and Count in Stock Table

            return View();
        }

    }
}