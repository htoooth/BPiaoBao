﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BPiaoBao.Common.Enums;

namespace BPiaoBao.AppServices.DataContracts.DomesticTicket.DataObject
{
    /// <summary>
    /// 购买保险记录实体
    /// </summary>
    public class ResponseInsuranceDepositLog
    {
        /// <summary>
        /// Id
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// 流水号
        /// </summary>
        public string PayNo { get; set; }

        /// <summary>
        /// 外部交易号
        /// </summary>
        public string OutTradeNo { get; set; }
        /// <summary>
        /// 充值前剩余
        /// </summary>
        public int BeforeLeaveCount { get; set; }


        /// <summary>
        /// 充值后剩余
        /// </summary>
        public int AfterLeaveCount { get; set; }

        /// <summary>
        /// 充值张数
        /// </summary>
        public int DepositCount { get; set; }


        /// <summary>
        /// 充值时间 
        /// </summary>
        public DateTime BuyTime { get; set; }

        /// <summary>
        /// 单价
        /// </summary>
        public decimal SinglePrice { get; set; }

        /// <summary>
        /// 总价
        /// </summary>
        public decimal TotalPrice { get; set; }

        /// <summary>
        ///商户Code
        /// </summary>
        public string BusinessmanCode { get; set; }

        /// <summary>
        ///商户名称
        /// </summary>
        public string BusinessmanName { get; set; }

        /// <summary>
        /// 支付方式
        /// </summary>
        public EnumPayMethod PayWay { get; set; }
        /// <summary>
        /// 支付状态
        /// </summary>
        public EnumInsurancePayStatus BuyState { get; set; }

        /// <summary>
        /// 记录类别
        /// </summary>
        public EnumInsuranceDepositType RecordType { get; set; }

        /// <summary>
        /// 操作员账号
        /// </summary>
        public string OperatorAccount { get; set; }
        /// <summary>
        /// 操作员名称
        /// </summary>
        public string OperatorName { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        public string Remark { get; set; }
    }
}