using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class User
    {
        public int UserId { get; private set; }
        public string UserName { get; set; }
        private Rights userRights;

        public User(int userId, Rights userRight, string userName)
        {
            if(userId < 1)
            {
                throw new ArgumentException("User Id can't be less than 1", "userId");
            }
            else
            {
                UserId = userId;
                userRights = userRight;
                UserName = userName;
            }               
        }
        
        public void ChangeRights(Rights rights)
        {
            userRights = rights;
        }

        public string GetRightsCode()
        {
            string rights = userRights.RightsCode;
            return rights;
        }
    }
}
