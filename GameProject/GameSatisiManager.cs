using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSatisiManager : ICampaiService
    {
        GameSale _gameSale;
        GameSaleManager gameSaleManager;

        public GameSatisiManager(GameSale gameSale,GameSaleManager gameSaleManager)
        {
            _gameSale = gameSale;
            this.gameSaleManager = gameSaleManager;
        }

        public void Add(Campaign campaign)
        {
            _gameSale.GameName = campaign.CampaingnName;
            gameSaleManager.GameSatisi(_gameSale);
        }

        public void Delete(Campaign campaign)
        {
            throw new NotImplementedException();
        }

        public void Update(Campaign campaign)
        {
            throw new NotImplementedException();
        }
    }
}
