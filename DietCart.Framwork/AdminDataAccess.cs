using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DietCart.Framwork
{
   public class AdminDataAccess
    {

        const string ConnectiosnString = @"Data Source=(localdb)\mssqllocaldb;Initial Catalog=DietCartDataBase;Integrated Security=True";
        public SqlCommand GetCommand(String query)
            {
                var connection = new SqlConnection(ConnectiosnString);

                SqlCommand cmd = new SqlCommand(query);
                cmd.Connection = connection;
                return cmd;
            }
        }
    }

