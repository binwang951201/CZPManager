using System;
using System.Collections.Generic;
using System.Text;

namespace CZP.Core.Entities
{
    /// <summary>
    /// 实体模型的基类
    /// 所有实体都需要继承该类
    /// </summary>
    public class BaseEntity
    {
        public BaseEntity()
        {
            this.AddDateTime = DateTime.Now;
            this.IsDelete = false;
        }


        /// <summary>
        /// 主键 自增
        /// </summary>
        public int ID { get; set; }

       /// <summary>
       /// 添加时间
       /// </summary>
        public DateTime AddDateTime { get; set; }

        /// <summary>
        /// 是否删除 true-删除  false-未删除
        /// 默认为 false
        /// </summary>
        public bool IsDelete { get; set; }
    }
}
