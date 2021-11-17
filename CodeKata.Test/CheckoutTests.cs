using NUnit.Framework;
using CodeKata;

namespace CodeKata.Test
{
    public class CheckoutTests
    {
        private Checkout CheckoutTest { get; set; }

        /// <summary>
        /// SetUp method to simply initialize test instance of Checkout before each test
        /// </summary>
        [SetUp]
        public void Setup()
        {
            CheckoutTest = new Checkout();
        }


        /// <summary>
        /// Test 1 item of type A in the cart
        /// </summary>
        [Test]
        public void Test_1A()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);

            Assert.IsTrue(CheckoutTest.Total() == 10);
        }

        /// <summary>
        /// Test 3 items of type A in the cart
        /// </summary>
        [Test]
        public void Test_3A()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);

            Assert.IsTrue(CheckoutTest.Total() == 25);
        }

        /// <summary>
        /// Test 7 items of type A in the cart
        /// </summary>
        [Test]
        public void Test_7A()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);

            Assert.IsTrue(CheckoutTest.Total() == 60);
        }

        /// <summary>
        /// Test 1 item of type B in the cart
        /// </summary>
        [Test]
        public void Test_1B()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);

            Assert.IsTrue(CheckoutTest.Total() == 20);
        }

        /// <summary>
        /// Test 2 item of type B in the cart
        /// </summary>
        [Test]
        public void Test_2B()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);

            Assert.IsTrue(CheckoutTest.Total() == 30);
        }

        /// <summary>
        /// Test 1 item of type C in the cart
        /// </summary>
        [Test]
        public void Test_1C()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemC);

            Assert.IsTrue(CheckoutTest.Total() == 30);
        }

        /// <summary>
        /// Test 4 item of type A + 3 items of type B + 1 item of type C  in the cart
        /// </summary>
        [Test]
        public void Test_4A_3B_1C()
        {
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemA);
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);
            CheckoutTest.Cart.Add(CheckoutTest.ItemB);
            CheckoutTest.Cart.Add(CheckoutTest.ItemC);

            Assert.IsTrue(CheckoutTest.Total() == 115);
        }


    }
}