using Abp.Application.Editions;
using Abp.Application.Features;
using Abp.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace WiLSoft.Infrastructure.Core.Editions
{
    public class EditionManager : AbpEditionManager
    {
        public const string DefaultEditionName = "Standard";

        public EditionManager(
            IRepository<Edition> editionRepository,
            IAbpZeroFeatureValueStore featureValueStore)
            : base(
                editionRepository,
                featureValueStore
            )
        {
        }
    }
}
