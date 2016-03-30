using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using CustomerLibrary;
using ICustomerInterface;

namespace FactoryCustomer
{
    public static class Factory
    {
        private static Lazy<List<ICustomer>> CustomersList = null;

        static Factory()
        {
            CustomersList = new Lazy<List<ICustomer>>(() => LoadCustomers());
        }

        private static List<ICustomer> LoadCustomers() 
        {
            List<ICustomer> listOfCustomers= new List<ICustomer>();
            listOfCustomers.Add(new Lead());
            listOfCustomers.Add(new Customer());
            return listOfCustomers;
        }
        public static ICustomer CreateCustomer(CustomerType customerType)
        {
            return CustomersList.Value[(int)customerType];
        }
    }
}
