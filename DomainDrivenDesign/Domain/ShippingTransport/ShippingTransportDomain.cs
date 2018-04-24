using ShippingTransportDomain.Model;
using ShippingTransportDomain.OverbookingPolicy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingTransportDomain
{
    public class ShippingTransportDomain
    {
        public bool MakeBooking(Voyage voyage, Cargo cargo)
        {
            var overBookingPolicy = voyage.OverbookingPolicy ?? new DefaultOverBookingPolicy();

            if (overBookingPolicy.IsAllowed(voyage, cargo))
            {
                voyage.AddCargo(cargo);
                return true;
            }
            return false;
        }
    }
}
