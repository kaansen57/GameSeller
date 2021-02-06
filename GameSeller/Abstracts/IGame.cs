using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstracts
{
   public interface IGame
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
    }
}
