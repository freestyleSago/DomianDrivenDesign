using ShippingTransportDomain.OverbookingPolicy;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ShippingTransportDomain.Model
{
    /// <summary>
    /// 航行
    /// </summary>
    public class Voyage
    {
        public Voyage(double maxBookingSize)
        {
            this.MaxBookingSize = maxBookingSize;
        }

        /// <summary>
        /// 货物
        /// </summary>
        private ICollection<Cargo> Cargoes { get; set; } = new List<Cargo>();
        /// <summary>
        /// 超订策略
        /// </summary>
        public IOverbookingPolicy OverbookingPolicy { get; set; }

        /// <summary>
        /// 额定最大载货量
        /// </summary>
        public double MaxBookingSize { get; set; }

        /// <summary>
        /// 已装载货物
        /// </summary>
        public double BookedCargoesSize
        {
            get
            {
                return this.Cargoes.Sum<Cargo>(cargo => cargo.Size);
            }
        }

        /// <summary>
        /// 装载货物
        /// </summary>
        /// <param name="cargo"></param>
        internal void AddCargo(Cargo cargo)
        {
            this.Cargoes.Add(cargo);
        }
    }
}
