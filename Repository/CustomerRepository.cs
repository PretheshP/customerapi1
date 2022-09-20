using MFPE_CustomerApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;

namespace MFPE_CustomerApi.Repository
{
    public class CustomerRepository : IRepository<Customer>
    {
        //static readonly log4net.ILog _log4net = log4net.LogManager.GetLogger(typeof(CustomerRepository));
        public static List<Customer> ListCustomer = new List<Customer>()
        {
            new Customer {CustomerId = 1, Name = "Akshay", Address = "Ernakulam",  PANno = "DCRP67871234" , DOB = Convert.ToDateTime("1996-12-20 08:02:01 AM")},
            new Customer {CustomerId = 2, Name = "Abhi", Address = "Delhi", PANno = "DCRP76523456", DOB = Convert.ToDateTime("1997-11-09 01:02:01 AM")}
        };
        
        public bool Add(Customer item)
        {
            try
            {
                ListCustomer.Add(item);
                //_log4net.Info("Customer details has been successfully entered.");
                return true;
            }
            catch(Exception e)
            {
                //_log4net.Error("Error" + e.Message);
            }
            return false;
        }
        
        public Customer Get(int id)
        {
            try
            {
                //_log4net.Info("Customer details  has been successfully retrieved");
                return ListCustomer.Find(p => p.CustomerId == id);
            }
            catch(Exception e)
            {
                //_log4net.Error("Error " + e.Message);
                throw e;
            }
            
        }        
        
        public IEnumerable<Customer> GetAll()
        {
           
                //_log4net.Info("Customer details is finally recieved.");
                return ListCustomer.ToList();
            
        }

    }
}
