using Cloud_Shopping_Mall.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Controller
{
    public class CustomerController
    {
        static Database db = new Database();
        public static Customer AuthenticateCustomer(string UserName, string Email,string Password)
        {
            return db.Customers.AuthenticCustomer(UserName, Email, Password);
        }
        public static bool AddCustomer(dynamic customer)
        {
            Customer e = new Customer();
            e.Name = customer.Name;
            e.MobileNo = customer.MobileNo;
            e.Gender = customer.Gender;
            e.Division = customer.Division;
            e.ZipCode = customer.ZipCode;
            e.PresentAddress = customer.PresentAddress;
            e.PermanentAddress = customer.PermanentAddress;
            e.Balance = customer.Balance;
            e.Nid = customer.Nid;
            e.BirthCertificate = customer.BirthCertificate;
            e.Email = customer.Email;
            e.UserName = customer.UserName;
            e.Password = customer.Password;
            return db.Customers.AddCustomer(e);
        }
        public static Customer GetCustomer(string userName,string password)
        {
            return db.Customers.GetCustomer(userName,password);
        }
        public static Customer ForgetCustomer(string userName, string email)
        {
            return db.Customers.ForgetCustomer(userName, email);
        }
        public static bool UpdateCustomer(dynamic customer)
        {
            Customer e = new Customer();
            e.Name = customer.Name;
            e.MobileNo = customer.MobileNo;
            e.Gender = customer.Gender;
            e.Division = customer.Division;
            e.ZipCode = customer.ZipCode;
            e.PresentAddress = customer.PresentAddress;
            e.PermanentAddress = customer.PermanentAddress;
            e.Balance = customer.Balance;
            e.Nid = customer.Nid;
            e.BirthCertificate = customer.BirthCertificate;
            e.Email = customer.Email;
            e.UserName = customer.UserName;
            e.Password = customer.Password;
            return db.Customers.UpdateCustomer(e);
        }
        public static bool DeleteCustomer(string userName,string password)
        {
            return db.Customers.DeleteCustomer(userName,password);
        }
        public static ArrayList GetAllCustomer()
        {
            return db.Customers.GetAllCustomer();
        }
    }
}
