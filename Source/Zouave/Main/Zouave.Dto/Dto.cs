using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Concept;

namespace Zouave.Dto
{
    [Serializable]
    public partial class Dto : IDto
    {
    }
    public partial class DtoWithIdentity : Dto
    {
        public long Id { get; set; }
    }


    
}
