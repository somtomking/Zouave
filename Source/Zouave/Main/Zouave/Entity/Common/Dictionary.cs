using System;
namespace Zouave.Entity.Common
{
    public class Dictionary : Entity
    {
        public string Code { get; set; }
        public string ParentCode { get; set; }
        public string Value { get; set; }
        public string Scope { get; set; }
    }
}
