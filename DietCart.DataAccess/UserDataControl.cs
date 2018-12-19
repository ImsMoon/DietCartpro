using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DietCart.Entity;
using DietCart;
using DietCart.Framwork;
using System.Data.SqlClient;
using System.Data;

namespace DietCart.DataAccess
{
    public class UserDataControl
    {


        public List<FoodTable> GetNormalFoodList()
        {
            AdminDataAccess da = new AdminDataAccess();
            SqlCommand cmd = da.GetCommand("select * from FoodTable where FoodStatus ='normal'");

            List<FoodTable> FoodList = GetData(cmd);
            return FoodList;
        }

        public List<FoodTable> GetOverFoodList()
        {
            AdminDataAccess da = new AdminDataAccess();
            SqlCommand cmd = da.GetCommand("select * from FoodTable where FoodStatus ='over'");

            List<FoodTable> FoodList = GetData(cmd);
            return FoodList;
        }

        public List<FoodTable> GetUnderFoodList()
        {
            AdminDataAccess da = new AdminDataAccess();
            SqlCommand cmd = da.GetCommand("select * from FoodTable where FoodStatus ='under'");

            List<FoodTable> FoodList = GetData(cmd);
            return FoodList;
        }




        List<FoodTable> GetData(SqlCommand cmd)
        {



            cmd.Connection.Open();

            SqlDataReader reader = cmd.ExecuteReader();
            List<FoodTable> list = new List<FoodTable>();

            using (reader)
            {
                while (reader.Read())
                {
                    FoodTable obj = new FoodTable();
                    obj.FoodId = reader.GetInt32(0);
                    obj.FoodName = reader.GetString(1);
                    obj.FoodPrice = reader.GetDouble(2);
                    obj.FoodQuantity = reader.GetString(3);
                    obj.FoodStatus = reader.GetString(4);

                    list.Add(obj);
                }
                reader.Close();
            }
            cmd.Connection.Close();

            return list;
        }


    }
}
