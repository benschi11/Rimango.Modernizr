using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Orchard.UI.Resources;

namespace Rimango.Modernizr
{
    public class ResourceManifest : IResourceManifestProvider
    {
        public void BuildManifests(ResourceManifestBuilder builder) {
            var manifest = builder.Add();

            manifest.DefineScript(Globals.Script.Modenizr).SetUrl("modernizr.min.js","modernizr.js");
        }
    }
}