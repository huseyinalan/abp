﻿using System.Collections.Generic;
using Volo.Abp.AspNetCore.Mvc.UI.Bundling;

namespace Volo.Abp.AspNetCore.Components.Server.Theming.Bundling
{
    public class BlazorGlobalScriptContributor : BundleContributor
    {
        public override void ConfigureBundle(BundleConfigurationContext context)
        {
            context.Files.AddIfNotContains("/_framework/blazor.server.js");
            context.Files.AddIfNotContains("/_content/Blazorise/blazorise.js");
            context.Files.AddIfNotContains("/_content/Blazorise.Bootstrap/blazorise.bootstrap.js");
        }
    }
}