using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class ProductDAO :StockContent, IDAO<product, ProductDetailDTO>
    {
        public bool Delete(product entity)
        {
            try
            {
                if (entity.ID != 0)
                {
                    product product = db.products.First(x => x.ID == entity.ID);
                    product.isDeleted = entity.isDeleted;
                    product.DeletedDate = entity.DeletedDate;
                    db.SaveChanges();
                }
                else if(entity.CategoryID != 0)
                {
                    List<product> products = db.products.Where(x => x.CategoryID == entity.CategoryID).ToList();
                    foreach (var item in products)
                    {
                        item.isDeleted = entity.isDeleted;
                        item.DeletedDate = entity.DeletedDate;
                        List<Sale> sale = db.Sales.Where(x => x.ProductID == item.ID).ToList();
                        foreach (var item1 in sale)
                        {
                            item1.isDeleted = entity.isDeleted;
                            item1.DeletedDate = entity.DeletedDate;
                        }
                        db.SaveChanges();
                    }
                    db.SaveChanges();
                }
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
                product product = db.products.First(x => x.ID == ID);
                product.isDeleted = false;
                product.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(product entity)
        {
            try
            {
                db.products.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ProductDetailDTO> Select()
        {
            try
            {
                List<ProductDetailDTO> product = new List<ProductDetailDTO>();
                var list = (from p in db.products.Where(x => x.isDeleted == false)
                            join c in db.Categories on
                            p.CategoryID equals c.ID
                            select new ProductDetailDTO
                            {
                                ProductID = p.ID,
                                ProductName = p.ProductName,
                                CategoryId = p.CategoryID,
                                CategoryName = c.CategoryName,
                                StockAmount = p.StockAmount,
                                Price = p.Price,
                            }
                 ).OrderBy(x => x.ProductID).ToList();

                foreach (var item in list)
                {
                    ProductDetailDTO dto = new ProductDetailDTO();
                    dto.ProductID = item.ProductID;
                    dto.ProductName = item.ProductName;
                    dto.CategoryId = item.CategoryId;
                    dto.CategoryName = item.CategoryName;
                    dto.StockAmount = item.StockAmount;
                    dto.Price = item.Price;
                    product.Add(dto);
                }
                return product;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<ProductDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<ProductDetailDTO> product = new List<ProductDetailDTO>();
                var list = (from p in db.products.Where(x => x.isDeleted == isDeleted)
                            join c in db.Categories on
                            p.CategoryID equals c.ID
                            select new ProductDetailDTO
                            {
                                ProductID = p.ID,
                                ProductName = p.ProductName,
                                CategoryId = p.CategoryID,
                                CategoryName = c.CategoryName,
                                StockAmount = p.StockAmount,
                                Price = p.Price,
                            }
                 ).OrderBy(x => x.ProductID).ToList();

                foreach (var item in list)
                {
                    ProductDetailDTO dto = new ProductDetailDTO();
                    dto.ProductID = item.ProductID;
                    dto.ProductName = item.ProductName;
                    dto.CategoryId = item.CategoryId;
                    dto.CategoryName = item.CategoryName;
                    dto.StockAmount = item.StockAmount;
                    dto.Price = item.Price;
                    product.Add(dto);
                }
                return product;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(product entity)
        {
            try
            {
                product product = db.products.First(x => x.ID == entity.ID);
                if (entity.CategoryID == 0)
                {
                    product.StockAmount = entity.StockAmount;                    
                }
                else
                {
                    product.ProductName = entity.ProductName;
                    product.CategoryID = entity.CategoryID;
                    product.Price = entity.Price;
                }
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
