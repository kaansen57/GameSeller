using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstracts
{
   public interface ICampaign
    {
        public int Id { get; set; }
        public string CampaignName { get; set; }
        public double CampaignDiscountRate { get; set; }
    }
}
