using System;
namespace Zouave.CommonEntity.Common
{
    public partial class DictionaryBase : Entity
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string Value { get; set; }
        public string Scope { get; set; }
    }
}
