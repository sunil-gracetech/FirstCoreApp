using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
   public  interface ICustomer
    {
        //string Message();
        //ViewModel GetModel();
        List<Customer> GetCustomers();
        Customer AddCustomer(Customer cc);
        bool DeleteCustomer(int id);
        Customer GetCustomer(int id);
        Customer UpdateCustomer(Customer cc);
        bool ValidateUser(string mobile);
    }
}
