using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    class GamerManager : 
    {
        public void Insert(IGamer gamer)
        {
            Console.WriteLine("Kayıt edildi");
        }
        public void Delete()
        {
            Console.WriteLine("Oyuncu Silindi");
        }

        public void Update()
        {
            Console.WriteLine("Oyuncu Güncellendi");
        }
    }
}
