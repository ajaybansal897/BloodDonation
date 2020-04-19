using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using Microsoft.Extensions.Configuration;
using CommonModels;
using System.Data;
using Dapper;
using System.Linq;

namespace DataAccessLayer
{
    public class DbCenterHelper
    {
        private IConfiguration _configuration;
        private readonly string DbConnectionString = "DefaultConnection";

        public DbCenterHelper(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Centre> GetAllCentres()
        {
            List<Centre> centres = null;
            string query = "select * from Centers";

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                centres = connection.Query<Centre>(query).ToList();
            }
            return centres;
        }


        public Centre GetCenterDetailsDB(int id)
        {
            string query = "select * from Centers where id='"+id+"'";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(DbHelper.BlogConnectionStringValue(_configuration, DbConnectionString)))
            {
                return connection.QuerySingle<Centre>(query);
            }
        }
    }
}
