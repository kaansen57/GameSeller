using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstracts
{
    public interface ICampaingManager
    {
        void Insert(Campaign campaign);
        void Delete(Campaign campaign);
        void Update(Campaign campaign);
    }
}
