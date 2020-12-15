using System.Collections.Generic;
using System.Linq;
using Domain.Entities;
using Domain.Repositories;
using Domain.Entities.BillAggregate;
using Domain.Entities.CustomerAggregate;
using Microsoft.Data.Sql;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence
{
    public class BillRepository : EFRepository<Bill>, IBillRepository
    {
        public BillRepository(QLQuanCafeContext context) : base(context)
        {
        }

        
        

        /*public IEnumerable<string> GetBillTypes()
        {
            return context.Bills
                            .OrderBy(m => m.BillType)
                            .Select(m => m.BillType)
                            .Distinct();
        }*/

        /*public IEnumerable<Bill> BillFilter(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Bills.AsQueryable();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.BillName.Contains(searchString));
            }

            SortBills(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }*/

        public IEnumerable<Bill> BillSearch(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var query = context.Bills.AsQueryable();
            
            if (!string.IsNullOrEmpty(searchString))
            {
                query = query.Where(m => m.BillNumber.Contains(searchString));
            }            
            SortBills(sortOrder, ref query);
            count = query.Count();

            return query.Skip((pageIndex - 1) * pageSize)
                        .Take(pageSize).ToList();
        }

        public IEnumerable<BillDetail> GetBillDetails(int billId)
        {
            var query = context.BillDetails.Where(bd => bd.BillId == billId);
            return query.ToList();
        }

        
        private static void SortBills(string sortOrder, ref IQueryable<Bill> query)
        {
            switch (sortOrder)
            {
                case "billNumber_desc":
                    query = query.OrderByDescending(m => m.BillNumber);
                    break;
                case "billNumber":
                    query = query.OrderBy(m => m.BillNumber);
                    break;
                case "billDate_desc":
                    query = query.OrderByDescending(m => m.BillDate);
                    break;
                case "billDate":
                    query = query.OrderBy(m => m.BillDate);
                    break;
                case "customer_desc":
                    query = query.OrderByDescending(m => m.Customer);
                    break;
                case "customer":
                    query = query.OrderBy(m => m.Customer);
                    break;
                case "total_desc":
                    query = query.OrderByDescending(m => m.Total);
                    break;
                case "total":
                    query = query.OrderBy(m => m.Total);
                    break;
                
            }
        }

        /*public void AddCustomerNameToBill()
        {
            var customers = context.Customers.Include(c => c.Bills);
            foreach ( Customer c in customers)
            {
                foreach(Bill b in c.Bills)
                {
                    context.Add(c.CustomerId + b.BillId);
                }
            }
        }
*/
/*
        public void AddProductToBillDetail()
        {
            var products = context.Products.Include(p => p.BillDetails);
            foreach ( Product p in products)
            {
                foreach(BillDetail bd in p.BillDetails)
                {
                    context.Add(p.ProductId + bd.BillId);
                }
            }
        }

        /*public BillDetail GetBillDetailBy(int id)
        {
            BillDetail bd = new BillDetail { BillId = id, ProductId = productId, ProductPrice = price,Quantity = quantity };

        }*/

        public void AddBillDetail(BillDetail billDetail)
        {
            var bD = new BillDetail {
                BillId = billDetail.Id,
                ProductId = billDetail.ProductId,
                Quantity = billDetail.Quantity,
                BillDetailTotal = billDetail.BillDetailTotal
            };
            context.Add(bD);
            context.SaveChanges();
        }

        public IEnumerable<BillDetail> AllBillDetail()
        {
            var allBillDetail = context.BillDetails.Select(bd => bd);
            return allBillDetail.ToList();
        }

    }
    
}