using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Models.Product;
using System.Data;
using Microsoft.Extensions.Options;
using TheBakeryShopper.Models.Appsettings;

namespace TheBakeryShopper.DbLayer
{
    public class ProductTypeCrud
    {
        private string Constr { get; set; }
       

        public ProductTypeCrud(string connectionString)
        {
            Constr = connectionString;
        }

       
        public int DbInsertProdTypeDetails(ProductType prodType) {
            int insertStat = -1;
            using (SqlConnection conn = new SqlConnection(Constr))
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.CommandText = "INSERTPRODTYPE";
                    SqlParameter param1 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Char,
                        Value = prodType.BakeryTypeName,
                        ParameterName = "@name"

                    };
                    SqlParameter param2 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = Convert.ToInt16(prodType.TypeAvailability),
                        ParameterName = "@avl_flg"

                    };
                    SqlParameter param3 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = prodType.TypeDiscount,
                        ParameterName = "@discount"

                    };
                    SqlParameter param4 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Char,
                        Value = prodType.ServerImgPath,
                        ParameterName = "@img_path"

                    };
                    SqlParameter param5 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = prodType.CountItems,
                        ParameterName = "@ct_items"

                    };
                    SqlParameter param6 = new SqlParameter()
                    {
                        Direction = ParameterDirection.Input,
                        SqlDbType = SqlDbType.Int,
                        Value = prodType.CountPurchase,
                        ParameterName = "@ct_purchase"

                    };
                    cmd.Parameters.Add(param1);
                    cmd.Parameters.Add(param2);
                    cmd.Parameters.Add(param3);
                    cmd.Parameters.Add(param4);
                    cmd.Parameters.Add(param5);
                    cmd.Parameters.Add(param6);

                    try
                    {
                        conn.Open();
                        insertStat=cmd.ExecuteNonQuery();
                        conn.Close();
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    return insertStat;
                }
            }



        }
    }
}
