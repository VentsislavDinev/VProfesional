using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.WebModule.Core.Authentication.External;

namespace WiLSoft.WebModule.Core.Models.TokenAuth
{
    [AutoMapFrom(typeof(ExternalLoginProviderInfo))]
    public class ExternalLoginProviderInfoModel
    {
        public string Name { get; set; }

        public string ClientId { get; set; }
    }
}
