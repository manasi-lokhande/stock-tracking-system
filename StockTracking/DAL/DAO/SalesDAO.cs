using StockTracking.DAL.DAO;
using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class SalesDAO : StockContent, IDAO<Sale, SalesDetailDTO>
    {
        public bool Delete(Sale entity)
        {            
            if (entity.ID!=0)
            {
                Sale sale = db.Sales.First(x => x.ID == entity.ID);
                sale.isDeleted = entity.isDeleted;
                sale.DeletedDate = entity.DeletedDate;
                db.SaveChanges();
            }
            else if(entity.ProductID != 0)
            {
                List<Sale> sale = db.Sales.Where(x => x.ProductID == entity.ProductID).ToList();
                foreach (var item in sale)
                {
                    item.isDeleted = entity.isDeleted;
                    item.DeletedDate = entity.DeletedDate;                   
                }
                db.SaveChanges();
            }
            else if (entity.CustomerID != 0)
            {
                List<Sale> sale = db.Sales.Where(x => x.CustomerID == entity.CustomerID).ToList();
                foreach (var item in sale)
                {
                    item.isDeleted = entity.isDeleted;
                    item.DeletedDate = entity.DeletedDate;
                }
                db.SaveChanges();
            }
            return true;
        }

        public bool GetBack(int ID)
        {
            try
            {
                Sale sale = db.Sales.First(x => x.ID == ID);
                sale.isDeleted = false;
                sale.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Sale entity)
        {
            try
            {
                db.Sales.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SalesDetailDTO> Select()
        {
            try
            {
                List<SalesDetailDTO> Sales = new List<SalesDetailDTO>();
                var list = (from s in db.Sales.Where(x=>x.isDeleted==false)
                            join p in db.products on
                            s.ProductID equals p.ID
                            join
                            c in db.Categories on s.CategoryID equals c.ID
                            join cu in db.Customers on s.CustomerID equals
                            cu.ID
                            select new SalesDetailDTO 
                            {
                                SalesID = s.ID,
                                CustomerID = s.CustomerID,
                                ProductID = s.ProductID,
                                CategoryID = s.CategoryID,
                                CustomerName = cu.CustomerName,
                                ProductName = p.ProductName,
                                CategoryName = c.CategoryName,
                                SalesAmount = s.ProductSalesAmount,
                                Price = s.ProductSalesPrice,
                                SalesDate = s.SalesDate,
                                StockAmount = p.StockAmount
                            }).OrderBy(x => x.SalesID).ToList();
                foreach (var item in list)
                {
                    SalesDetailDTO dto = new SalesDetailDTO();
                    dto.SalesID = item.SalesID;
                    dto.CustomerID = item.CustomerID;
                    dto.ProductID = item.ProductID;
                    dto.CategoryID = item.CategoryID;
                    dto.ProductName = item.ProductName;
                    dto.CategoryName = item.CategoryName;
                    dto.CustomerName = item.CustomerName;
                    dto.SalesAmount = item.SalesAmount;
                    dto.Price = item.Price;
                    dto.SalesDate = item.SalesDate;
                    dto.StockAmount = item.StockAmount;
                    Sales.Add(dto);                    
                }
                return Sales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<SalesDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<SalesDetailDTO> Sales = new List<SalesDetailDTO>();
                var list = (from s in db.Sales.Where(x => x.isDeleted == isDeleted)
                            join p in db.products on
                            s.ProductID equals p.ID
                            join
                            c in db.Categories on s.CategoryID equals c.ID
                            join cu in db.Customers on s.CustomerID equals
                            cu.ID
                            select new SalesDetailDTO
                            {
                                SalesID = s.ID,
                                CustomerID = s.CustomerID,
                                ProductID = s.ProductID,
                                CategoryID = s.CategoryID,
                                CustomerName = cu.CustomerName,
                                ProductName = p.ProductName,
                                CategoryName = c.CategoryName,
                                SalesAmount = s.ProductSalesAmount,
                                Price = s.ProductSalesPrice,
                                SalesDate = s.SalesDate,
                                StockAmount = p.StockAmount
                            }).OrderBy(x => x.SalesID).ToList();
                foreach (var item in list)
                {
                    SalesDetailDTO dto = new SalesDetailDTO();
                    dto.SalesID = item.SalesID;
                    dto.CustomerID = item.CustomerID;
                    dto.ProductID = item.ProductID;
                    dto.CategoryID = item.CategoryID;
                    dto.ProductName = item.ProductName;
                    dto.CategoryName = item.CategoryName;
                    dto.CustomerName = item.CustomerName;
                    dto.SalesAmount = item.SalesAmount;
                    dto.Price = item.Price;
                    dto.SalesDate = item.SalesDate;
                    dto.StockAmount = item.StockAmount;
                    Sales.Add(dto);
                }
                return Sales;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Sale entity)
        {
            try
            {
                Sale sale = db.Sales.First(x => x.ID == entity.ID);
                sale.ProductSalesAmount = entity.ProductSalesAmount;
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
