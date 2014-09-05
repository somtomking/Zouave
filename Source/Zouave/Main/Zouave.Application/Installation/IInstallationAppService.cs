namespace Zouave.Application.Installation
{
    public partial interface IInstallationAppService
    {
        void InstallData(string adminUserEmail, string adminUserPassword, bool installSampleData = true);
    }
}
