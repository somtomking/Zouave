using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zouave.Services.Installation
{
    public partial interface IInstallationFadeService
    {
        void InstallData(string adminUserEmail, string adminUserPassword, bool installSampleData = true);
    }
}
