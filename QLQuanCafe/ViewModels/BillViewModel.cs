using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities.Helpers;
using Application.DTOs;

namespace QLQuanCafe.ViewModels
{
    public class BillViewModel
    {
        public PaginatedList<BillDto> Bills { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }

        //public IList<CustomerDto> Customers { get; set; }

    }

}