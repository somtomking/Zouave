using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Dto.Security
{
    public partial class SecuritySettingsDto : Dto, ISettings
    {
       
        public bool ForceSslForAllPages { get; set; }

        
        public string EncryptionKey { get; set; }

       
        public List<string> AdminAreaAllowedIpAddresses { get; set; }
    }
}
