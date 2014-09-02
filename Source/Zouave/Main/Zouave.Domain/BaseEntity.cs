using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Concept;

namespace Zouave.Domain
{
    public partial class BaseEntity : IDomainObj
    {
        public long Id { get; set; }
    }
}
