using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.WebModule.Core.Authentication.External
{
    public class ExternalAuthConfiguration : IExternalAuthConfiguration, Abp.Dependency.ISingletonDependency
    {
        public List<ExternalLoginProviderInfo> Providers { get; }

        public ExternalAuthConfiguration()
        {
            Providers = new List<ExternalLoginProviderInfo>();
        }
    }
}
