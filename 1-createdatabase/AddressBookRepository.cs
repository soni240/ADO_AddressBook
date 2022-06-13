using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_createdatabase
{
    public class AddressBookRepository
    {
        //Give path for Database Connection
        public static string connection = @"Server=.;Database=Address_Book_Service_DB;Trusted_Connection=True;";
        //Represents a connection to Sql Server Database
        SqlConnection sqlConnection = new SqlConnection(connection);
    }

}

