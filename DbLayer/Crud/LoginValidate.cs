using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheBakeryShopper.Models.Users;
using System.Data;
using System.Data.SqlClient;


namespace TheBakeryShopper.DbLayer
{
    public class LoginValidate
    {


        public LoginDetails IsValidUser(LoginDetails user) {
            string conString = "";
            using ( SqlConnection con=new SqlConnection(conString)) {

                using (SqlCommand cmd =new SqlCommand()) {
                    cmd.Connection = con;
                    cmd.CommandText = "SELECT * FROM USERSDET WHERE USERNAME=" + user.UserName + "AND PASSWORD=" + user.UserPassword;
                    con.Open();
                    try
                    {
                        using (SqlDataReader dr = cmd.ExecuteReader()) {
                            if (dr.HasRows)
                            {
                                while (dr.Read())
                                {
                                   // user.UserRole = dr[""];
                                }
                            }
                            else {
                                throw new Exception("LoginFailed");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                    finally { }

                }
            }



                return user;

        } 
    }
}
