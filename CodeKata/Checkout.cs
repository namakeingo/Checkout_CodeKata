using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeKata
{
    public class Checkout
    {
        public Item ItemA { get; set; }
        public Item ItemB { get; set; }
        public Item ItemC { get; set; }

        public List<Item> Cart { get; set; }

        public Checkout()
        {
            ItemA = new Item()
            {
                Name = "A",
                UnitPrice = 10,
                DiscountAmount = 3,
                DiscountPrice = 25
            };
            ItemB = new Item()
            {
                Name = "B",
                UnitPrice = 20,
                DiscountAmount = 2,
                DiscountPrice = 30
            };
            ItemC = new Item()
            {
                Name = "C",
                UnitPrice = 30
            };

            Cart = new List<Item>();
        }

        /// <summary>
        /// Calculate the shopping cart total value
        /// </summary>
        /// <returns></returns>
        public int Total()
        {
            int total = 0;

            //Get items of type A and remove them form the list
            int amountA = Cart.Where(x => x.Name == "A").Count();
            Cart.RemoveAll(x => x.Name == "A");
            //Add total for items of type A
            total += ItemA.Total(amountA);

            //Get items of type B and remove them form the list
            int amountB = Cart.Where(x => x.Name == "B").Count();
            Cart.RemoveAll(x => x.Name == "A");
            //Add total for items of type B
            total += ItemB.Total(amountB);

            //Get items of type C and remove them form the list
            int amountC = Cart.Where(x => x.Name == "C").Count();
            Cart.RemoveAll(x => x.Name == "C");
            //Add total for items of type C
            total += ItemC.Total(amountC);

            return total;
        }
    }
}
