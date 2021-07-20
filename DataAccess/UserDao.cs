using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Common.Cache;

namespace DataAccess
{
    public class UserDao : ConnectionToSql
    {

       

        public bool Login(string user, string pass)
        {
            using (var connection = GetConnection())
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "select *from Usuario where LoginName=@user and Password=@pass";
                    command.Parameters.AddWithValue("@user", user);
                    command.Parameters.AddWithValue("@pass", pass);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            UserLoginCache.UserID = reader.GetInt32(0);
                            UserLoginCache.FirstName = reader.GetString(3);
                            UserLoginCache.LastName = reader.GetString(4);
                            UserLoginCache.Permission = reader.GetString(5);
                            UserLoginCache.Setor = reader.GetString(6);

                        }
                        return true;
                    }
                    else
                        return false;
                }

            }
        }

        public void AnyMethod()
        {
            if(UserLoginCache.Permission== Permissions.Administrador)
            {
             
            }
            if (UserLoginCache.Permission == Permissions.Basico)
            {

            }
        }

    }
}

