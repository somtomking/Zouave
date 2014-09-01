using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.CommonEntity.Addresss
{
    public partial class AddressBase : Entity
    {
        public string CountryCode { get; set; }
        public string ProvinceCode { get; set; }
        public string CityCode { get; set; }
        public string StreetCode { get; set; }
        public string Detail { get; set; }

    }
}
