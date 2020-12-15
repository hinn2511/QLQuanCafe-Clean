using Microsoft.AspNetCore.Mvc.Rendering;
using Domain.Entities.Helpers;
using Application.DTOs;

namespace QLQuanCafe.ViewModels
{
    public class CustomerViewModel
    {
        public PaginatedList<CustomerDto> Customers { get; set; }
        public string SearchString { get; set; }
        public string SortOrder { get; set; }

    }

}