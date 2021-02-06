using GameSeller.Abstracts;
using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
    public class GameSellingManager : IGameSellingManager
    {
        private IGamerMernisCheckService _gamerMernisCheckService;
        private ICampaign _campaign;

        public GameSellingManager(IGamerMernisCheckService gamerMernisCheckService)
        {
            _gamerMernisCheckService = gamerMernisCheckService;
        }

        public void Sell(Game game, Gamer gamer)
        {
            if (_gamerMernisCheckService.GamerCheck(gamer))
            {
                Console.WriteLine(gamer.UserName + " adlı kullanıcı " + game.Name + " oyununu satın aldı. ");
                Console.WriteLine("Oyun Bilgileri --> Oyun Adı : "
                    + game.Name + " | Fiyatı : "
                    + game.Price + "TL");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadığı için oyun satışı yapılamadı");
            }

        }
        public void Sell(Game game, Gamer gamer , Campaign campaign)
        {
            _campaign = campaign;

            if (_gamerMernisCheckService.GamerCheck(gamer))
            {
                Console.WriteLine(gamer.UserName + " adlı kullanıcı " + game.Name + " oyununu satın aldı. ");
                Console.WriteLine("Oyun Bilgileri --> Oyun Adı : "
                    + game.Name + " | Fiyatı : "
                    + game.Price + " | Kampanya : "
                    + _campaign.CampaignName + " | İndirimli Fiyat : "
                    + (game.Price - ((game.Price / 100) * _campaign.CampaignDiscountRate)) + "TL");
            }
            else
            {
                Console.WriteLine("Kullanıcı doğrulanamadığı için oyun satışı yapılamadı");
            }

        }
    }
}
