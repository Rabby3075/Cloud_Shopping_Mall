using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using Cloud_Shopping_Mall.View;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cloud_Shopping_Mall.Model
{
   public  class Database
    {
        public Admins Admins { get; set; }
        public Employees Employees { get; set; }
        public Customers Customers { get; set; }
        public Shops Shops { get; set; }
        public Database()
        {
            string conn = @"Server=RABBY-PC\SQLEXPRESS;Database=CloudShop;User Id=sa;Password=1234;";
            SqlConnection connection = new SqlConnection(conn);


            Admins = new Admins(connection);
            Employees = new Employees(connection);
            Customers = new Customers(connection);
            Shops = new Shops(connection);

        }
    }
}
