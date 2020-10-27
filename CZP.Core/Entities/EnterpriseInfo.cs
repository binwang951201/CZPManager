using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace CZP.Core.Entities
{
    /// <summary>
    /// 企业信息
    /// </summary>
    public class EnterpriseInfo : BaseEntity
    {
        /// <summary>
        /// 企业名称
        /// </summary>
        [StringLength(50)]
        public string EnterpriseName { get; set; }

        /// <summary>
        /// 企业主页照片
        /// </summary>
        [StringLength(1000)]
        public string EnterpriseHomePageImage { get; set; }

        /// <summary>
        /// 企业简介
        /// </summary>
        [StringLength(500)]
        public string EnterpriseIntroduction { get; set; }

        /// <summary>
        /// 是否展示 
        /// true-展示 false-不展示
        /// </summary>
        public bool IsShow { get; set; }

        /// <summary>
        /// 是否推荐
        /// true-推荐 false-不推荐
        /// </summary>
        public bool IsRecommend { get; set; }

        /// <summary>
        ///设置推荐的时间
        /// </summary>
        public DateTime? SetRecommendDateTime { get; set; }

        /// <summary>
        /// 公司地址
        /// </summary>

        public virtual AddressInfo EnterpriseAddress { get; set; }


        /// <summary>
        /// 添加此企业的管理员
        /// </summary>
        public virtual ManagerInfo ManagerInfo { get; set; }

    }
}
