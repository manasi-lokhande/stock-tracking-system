using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DTO
{
    public class ProductDetailDTO
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int StockAmount { get; set; }
        public int Price { get; set; }        
    }
}
