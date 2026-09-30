using StockTracking.DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockTracking.DAL.DAO
{
    public class CustomerDAO : StockContent, IDAO<Customer, CustomerDetailDTO>
    {
        public bool Delete(Customer entity)
        {
            Customer customer = db.Customers.First(x => x.ID == entity.ID);
            customer.isDeleted = entity.isDeleted;
            customer.DeletedDate = entity.DeletedDate;
            db.SaveChanges();
            return true;
        }

        public bool GetBack(int ID)
        {
            try
            {
                Customer customer = db.Customers.First(x => x.ID == ID);
                customer.isDeleted = false;
                customer.DeletedDate = null;
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Insert(Customer entity)
        {
            try
            {
                db.Customers.Add(entity);
                db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select()
        {
            try
            {
                List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
                var list = db.Customers.Where(x=>x.isDeleted == false);
                foreach (var item in list)
                {
                    CustomerDetailDTO dto = new CustomerDetailDTO();
                    dto.CustomerID = item.ID;
                    dto.CustomerName = item.CustomerName;
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public List<CustomerDetailDTO> Select(bool isDeleted)
        {
            try
            {
                List<CustomerDetailDTO> customers = new List<CustomerDetailDTO>();
                var list = db.Customers.Where(x => x.isDeleted == isDeleted);
                foreach (var item in list)
                {
                    CustomerDetailDTO dto = new CustomerDetailDTO();
                    dto.CustomerID = item.ID;
                    dto.CustomerName = item.CustomerName;
                    customers.Add(dto);
                }
                return customers;
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        public bool Update(Customer entity)
        {
            try
            {
                Customer customer = db.Customers.First(x => x.ID == entity.ID);
                customer.CustomerName = entity.CustomerName;
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
