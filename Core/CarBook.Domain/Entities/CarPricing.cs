using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarBook.Domain.Entities
{
    public class CarPricing
    {
        public int CarPricingId { get; set; }
        public int CarId { get; set; }
        public Car Car { get; set; }
        public int PricingId { get; set; }
        public Pricing Pricing { get; set; }
        public decimal Amount { get; set; }
        public decimal? DiscountPercentage { get; set; }
        [NotMapped]
        public decimal FinalAmount
        {
            get
            {
                if(DiscountPercentage.HasValue && DiscountPercentage > 0)
                {
                    var discountValue = Amount * (DiscountPercentage.Value / 100);
                    return Amount - discountValue;
                }
                return Amount;
            }
        }
    }
}
