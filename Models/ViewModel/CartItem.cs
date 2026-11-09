using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _25dh110362.Models.ViewModel
{
    public class CartItem
    {
        public int ProductID { get; set; }
      
        public string ProductName { get; set; }
       
        public int Quantity { get; set; }
  
        public decimal UnitPrice { get; set; }
        public string Category { get; set; }
        public string ProductImage { get; set; }

        // Tổng giá cho mỗi sản phẩm[cite: 19]
        public decimal TotalPrice => Quantity * UnitPrice;
    }
}