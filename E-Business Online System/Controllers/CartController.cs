using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using E_Business_Online_System.Models;

namespace E_Business_Online_System.Controllers
{
    public class CartController : Controller
    {
        private EbusinessEntities db = new EbusinessEntities();

        //
        // GET: /Cart/

        public ActionResult Index()
        {
            var shopping_cart = db.Shopping_Cart.Include(s => s.Customer).Include(s => s.Shopping_Cart_State);
            return View(shopping_cart.ToList());
        }

        //
        // GET: /Cart/Details/5

        public ActionResult Details(long id = 0)
        {
            Shopping_Cart shopping_cart = db.Shopping_Cart.Find(id);
            if (shopping_cart == null)
            {
                return HttpNotFound();
            }
            return View(shopping_cart);
        }

        //
        // GET: /Cart/Create

        public ActionResult Create()
        {
            ViewBag.Cart_Customer_ID = new SelectList(db.Customers, "Cust_Id", "Cust_FName");
            ViewBag.Cart_State = new SelectList(db.Shopping_Cart_State, "Cart_State_ID", "Cart_State_Description");
            return View();
        }

        //
        // POST: /Cart/Create

        [HttpPost]
        public ActionResult Create(Shopping_Cart shopping_cart)
        {
            if (ModelState.IsValid)
            {
                db.Shopping_Cart.Add(shopping_cart);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.Cart_Customer_ID = new SelectList(db.Customers, "Cust_Id", "Cust_FName", shopping_cart.Cart_Customer_ID);
            ViewBag.Cart_State = new SelectList(db.Shopping_Cart_State, "Cart_State_ID", "Cart_State_Description", shopping_cart.Cart_State);
            return View(shopping_cart);
        }

        //
        // GET: /Cart/Edit/5

        public ActionResult Edit(long id = 0)
        {
            Shopping_Cart shopping_cart = db.Shopping_Cart.Find(id);
            if (shopping_cart == null)
            {
                return HttpNotFound();
            }
            ViewBag.Cart_Customer_ID = new SelectList(db.Customers, "Cust_Id", "Cust_FName", shopping_cart.Cart_Customer_ID);
            ViewBag.Cart_State = new SelectList(db.Shopping_Cart_State, "Cart_State_ID", "Cart_State_Description", shopping_cart.Cart_State);
            return View(shopping_cart);
        }

        //
        // POST: /Cart/Edit/5

        [HttpPost]
        public ActionResult Edit(Shopping_Cart shopping_cart)
        {
            if (ModelState.IsValid)
            {
                db.Entry(shopping_cart).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.Cart_Customer_ID = new SelectList(db.Customers, "Cust_Id", "Cust_FName", shopping_cart.Cart_Customer_ID);
            ViewBag.Cart_State = new SelectList(db.Shopping_Cart_State, "Cart_State_ID", "Cart_State_Description", shopping_cart.Cart_State);
            return View(shopping_cart);
        }

        //
        // GET: /Cart/Delete/5

        public ActionResult Delete(long id = 0)
        {
            Shopping_Cart shopping_cart = db.Shopping_Cart.Find(id);
            if (shopping_cart == null)
            {
                return HttpNotFound();
            }
            return View(shopping_cart);
        }

        //
        // POST: /Cart/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(long id)
        {
            Shopping_Cart shopping_cart = db.Shopping_Cart.Find(id);
            db.Shopping_Cart.Remove(shopping_cart);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}