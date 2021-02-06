using System;

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
                TcNo = "111111111",
                DateOfBirth = new DateTime(1998,08,10),
            };

            Console.WriteLine(gamer1.DateOfBirth.Year);


        }
    }
}
