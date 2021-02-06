using System;
using GameSeller.Adapters;
using GameSeller.Concrete;

namespace GameSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            Gamer gamer1 = new Gamer
            {
                Id = 1,
                UserName = "kaansen57",
                Password = "123456",
                FirstName = "kaan",
                LastName = "şen",
                TcNo = "11111111",
                DateOfBirth = new DateTime(1998,08,10),
            };

            GamerManager gamerManager = new GamerManager(new MernisPersonCheck());
            //GamerManager gamerManager = new GamerManager(new GamerTestCheckManager()); /*Test mernis check*/

            gamerManager.Insert(gamer1);
            
        }
    }
}
