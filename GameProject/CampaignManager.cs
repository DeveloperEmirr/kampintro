using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class CampaignManager : ICampaiService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("Kampanya : "+ campaign.CampaingnName+"  Fiyatı : "+campaign.CampainPrice);
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya : " + campaign.CampaingnName + "  Silindi ");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya : " + campaign.CampaingnName + "  Fiyatı : " + campaign.CampainPrice +" Güncellendi");
        }
    }
}
