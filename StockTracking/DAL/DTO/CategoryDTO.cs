using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracking.DAL.DAO;
using StockTracking.DAL.DTO;

namespace StockTracking.DAL.DTO
{
    public class CategoryDTO
    {
        public List<CategoryDetailDTO> Categories { get; set; }
    }
    
}
