using System.Collections.Generic;
using Application.DTOs;
using Application.Interfaces;
using Application.Mappings;
using Domain.Repositories;
using System;

namespace Application.Services
{
    public class BillService : IBillService
    {
        private readonly IBillRepository billRepository;

        public BillService(IBillRepository billRepository)
        {
            this.billRepository = billRepository;
        }

        public IEnumerable<BillDto> GetBills(string sortOrder, string searchString, int pageIndex, int pageSize, out int count)
        {
            var bills = billRepository.BillSearch(sortOrder, searchString, pageIndex, pageSize, out count);
            //var bills = billRepository.BillSearch(sortOrder, searchString,out count);


            return bills.MappingDtos();
        }

        public IEnumerable<BillDetailDto> GetBillDetails(int billId)
        {
            var billDetails = billRepository.GetBillDetails(billId);
            //var bills = billRepository.BillSearch(sortOrder, searchString,out count);


            return billDetails.MappingDtos();
        }

        public BillDto GetBill(int billId)
        {
            var bill = billRepository.GetBy(billId);

            return bill.MappingDto();
        }

        

        public void CreateBill(BillDto billDto)
        {
            var bill = billDto.MappingBill();
            billRepository.Add(bill);
        }

        /*ublic BillDetailDto GetBillDetail(int billId)
        {
            var billDetail = billRepository.GetBillDetail(billId);
            return billDetail.MappingDto(billDetail);
        }*/

        public void UpdateBill(BillDto billDto)
        {
            var bill = billRepository.GetBy(billDto.Id);

            billDto.MappingBill(bill);

            billRepository.Update(bill);
        }

        public void DeleteBill(int billId)
        {
            var bill = billRepository.GetBy(billId);

            billRepository.Delete(bill);
        }

        /*public BillDetailDto GetBillDetail(int billId)
        {
            var billDetail = billRepository.GetBillDetailBy(billId);

            return billDetail.MappingDto();
        }*/
        public void CreateBillDetail(BillDetailDto billDetailDto)
        {
            var billDetail = billDetailDto.MappingBillDetail();
            billRepository.AddBillDetail(billDetail);
        }

        public IEnumerable<BillDetailDto> AllBillDetail()
        {
            var billDetail = billRepository.AllBillDetail();
            return billDetail.MappingDtos();
        }
    }
}