using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    //Oyuncu bilgileri
    public interface IGamer
    {
         int Id { get; set; }
         string UserName { get; set; }
         string Password { get; set; }
         string FirstName { get; set; }
         string LastName { get; set; }
         DateTime DateOfBirth { get; set; }
         string TcNo { get; set; }
    }
}
