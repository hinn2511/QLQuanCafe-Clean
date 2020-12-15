using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities.Helpers;
using Domain.Repositories;
using QLQuanCafe.ViewModels;
using Application.Interfaces;
using Application.DTOs;
using Infrastructure.Persistence;
using System;

namespace QLQuanCafe.Controllers
{
    public class BillController : Controller
    {
        private readonly IBillService billService;

        public BillController(IBillService billService)
        {
            this.billService = billService;
        }

        /*public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var bills = billService.GetBills(sortOrder, searchString, pageIndex, pageSize, out count);

            var indexVM = new BillViewModel()
            {
                Bills = new PaginatedList<BillDto>(bills, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder
            };

            return View(indexVM);
        }*/

        public IActionResult Index(string sortOrder, string searchString, int pageIndex = 1)
        {
            int pageSize = 10;
            int count;
            var bills = billService.GetBills(sortOrder, searchString, pageIndex, pageSize, out count);

            var indexVM = new BillViewModel()
            {
                Bills = new PaginatedList<BillDto>(bills, count, pageIndex, pageSize),
                SearchString = searchString,
                SortOrder = sortOrder
                //Customer = new List<Cusomter>
            };

            return View(indexVM);
        }      

        public IActionResult BillDetail()
        {
            var billDetail = billService.AllBillDetail();
            var billVM = new BillDetailAllViewModel()
            {
                BillDetails = billDetail
            };
            return View(billVM);
        }     


        public IActionResult Create(int id)
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(BillDto bill)
        {
            if (ModelState.IsValid)
            {
                DateTime now = DateTime.Now;
                bill.BillDate = DateTime.Now;
                billService.CreateBill(bill);
                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Edit(int id)
        {
            var bill = billService.GetBill(id);

            return View(bill);
        }

        [HttpPost]
        public IActionResult Edit(BillDto bill)
        {
            if (ModelState.IsValid)
            {
                billService.UpdateBill(bill);

                return RedirectToAction("Index");
            }

            return View();
        }

        public IActionResult Details(int id)
        {
            var billDetail = billService.GetBillDetails(id);
            var bill = billService.GetBill(id);
            var billVM = new BillDetailViewModel()
            {
                Bill = bill,
                BillDetails = billDetail,
                BillId = id
            };
            return View(billVM);
        }

        public IActionResult Delete(int id)
        {
            var bill = billService.GetBill(id);

            return View(bill);
        }

        [HttpPost]
        public IActionResult Delete(int id, bool notUsed)
        {
            billService.DeleteBill(id);

            return RedirectToAction("Index");
        }

        /*public IActionResult CreateBillDetail(int id)
        {
            TempData["BillId"] = id;
            var billDetail = new BillDetailViewModel(){
                BillId = id
            };
            TempData.Keep("BillId");
            return View(billDetail);
        }

        [HttpPost]
        public IActionResult CreateBillDetail(BillDetailDto billDetail)
        {
            if (ModelState.IsValid)
            {
                if(TempData.ContainsKey("BillId"))
                {
                billDetail.BillDetailTotal = 10000 * billDetail.Quantity;
                billService.CreateBillDetail(billDetail);

                }
                return RedirectToAction("Index");
            }

            return View();
        }*/

        public IActionResult CreateBillDetailNew(int id)
        {
            var createBDVM = new BillDetailAllViewModel(){
                BillId = id
            };
            return View(createBDVM);
        }


        [HttpPost]
        public IActionResult CreateBillDetailNew(BillDetailDto billDetail)
        {
            if (ModelState.IsValid)
            {
                billDetail.BillDetailTotal = billDetail.Quantity * 10000;
                billService.CreateBillDetail(billDetail);
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}