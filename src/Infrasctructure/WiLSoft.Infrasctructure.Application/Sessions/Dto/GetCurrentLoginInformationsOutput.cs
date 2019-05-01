using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Infrasctructure.Application.Sessions.Dto
{
    public class GetCurrentLoginInformationsOutput
    {
        public ApplicationInfoDto Application { get; set; }

        public UserLoginInfoDto User { get; set; }

        public TenantLoginInfoDto Tenant { get; set; }
    }
}
