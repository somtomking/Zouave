using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Concept;

namespace Zouave.Dto.Configuration
{

    public partial class SettingDto : DtoWithIdentity
    {

        public string Name { get; set; }


        public string Value { get; set; }


        public int Scope { get; set; }
    }
}
