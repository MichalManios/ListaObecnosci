﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lista_obecności.Data.Repository
{
    public interface IFreeDays:IRepository<FreeDays>
    {
        IEnumerable<FreeDays> GetAllFreeDays();
    }
}
