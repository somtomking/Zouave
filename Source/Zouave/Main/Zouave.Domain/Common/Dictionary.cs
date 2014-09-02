using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Common
{
    public partial class Dictionary : BaseEntity
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string Value { get; set; }
        /// <summary>
        /// 范围
        /// </summary>
        public string Scope { get; set; }
        /// <summary>
        /// 领域标记
        /// </summary>
        public string DomainSign { get; set; }
        public long ParentId { get; set; }

        public virtual Dictionary Parent { get; set; }
    }
}
