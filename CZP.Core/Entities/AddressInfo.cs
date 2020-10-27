using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CZP.Core.Entities
{

    /// <summary>
    ///地址信息
    /// </summary>
    public class AddressInfo:BaseEntity
    {
        /// <summary>
        /// 省
        /// </summary>
        [StringLength(50)]
        public string Province { get; set; }

        /// <summary>
        /// 市
        /// </summary>
        [StringLength(50)]
        public string City { get; set; }

        /// <summary>
        /// 区
        /// </summary>
        [StringLength(50)]
        public string District { get; set; }

        /// <summary>
        /// 街道门牌号
        /// </summary>
        [StringLength(200)]
        public string StreetHouseNumber { get; set; }


    }
}
