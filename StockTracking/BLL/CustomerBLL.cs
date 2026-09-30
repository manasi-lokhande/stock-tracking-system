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
    public class CustomerBLL : IBLL<CustomerDetailDTO, CustomerDTO>
    {
        CustomerDAO dao = new CustomerDAO();
        SalesDAO Salesdao = new SalesDAO();
        public bool Delete(CustomerDetailDTO entity)
        {
            Customer customer = new Customer();
            customer.ID = entity.CustomerID;
            customer.isDeleted = true;
            customer.DeletedDate = DateTime.Today;
            dao.Delete(customer);
            Sale sale = new Sale();
            sale.ProductID = entity.CustomerID;
            sale.isDeleted = true;
            sale.DeletedDate = DateTime.Today;
            Salesdao.Delete(sale);
            return true;
        }

        public bool GetBack(CustomerDetailDTO entity)
        {
            return dao.GetBack(entity.CustomerID);
        }

        public bool Insert(CustomerDetailDTO entity)
        {
            Customer customer = new Customer();
            customer.CustomerName = entity.CustomerName;
            return dao.Insert(customer);
        }

        public CustomerDTO select()
        {
            CustomerDTO customer = new CustomerDTO();
            customer.Customers = dao.Select();
            return customer;
        }

        public bool Update(CustomerDetailDTO entity)
        {
            Customer customer = new Customer();
            customer.CustomerName = entity.CustomerName;
            customer.ID = entity.CustomerID;
            return dao.Update(customer);
        }
    }
}
