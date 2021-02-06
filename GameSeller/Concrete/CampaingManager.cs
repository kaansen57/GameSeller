using GameSeller.Abstracts;
using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
  public  class CampaingManager : ICampaingManager
    {
        public void Insert(Campaign campaign)
        {
            Console.WriteLine("Yeni kampanya eklendi. Detayları --> "+ campaign.CampaignName +  " İndirim Oranı : "+campaign.CampaignDiscountRate);
        }
        public void Delete(Campaign campaign)
        {
            Console.WriteLine("Kampanya Silindi");
        }
       
        public void Update(Campaign campaign)
        {
            Console.WriteLine("Kampanya Güncellendi");
        }
    }
}
