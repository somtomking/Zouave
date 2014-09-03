﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Data
{
    public partial class DataSettings
    {
        public DataSettings()
        {
            RawDataSettings = new Dictionary<string, string>();
        }
        public string DataProvider { get; set; }
        public string DataConnectionString { get; set; }
        public IDictionary<string, string> RawDataSettings { get; private set; }

        public bool IsValid()
        {
            return !String.IsNullOrEmpty(this.DataProvider) && !String.IsNullOrEmpty(this.DataConnectionString);
        }
    }
}
