﻿using JoveZhao.Framework.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.SystemSetting.Domain.Models.SMS
{
    public class SMSChargeSet : EntityBase,IAggregationRoot
    {
        public int ID { get; set; }
        /// <summary>
        /// 商户Code
        /// </summary>
        public string Code { get; set; }
        /// <summary>
        /// 单价
        /// </summary>
        public decimal Price { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }
        /// <summary>
        /// 条数
        /// </summary>
        public int Count { get; set; }
        /// <summary>
        /// 状态
        /// </summary>
        public bool State { get; set; }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime { get; set; }

        protected override string GetIdentity()
        {
            return ID.ToString();
        }
    }
}