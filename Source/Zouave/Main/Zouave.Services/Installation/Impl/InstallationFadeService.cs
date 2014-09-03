using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zouave.Domain;
using Zouave.Domain.Users.Service;

namespace Zouave.Services.Installation.Impl
{
    public partial class InstallationFadeService : IInstallationFadeService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserService _userService;
        public InstallationFadeService(IUnitOfWork unitOfWork, UserService userService)
        {
            _unitOfWork = unitOfWork;
            _userService = userService;
        }
        public void InstallData(string adminUserEmail, string adminUserPassword, bool installSampleData = true)
        {　　
            _userService.TestUser(adminUserEmail, adminUserPassword);
            _unitOfWork.Commit();
        }
    }
}
