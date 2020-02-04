using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class RaportItem
    {
        public string UserId { get; private set; }
        public string UserName { get; private set; }
        public string UserRigtsCode { get; private set; }

        public RaportItem(int userId, string userName, string userRightsCode)
        {
            UserId = Convert.ToString(userId);
            UserName = userName;
            UserRigtsCode = userRightsCode;
        }
    }
}
