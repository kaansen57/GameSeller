using GameSeller.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
  public  class GamerTestCheckManager : IGamerMernisCheckService
    {
        public bool GamerCheck(Gamer gamer)
        {
            return true;
        }
    }
}
