using System;
using GameSeller.Adapters;
using GameSeller.Concrete;
using GameSeller.Entities;

namespace GameSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 0,
                UserName = "kaansen57",
                Password = "123456",
                FirstName = "kaan",
                LastName = "şen",
                TcNo = "1111111111",
                DateOfBirth = new DateTime(1998,08,10),
            };

            Game game = new Game { Id = 0, Name = "Metin2", Type = "Savaş", Price = 80 };
            Game game2 = new Game { Id = 0, Name = "Knight Online", Type = "Savaş", Price = 60 };
            Game game3 = new Game { Id = 0, Name = "NFS", Type = "Yarış", Price = 100 };

            GamerManager gamerManager = new GamerManager(new MernisPersonCheck());
            //GamerManager gamerManager = new GamerManager(new GamerTestCheckManager()); /*Test mernis check*/

            gamerManager.Insert(gamer1);

           
            Campaign campaign = new Campaign { Id = 0, CampaignName = "Sezon İndirimi", CampaignDiscountRate = 20 };
            Campaign campaign2 = new Campaign { Id = 0, CampaignName = "Kış İndirimi", CampaignDiscountRate = 10 };

            CampaingManager campaingManager = new CampaingManager();

            campaingManager.Insert(campaign);
            campaingManager.Insert(campaign2);

            GameSellingManager gameSellingManager = new GameSellingManager(new GamerTestCheckManager());

            gameSellingManager.Sell(game, gamer1);
            gameSellingManager.Sell(game2, gamer1,campaign2);
            gameSellingManager.Sell(game3, gamer1,campaign);

        }
    }
}
