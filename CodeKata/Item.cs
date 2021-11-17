using System;
using System.Collections.Generic;
using System.Text;

namespace CodeKata
{
    public class Item
    {
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int? DiscountAmount { get; set; }
        public int? DiscountPrice { get; set; }

        /// <summary>
        /// Given the amount of item of this type in the cart it returns the total considering the discount
        /// </summary>
        /// <param name="amount"></param>
        /// <returns></returns>
        public int Total(int amount)
        {
            int total = 0;

            while (amount > 0)
            {
                //Use discount price
                if (DiscountAmount.HasValue && amount >= DiscountAmount)
                {
                    total += DiscountPrice.Value;
                    amount -= DiscountAmount.Value;
                }
                //Use unit price
                else
                {
                    total += UnitPrice;
                    amount -= 1;
                }
            }

            return total;
        }
    }
}
