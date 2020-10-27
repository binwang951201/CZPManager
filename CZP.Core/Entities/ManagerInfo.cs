using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CZP.Core.Entities
{
    /// <summary>
    /// 管理员信息
    /// </summary>
    public class ManagerInfo:BaseEntity
    {
        /// <summary>
        /// 名称
        /// </summary>
        [StringLength(50)]
        public string Name { get; set; }

        /// <summary>
        /// 账号
        /// </summary>
        [StringLength(50)]
        public string Account { get; set; }

        /// <summary>
        /// 密码
        /// </summary>
        [StringLength(50)]
        public string Password { get; set; }

        /// <summary>
        /// 登录时间
        /// </summary>
        public DateTime? LoginDateTime { get; set; }

        /// <summary>
        /// 添加者编号
        /// </summary>
        public int? AddManagerId { get; set; }

    }
}
