using System;
using System.Collections.Generic;
using System.Text;

namespace StoreBuild.Domain.Models.User
{
    public class City
    {
        public City()
        {
            
        }

        public int CityId { get; set; }
        public string CityName { get; set; }

        #region Relations

        public List<UserAddress> UserAddresses { get; set; }

        #endregion
    }
}
