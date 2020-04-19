using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.Configuration;
using CommonModels;
using DataAccessLayer;

namespace ClassLibrary.BusinessLogic
{
    public class CentreHandler
    {
        private IConfiguration _configuration;
        
        public CentreHandler(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public List<Centre> GetAllCentres()
        {
            DbCenterHelper data = new DbCenterHelper(_configuration);

            var centres = data.GetAllCentres();

            return centres;
        }

        public Centre GetCenterDetails(int id)
        {
            DbCenterHelper data = new DbCenterHelper(_configuration);

            return data.GetCenterDetailsDB(id);
        }
    }
}
