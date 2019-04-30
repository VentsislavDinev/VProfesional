using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WiLSoft.Authentatiocation.Models.Seed.Host
{
    public class InitialHostDbBuilder
    {
        private readonly AuthDbContext _context;

        public InitialHostDbBuilder(AuthDbContext context)
        {
            _context = context;
        }

        public void Create()
        {
            new DefaultEditionCreator(_context).Create();
            new DefaultLanguagesCreator(_context).Create();
            new HostRoleAndUserCreator(_context).Create();
            new DefaultSettingsCreator(_context).Create();

            _context.SaveChanges();
        }
    }
}
