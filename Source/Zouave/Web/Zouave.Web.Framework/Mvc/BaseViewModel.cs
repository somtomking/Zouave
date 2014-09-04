using System.Collections.Generic;
using System.Web.Mvc;

namespace Zouave.Web.Framework.Mvc
{
    /// <summary>
    /// Base view model
    /// </summary>
    public partial class BaseViewModel
    {
        public BaseViewModel()
        {
            this.CustomProperties = new Dictionary<string, object>();
        }
        public virtual void BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
        }

        /// <summary>
        /// Use this property   any custom value for your models. 
        /// </summary>
        public Dictionary<string, object> CustomProperties { get; set; }
    }

    /// <summary>
    /// Base view entity model
    /// </summary>
    public partial class BaseViewEntityModel : BaseViewModel
    {
        public virtual long Id { get; set; }
    }
}
