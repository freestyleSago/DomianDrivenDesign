using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingTransportDomain.Model
{
    /// <summary>
    /// 货物
    /// </summary>
    public class Cargo
    {
        public Cargo(double size)
        {
            this.Size = size;
        }
        public double Size { get; set; }
    }
}
