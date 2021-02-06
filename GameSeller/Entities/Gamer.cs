﻿using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
{
    class Gamer : IGamer
    {
        public int Id { get; set ; }
        public string UserName { get ; set; }
        public string Password { get ; set ; }
        public string FirstName { get ; set ; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get ; set; }
        public string TcNo { get; set; }

    }
}
