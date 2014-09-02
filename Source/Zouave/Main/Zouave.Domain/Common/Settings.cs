﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Common
{
    public partial class Settings : BaseEntity
    {
        public string Key { get; set; }
        public string Scope { get; set; }
        public string Value { get; set; }
        public int EntityId { get; set; }
    }
}
