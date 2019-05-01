using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using WiLSoft.Infrastructure.Core.MultiTenancy;

namespace WiLSoft.Infrasctructure.Application.Sessions.Dto
{

    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
