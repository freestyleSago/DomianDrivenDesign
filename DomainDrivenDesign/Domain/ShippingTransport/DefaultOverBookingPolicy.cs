using ShippingTransportDomain.Model;
using ShippingTransportDomain.OverbookingPolicy;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingTransportDomain.OverbookingPolicy
{
    public class DefaultOverBookingPolicy : IOverbookingPolicy
    {
        public double CalculateAllowedSize(Voyage voyage, Cargo cargo)
        {
            return voyage.MaxBookingSize;
        }

        public bool IsAllowed(Voyage voyage, Cargo cargo)
        {
            return voyage.BookedCargoesSize + cargo.Size <= voyage.MaxBookingSize;
        }
    }
}
