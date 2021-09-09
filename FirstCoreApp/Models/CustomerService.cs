using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstCoreApp.Models
{
    public class CustomerService:ICustomer
    {
        private ApplicationContext context;
        public CustomerService()
        {
            context = new ApplicationContext();
        }

        public Customer AddCustomer(Customer cc)
        {
            context.Customers.Add(cc);
            context.SaveChanges();
            return cc;
        }

        public List<Customer> GetCustomers()
        {
            var cc = context.Customers.ToList();
            return cc;
        }
        /*
List<Customer> Customers;
List<Address> Addresses;
public CustomerService()
{
   Customers = new List<Customer>()
   {
       new Customer(){Id=1,Name="deepak",Email="deep90@gmail.com",Mobile="923892323"},
       new Customer(){Id=2,Name="rajesh",Email="rajesh90@gmail.com",Mobile="883892323"},
       new Customer(){Id=3,Name="mohit",Email="mohit90@gmail.com",Mobile="773892323"}
   };

   Addresses = new List<Address>()
   {
       new Address(){Id=1,Address1="noida",Address2="noida-2",City="UP",Pin=201301,CustomerId=1},
       new Address(){Id=2,Address1="mayur vihar",Address2="delhi",City="delhi",Pin=110092,CustomerId=2},
       new Address(){Id=3,Address1="yamuna bank ",Address2="delhi",City="delhi",Pin=110092,CustomerId=3},

   };
}

public string Message()
{
   return "message from service 1";
}
public ViewModel GetModel()
{
   ViewModel model = new ViewModel()
   {
       Customers = Customers,
       Addresses = Addresses
   };
   return model;
}
public List<Customer> GetCustomers()
{
   var customer = Customers.ToList();
   return customer;
}

public Customer AddCustomer(Customer cc)
{
   Customers.Add(cc);
   return cc;
}*/

    }
}
