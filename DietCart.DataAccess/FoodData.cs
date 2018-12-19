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
   public class FoodData
    {
        public List<FoodTable> GetFoodList()
        {
            AdminDataAccess da = new AdminDataAccess();
            SqlCommand cmd = da.GetCommand("SELECT * from FoodTable");

            List<FoodTable> FoodList = GetData(cmd);
            return FoodList;
        }



        public bool Insert(FoodTable obj)
        {
            AdminDataAccess da = new AdminDataAccess();
            SqlCommand cmd = da.GetCommand("INSERT INTO [dbo].[FoodTable] (/*[FoodId],*/[FoodName],[FoodPrice],[FoodQuantity],[FoodStatus])" +
                "VALUES (/*@FoodId,*/  @FoodName, @FoodPrice, @FoodQuantity, @FoodStatus)");

            //SqlParameter p = new SqlParameter("@FoodId", SqlDbType.Int);
            //p.Value = obj.FoodId;

            SqlParameter p1 = new SqlParameter("@FoodName", SqlDbType.VarChar, 200);
            p1.Value = obj.FoodName;

            SqlParameter p2 = new SqlParameter("@FoodPrice", SqlDbType.Float);
            p2.Value = obj.FoodPrice;

            SqlParameter p3 = new SqlParameter("@FoodQuantity", SqlDbType.VarChar, 50);
            p3.Value = obj.FoodQuantity;

            SqlParameter p4 = new SqlParameter("@FoodStatus", SqlDbType.VarChar, 50);
            p4.Value = obj.FoodStatus;


            //cmd.Parameters.Add(p);
            cmd.Parameters.Add(p1);
            cmd.Parameters.Add(p2);
            cmd.Parameters.Add(p3);
            cmd.Parameters.Add(p4);

            cmd.Connection.Open();

            int val = cmd.ExecuteNonQuery();

            cmd.Connection.Close();
            return val > 0;

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
