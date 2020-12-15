using System;
using System.Collections.Generic;
using Domain.Entities.BillAggregate;

namespace Domain.Repositories
{
    public interface IBillRepository : IRepository<Bill>
    {
        //IEnumerable<string> GetBillTypes();
        IEnumerable<Bill> BillSearch(string sortOder, string searchString, int pageIndex, int pageSize, out int count);
        //IEnumerable<Bill> BillSearch(string sortOder, string searchString, out int count);
        //public void CreateBillDetail(BillDetail billDetail);
        //public BillDetail GetBillDetailBy(int billId);
        //IEnumerable<BillDetail> BillDetailSearch(int billId, int pageIndex, int pageSize, out int count);

        IEnumerable<BillDetail> GetBillDetails(int billId);

        IEnumerable<BillDetail> AllBillDetail();

        void AddBillDetail(BillDetail billDetail);


    }
} 