using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UMSBusinesLayer
{
    public class Rights
    {
        public int RightsId { get; private set; }
        public string RightsCode 
        {
            get
            {
                if (RightsId == 0)
                {
                    return "READONLY";
                }
                else if (RightsId == 1)
                {
                    return "APROVE/REJECT";
                }
                else if (RightsId == 2)
                {
                    return "FULLACCESS";
                }
                else
                {
                    return "ACCESSDENIED";
                }
            }
        }

        public Rights(int rightId)
        {
            if(rightId < 0 || rightId > 2)
            {
                RightsId = 0;
            }
            else
            {
                RightsId = rightId;
            }              
        }
    }
}
