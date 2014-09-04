namespace Zouave.Web.Framework.Mvc
{
    public class DeleteConfirmationModel : BaseViewEntityModel
    {
        public string ControllerName { get; set; }
        public string ActionName { get; set; }
        public string WindowId { get; set; }
    }
}