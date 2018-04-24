using ShippingTransportDomain.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace ShippingTransportDomain.OverbookingPolicy
{
    /// <summary>
    /// 超订策略
    /// </summary>
    public interface IOverbookingPolicy
    {
        /// <summary>
        /// 计算最终载货量
        /// </summary>
        /// <param name="voyage"></param>
        /// <param name="cargo"></param>
        /// <returns></returns>
        double CalculateAllowedSize(Voyage voyage, Cargo cargo);

        /// <summary>
        /// 是否允许承载该货物
        /// </summary>
        /// <param name="voyage"></param>
        /// <param name="cargo"></param>
        /// <returns></returns>
        bool IsAllowed(Voyage voyage, Cargo cargo);
    }
}
