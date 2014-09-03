using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Configuration
{
    public partial class Setting : BaseEntity
    {
        public Setting() { }

        public Setting(string name, string value, int scope = 0)
        {
            this.Name = name;
            this.Value = value;
            this.Scope = scope;
        }

        /// <summary>
        /// Gets or sets the name
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the value
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// Gets or sets the store for which this setting is valid. 0 is set when the setting is for all stores
        /// </summary>
        public int Scope { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
