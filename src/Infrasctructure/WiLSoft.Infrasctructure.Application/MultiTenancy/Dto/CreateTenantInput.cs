using Abp.Authorization.Users;
using Abp.AutoMapper;
using Abp.MultiTenancy;
using System.ComponentModel.DataAnnotations;
using WiLSoft.Infrastructure.Core.MultiTenancy;

namespace WiLSoft.Infrasctructure.Application.MultiTenancy.Dto
{

    [AutoMapTo(typeof(Tenant))]
    public class CreateTenantInput
    {
        [Required]
        [StringLength(AbpTenantBase.MaxTenancyNameLength)]
        [RegularExpression(Tenant.TenancyNameRegex)]
        public string TenancyName { get; set; }

        [Required]
        [StringLength(Tenant.MaxNameLength)]
        public string Name { get; set; }

        [Required]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string AdminEmailAddress { get; set; }

        [MaxLength(AbpTenantBase.MaxConnectionStringLength)]
        public string ConnectionString { get; set; }
    }
}
