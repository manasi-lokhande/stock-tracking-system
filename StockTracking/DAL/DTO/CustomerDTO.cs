using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking
{
    public class CustomerDTO
    {
        public List<CustomerDetailDTO> Customers { get; set; }
    }
}
