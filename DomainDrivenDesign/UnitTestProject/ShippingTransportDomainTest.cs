using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShippingTransportDomain.Model;
using System;
using Domain = ShippingTransportDomain;

namespace UnitTestProject
{
    [TestClass]
    public class ShippingTransportDomainTest
    {
        public Domain.ShippingTransportDomain ShippingTransportDomain { get; set; } = new Domain.ShippingTransportDomain();

        [TestMethod]
        public void MakeBooking()
        {
            var voyage = new Voyage(100);
            for (int i = 0; i < 50; i++)
            {
                var cargo = new Cargo(new Random().NextDouble() * 100);
                if (ShippingTransportDomain.MakeBooking(voyage, cargo) == false)
                {
                    break;
                }
            }
        }
    }
}
