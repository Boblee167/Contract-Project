using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ContractManager.Models;

namespace ContractManager.Controllers
{
    public class ContractDetailsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: ContractDetails
        public async Task<ActionResult> Index()
        {
            var contractDetails = db.ContractDetails.Include(c => c.Supplier);
            return View(await contractDetails.ToListAsync());
        }

        // GET: ContractDetails/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractDetail contractDetails = await db.ContractDetails.FindAsync(id);
            if (contractDetails == null)
            {
                return HttpNotFound();
            }
            return View(contractDetails);
        }

        // GET: ContractDetails/Create
        public ActionResult Create()
        {
            ViewBag.Supplier_ID = new SelectList(db.Supplier, "Supplier_ID", "SupplierNumber");
            return View();
        }

        // POST: ContractDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "Contract_ID,ContractStartDate,ContractFinishDate,ContractExtensionsAvailable,DurationContactExtension,Servicetype,PriceDescription,Price,VatRate,PriceUpdatedate,Supplier_ID")] ContractDetail contractDetails)
        {
            if (ModelState.IsValid)
            {
                db.ContractDetails.Add(contractDetails);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.Supplier_ID = new SelectList(db.Supplier, "Supplier_ID", "SupplierNumber", contractDetails.Supplier_ID);
            return View(contractDetails);
        }

        // GET: ContractDetails/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractDetail contractDetails = await db.ContractDetails.FindAsync(id);
            if (contractDetails == null)
            {
                return HttpNotFound();
            }
            ViewBag.Supplier_ID = new SelectList(db.Supplier, "Supplier_ID", "SupplierNumber", contractDetails.Supplier_ID);
            return View(contractDetails);
        }

        // POST: ContractDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "Contract_ID,ContractStartDate,ContractFinishDate,ContractExtensionsAvailable,DurationContactExtension,Servicetype,PriceDescription,Price,VatRate,PriceUpdatedate,Supplier_ID")] ContractDetail contractDetails)
        {
            if (ModelState.IsValid)
            {
                db.Entry(contractDetails).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.Supplier_ID = new SelectList(db.Supplier, "Supplier_ID", "SupplierNumber", contractDetails.Supplier_ID);
            return View(contractDetails);
        }

        // GET: ContractDetails/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ContractDetail contractDetails = await db.ContractDetails.FindAsync(id);
            if (contractDetails == null)
            {
                return HttpNotFound();
            }
            return View(contractDetails);
        }

        // POST: ContractDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ContractDetail contractDetails = await db.ContractDetails.FindAsync(id);
            db.ContractDetails.Remove(contractDetails);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
