using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Orchard.Mvc.Filters;
using Orchard.UI.Resources;

namespace Rimango.Modernizr.Filter
{
    public class ModernizrInjectFilter : FilterProvider, IResultFilter
    {
        private readonly IResourceManager _resourceManager;
        public ModernizrInjectFilter(IResourceManager resourceManager) {
            _resourceManager = resourceManager;
        }

        public void OnResultExecuting(ResultExecutingContext filterContext) {
            // Should only run on a full view rendering result
            if (!(filterContext.Result is ViewResult))
                return;

            // Include the following script on all pages
            _resourceManager.Require("script", Globals.Script.Modenizr).AtHead();
        }

        public void OnResultExecuted(ResultExecutedContext filterContext) {
        }
    }
}