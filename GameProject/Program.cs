using System;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new UserValidationManager());
            gamerManager.Add(new Gamer
            {
                Id = 1,
                BirthYear = 2001,
                FirstName = "Emircan",
                LastName = "Yılmaz",
                IdentityNumber = 12345
            });
            
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(new Campaign {
            CampaingnName="%10 luk bir indirim",
            CampainPrice=200
            });
            Campaign campaign2 = new Campaign();
            campaign2.CampaingnName = "%8 lik bir indirim";
            campaignManager.Delete(campaign2);

            GameSale gameSale = new GameSale();
            gameSale.GameName = "GTA 5";

            GameSaleManager gameSaleManager = new GameSaleManager();
            GameSatisiManager gameSatisiManager = new GameSatisiManager(gameSale, gameSaleManager);
            gameSatisiManager.Add(new Campaign
            {
                CampaingnName = gameSale.GameName+"  "+ campaign2.CampaingnName,
                CampainPrice = 200
            });
            Console.ReadLine();
          
        }
    }
}
