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
    public class ProductBLL : IBLL<ProductDetailDTO, ProductDTO>
    {
        ProductDAO dao = new ProductDAO();
        SalesDAO Salesdao = new SalesDAO();
        CategoryDAO categoryDAO = new CategoryDAO();

        public bool Delete(ProductDetailDTO entity)
        {
            product product = new product();
            product.ID = entity.ProductID;
            product.isDeleted = true;
            product.DeletedDate = DateTime.Today;
            dao.Delete(product);
            Sale sale = new Sale();
            sale.ProductID = entity.ProductID;
            sale.isDeleted = true;
            sale.DeletedDate = DateTime.Today;
            Salesdao.Delete(sale);
            return true;
        }

        public bool GetBack(ProductDetailDTO entity)
        {
            return dao.GetBack(entity.ProductID);
        }

        public bool Insert(ProductDetailDTO entity)
        {
            product product = new product();
            product.ProductName = entity.ProductName;
            product.CategoryID = entity.CategoryId;
            product.Price = entity.Price;
            return dao.Insert(product);
        }

        public ProductDTO select()
        {
            ProductDTO dto = new ProductDTO();
            dto.Categories = categoryDAO.Select();
            dto.Produts = dao.Select();
            return dto;
        }

        public bool Update(ProductDetailDTO entity)
        {
            product product = new product();
            product.ID = entity.ProductID;
            product.ProductName = entity.ProductName;
            product.Price = entity.Price;
            product.StockAmount = entity.StockAmount;
            product.CategoryID = entity.CategoryId;
            return dao.Update(product);
        }
    }
}
