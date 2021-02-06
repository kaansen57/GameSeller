using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstracts
{
    public interface IGameSellingManager
    {
        void Sell(Game game , Gamer gamer);
       
    }
}
