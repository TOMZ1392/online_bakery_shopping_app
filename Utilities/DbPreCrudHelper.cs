using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace TheBakeryShopper.Utilities
{
    public class DbPreCrudHelper
    {
        private string constr { get; set; }
        public DbPreCrudHelper(string connectionString)
        {
            constr = connectionString;
        }
      
        public int GetLastItemId(int itemType) {
            int maxval = -1;
            string cmdText = "";
            

            switch (itemType)
            {
                case (int)(UploadType.BakeryType):
                    cmdText = "SELECT MAX(BAKE_TYPE_ID) FROM BAKE_TYPE";
                    break;
                case (int)(UploadType.BakeryProduct):
                    cmdText = "SELECT MAX(BAKE_PROD_ID) FROM BAKE_PRODUCT";
                    break;

            }

           using (SqlConnection conn = new SqlConnection(constr)){
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;
                    cmd.CommandText = cmdText;
                    try
                    {
                        conn.Open();
                        var _maxval = cmd.ExecuteScalar();
                        if (_maxval==DBNull.Value)
                        {
                            maxval = 0;
                        }
                        else {
                            maxval = (int)_maxval;
                        }
                        conn.Close();
                    }
                    catch (Exception ex) { 
                        throw ex;
                    }
                    return maxval;
                }  
            }
        }
    }
}
