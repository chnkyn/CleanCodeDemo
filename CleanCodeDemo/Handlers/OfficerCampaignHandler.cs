﻿using CleanCodeDemo.Entities;
using CleanCodeDemo.Interfaces;

namespace CleanCodeDemo.Handlers
{
  public class OfficerCampaignHandler : IPersonCampaignHandler
  {
    public decimal Calculate(Product product)
    {
      return product.ProductPrice * (decimal)0.80;
    }
  }
}
