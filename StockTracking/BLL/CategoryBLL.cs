using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StockTracking.DAL.DTO;
using StockTracking.DAL;
using StockTracking.DAL.DAO;

namespace StockTracking.BLL
{
    public class CategoryBLL : IBLL<CategoryDetailDTO, CategoryDTO>
    {
        CategoryDAO dao = new CategoryDAO();
        ProductDAO productDAO = new ProductDAO();
        public bool Delete(CategoryDetailDTO entity)
        {
            Category category = new Category();
            category.ID = entity.CategoryID;
            category.isDeleted = true;
            category.DeletedDate = DateTime.Today;
            dao.Delete(category);
            product product = new product();
            product.CategoryID = entity.CategoryID;
            product.isDeleted = true;
            product.DeletedDate = DateTime.Today;
            productDAO.Delete(product);
            return true;
        }

        public bool GetBack(CategoryDetailDTO entity)
        {
            return dao.GetBack(entity.CategoryID);
        }

        public bool Insert(CategoryDetailDTO entity)
        {
            Category category = new Category();
            category.CategoryName = entity.CategoryName;
            return dao.Insert(category);
        }

        public CategoryDTO select()
        {
            CategoryDTO dto = new CategoryDTO();
            dto.Categories = dao.Select();
            return dto;
        }

        public bool Update(CategoryDetailDTO entity)
        {
            Category category = new Category();
            category.ID = entity.CategoryID;
            category.CategoryName = entity.CategoryName;
            return dao.Update(category);
        }
    }
}
