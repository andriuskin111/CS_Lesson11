using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UMSBusinesLayer;


namespace UMS
{
    class Program
    {
        static void Main(string[] args)
        {
            UserRepoository userRepoository = new UserRepoository();
            List<User> userListRetrieved = userRepoository.Retrieve();
            List<RaportItem> userRaportItemList;
            RaportGenerator raportGenerator = new RaportGenerator(userListRetrieved);

            userRaportItemList = raportGenerator.GenerateRaport();

            ShowRaportItemList(userRaportItemList);

            userRaportItemList = raportGenerator.GenerateRaport(1);

            ShowRaportItemList(userRaportItemList);

            Console.ReadLine();
        }

        static void ShowRaportItemList(List<RaportItem> userRaportItemList)
        {
            foreach (var raportItem in userRaportItemList)
            {
                Console.WriteLine($"Id: {raportItem.UserId}, " +
                    $"Name: {raportItem.UserName}, Rights: {raportItem.UserRigtsCode}");
            }
        }
    }
}
