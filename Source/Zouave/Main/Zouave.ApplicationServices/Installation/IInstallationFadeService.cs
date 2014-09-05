namespace Zouave.ApplicationServices.Installation
{
    public partial interface IInstallationFadeService
    {
        void InstallData(string adminUserEmail, string adminUserPassword, bool installSampleData = true);
    }
}
