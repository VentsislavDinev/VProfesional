using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.WebModule.Core.Authentication.External
{
    public interface IExternalAuthConfiguration
    {
        List<ExternalLoginProviderInfo> Providers { get; }
    }
}
