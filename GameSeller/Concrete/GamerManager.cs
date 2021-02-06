using GameSeller.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
   public  class GamerManager : IGamerDatabaseManager
    {
        //encapsulution
        private IGamerMernisCheckService _gamerCheckService;

        public GamerManager(IGamerMernisCheckService gamerCheck)
        {
            _gamerCheckService = gamerCheck;
        }

        public void Insert(Gamer gamer )
        {
            if (_gamerCheckService.GamerCheck(gamer))
            {
                Console.WriteLine("Oyuncu Kayıt edildi");
            }
            else
            {
                Console.WriteLine("Kullanıcı Kimlik Doğrulamadan Geçemedi");
            }
        }
        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
