﻿using JoveZhao.Framework.DDD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BPiaoBao.DomesticTicket.Domain.Models.Insurance
{
    public interface IInsuranceOrderRepository : IRepository<InsuranceOrder>
    {
        IEnumerable<InsuranceSearchRecord> getAllSearchItem();
    }
}