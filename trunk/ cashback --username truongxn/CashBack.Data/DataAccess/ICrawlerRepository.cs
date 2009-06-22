﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CashBack.Data
{
    public interface ICrawlerRepository
    {
        IEnumerable<Provider> GetAllProviders();
    }
}
