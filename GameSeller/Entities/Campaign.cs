using GameSeller.Abstracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Entities
{
    public class Campaign : ICampaign
    {
        public int Id { get; set; }
        public string CampaignName { get ; set ; }
        public double CampaignDiscountRate { get ; set ; }
    }
}
