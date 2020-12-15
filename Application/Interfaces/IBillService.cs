using System.Collections.Generic;
using Application.DTOs;

namespace Application.Interfaces
{
    public interface IBillService
    {
        IEnumerable<BillDto> GetBills(string sortOrder, string searchString, int pageIndex, int pageSize, out int count );

        IEnumerable<BillDetailDto> GetBillDetails(int id);

        IEnumerable<BillDetailDto> AllBillDetail();

        BillDto GetBill(int BillId);

        //BillDetailDto GetBillDetail(int BillId);
        //IEnumerable<string> GetTypes();
        void CreateBill(BillDto Bill);
        void UpdateBill(BillDto Bill);
        void DeleteBill(int BillId);
        void CreateBillDetail(BillDetailDto billDetail);


    }
}