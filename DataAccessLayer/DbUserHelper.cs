using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using CommonModels;
using System.Data;
using Dapper;
using System.Globalization;
using System.Linq;

namespace DataAccessLayer
{
    public class DbUserHelper
    {
        private IConfiguration _configuration;
        private readonly string DbConnectionString = "DefaultConnection";

        public DbUserHelper(IConfiguration configuration) {
            _configuration = configuration;
        }

        public int RegisterUser(User user)
        {
            
            DateTime theDate = DateTime.ParseExact(user.DOB.ToString(), "dd-MM-yyyy hh.mm.ss tt", CultureInfo.InvariantCulture);
            String dt = theDate.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);

            string query = "INSERT INTO Users (First_Name,Last_Name,Address,Gender,Phone,Password,Email,Age,User_Type,Postal_Code,DOB) VALUES ('"+user.First_Name+"','"+user.Last_Name+"','"+user.Address+"','"+user.Gender+"','"+user.Phone+"','"+user.Password+"','"+user.Email+"','"+user.Age+"','"+user.User_Type+"','"+user.Postal_Code+ "','"+dt+ "'); SELECT SCOPE_IDENTITY()";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
               return connection.Query<int>(query).Single();
            }
        }


        public User GetUserDetailsDB(int id)
        {
            string query = "select * from users where id = '"+id+"'";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                return connection.QuerySingle<User>(query);
            }

        }

    }
}
