using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class RaportGenerator
    {
        private List<User> _userList;

        public RaportGenerator(List<User> userList)
        {
            _userList = userList;    
        }

        public List<RaportItem> GenerateRaport(int rightsId)
        {
            List<RaportItem> reportItemList = new List<RaportItem>();

            for (int i = 0; i < _userList.Count; i++)
            {
                if(_userList[i].GetRightsId() == rightsId)
                {
                    RaportItem reportItem = new RaportItem(_userList[i].UserId, _userList[i].UserName, _userList[i].GetRightsCode());
                    reportItemList.Add(reportItem);
                }                
            }

            return reportItemList;
        }

        public List<RaportItem> GenerateRaport()
        {
            List<RaportItem> reportItemList = new List<RaportItem>();

            for (int i = 0; i < _userList.Count; i++)
            {
                RaportItem reportItem = new RaportItem(_userList[i].UserId, _userList[i].UserName, _userList[i].GetRightsCode());
                reportItemList.Add(reportItem);
            }
            return reportItemList;
        }
    }
}
