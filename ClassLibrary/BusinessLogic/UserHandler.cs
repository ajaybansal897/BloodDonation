using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using CommonModels;
using DataAccessLayer;

namespace ClassLibrary.BusinessLogic
{
    public class UserHandler
    {
        private IConfiguration _configuration;


        public UserHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }


        public int CreateUser(User user)
        {
            DbUserHelper data = new DbUserHelper(_configuration);
            return data.RegisterUser(user);
        }

        public User GetUserDetails(int id)
        {
            DbUserHelper data = new DbUserHelper(_configuration);
            return data.GetUserDetailsDB(id);

        }
    }
}
