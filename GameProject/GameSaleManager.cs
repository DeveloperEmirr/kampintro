using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    class GameSaleManager : IGameSale
    {
        public void GameSatisi(GameSale gameSale)
        {
            Console.WriteLine("Oyun Satışı Gerçekleşti : "+gameSale.GameName);
        }
    }
}
