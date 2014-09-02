using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Domain.Common
{
    public partial class Address : BaseEntity
    {
        public string CustomerName { get; set; }
        public long CountryId { get; set; }
        public long ProvinceId { get; set; }
        public long CityId { get; set; }
        public long StreetId { get; set; }
        public string Detail { get; set; }
        public string ZipCode { get; set; }
        public string PhoneNumber { get; set; }
        public string FaxNumber { get; set; }
        public virtual Dictionary Country { get; set; }
        public virtual Dictionary Province { get; set; }
        public virtual Dictionary City { get; set; }
        public virtual Dictionary Street { get; set; }

        public DateTime CreateOn { get; set; }
    }
}
