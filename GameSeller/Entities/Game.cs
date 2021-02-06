using GameSeller.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Entities
{
    public class Game : IGame
    {
        public int Id { get ; set; }
        public string Name { get; set; }
        public string Type { get ; set; }
        public double Price { get ; set; }
    }
}
