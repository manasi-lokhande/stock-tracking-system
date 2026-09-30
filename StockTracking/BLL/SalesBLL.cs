using StockTracking.DAL;
using StockTracking.DAL.DAO;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.BLL
{
    public class SalesBLL : IBLL<SalesDetailDTO, SalesDTO>
    {
        ProductDAO productdao = new ProductDAO();
        SalesDAO dao = new SalesDAO();
        CategoryDAO categorydao = new CategoryDAO();
        CustomerDAO customerdao = new CustomerDAO();
        public bool Delete(SalesDetailDTO entity)
        {
            Sale sale = new Sale();
            sale.ID = entity.SalesID;
            sale.isDeleted = true;
            sale.DeletedDate = DateTime.Today;
            dao.Delete(sale);
            return true;
        }

        public bool GetBack(SalesDetailDTO entity)
        {
            return dao.GetBack(entity.SalesID);
        }

        public bool Insert(SalesDetailDTO entity)
        {
            Sale sale = new Sale();            
            sale.ProductID = entity.ProductID;
            sale.CustomerID = entity.CustomerID;
            sale.CategoryID = entity.CategoryID;
            sale.ProductSalesAmount = entity.SalesAmount;
            sale.ProductSalesPrice = entity.Price;
            sale.SalesDate = entity.SalesDate;
            dao.Insert(sale);
            product product = new product();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            productdao.Update(product);
            return true;

        }

        public SalesDTO select()
        {
            SalesDTO dto = new SalesDTO();
            dto.Products = productdao.Select();
            dto.Customers = customerdao.Select();
            dto.Categories = categorydao.Select();
            dto.Sales = dao.Select();
            return dto;
        }

        public SalesDTO select(bool isdeleted)
        {
            SalesDTO dto = new SalesDTO();
            dto.Products = productdao.Select(isdeleted);
            dto.Customers = customerdao.Select(isdeleted);
            dto.Categories = categorydao.Select(isdeleted);
            dto.Sales = dao.Select(isdeleted);
            return dto;
        }

        public bool Update(SalesDetailDTO entity)
        {
            Sale sale = new Sale();
            sale.ProductSalesAmount = entity.SalesAmount;
            sale.ID = entity.SalesID;
            dao.Update(sale);
            product product = new product();
            product.ID = entity.ProductID;
            int temp = entity.StockAmount - entity.SalesAmount;
            product.StockAmount = temp;
            productdao.Update(product);
            return true;
        }
    }
}
