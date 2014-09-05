using Zouave.Domain;
using Zouave.Domain.Users.Service;

namespace Zouave.Application.Installation.Impl
{
    public partial class InstallationAppService : IInstallationAppService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly UserService _userService;
        public InstallationAppService(IUnitOfWork unitOfWork, UserService userService)
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
