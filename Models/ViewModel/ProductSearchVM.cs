using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PagedList.Mvc;


namespace _25dh110362.Models.Viewmodel
{
    public class ProductSearchVM
    {
        public string SearchTerm { get; set; }
        public List<Product> Products { get; set; }
        public decimal? MinPrice { get; set; }
        public decimal? MaxPrice { get; set; }
        public string SortOrder { get; set; }
        public PagedList.IPagedList<Product> Product { get; set; }
    }
}