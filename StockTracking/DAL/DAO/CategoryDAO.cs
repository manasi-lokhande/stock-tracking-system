using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class CategoryDAO : StockContent, IDAO<Category, CategoryDetailDTO>
    {
        public bool Delete(Category entity)
        {
            try
            {
                Category category = db.Categories.First(x => x.ID == entity.ID);
                category.isDeleted = entity.isDeleted;
                category.DeletedDate = entity.DeletedDate;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool GetBack(int ID)
        {
            try
            {
                Category category = db.Categories.First(x => x.ID == ID);
                category.isDeleted = false;
                category.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Category entity)
        {
            try
            {
                db.Categories.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select()
        {
            try
            {
                List<CategoryDetailDTO> categories = new List<CategoryDetailDTO>();
                var list = db.Categories.Where(x=>x.isDeleted == false);
                foreach (var item in list)
                {
                    CategoryDetailDTO dto = new CategoryDetailDTO();
                    dto.CategoryID = item.ID;
                    dto.CategoryName = item.CategoryName;
                    categories.Add(dto);
                }
                return categories;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CategoryDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<CategoryDetailDTO> categories = new List<CategoryDetailDTO>();
                var list = db.Categories.Where(x => x.isDeleted == isDeleted );
                foreach (var item in list)
                {
                    CategoryDetailDTO dto = new CategoryDetailDTO();
                    dto.CategoryID = item.ID;
                    dto.CategoryName = item.CategoryName;
                    categories.Add(dto);
                }
                return categories;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        public bool Update(Category entity)
        {
            try
            {
                Category category = db.Categories.First(x => x.ID == entity.ID);
                category.CategoryName = entity.CategoryName;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
