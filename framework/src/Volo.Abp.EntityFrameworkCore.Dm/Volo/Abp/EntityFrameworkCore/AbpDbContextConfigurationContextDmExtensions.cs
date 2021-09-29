using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Volo.Abp.EntityFrameworkCore.DependencyInjection;

namespace Volo.Abp.EntityFrameworkCore
{
    public static class AbpDbContextConfigurationContextDmExtensions
    {
        public static DbContextOptionsBuilder UseDm(
           [NotNull] this AbpDbContextConfigurationContext context,
           [CanBeNull] Action<DmDbContextOptionsBuilder> DmOptionsAction = null)
        {
            if (context.ExistingConnection != null)
            {
                return context.DbContextOptions.UseDm(context.ExistingConnection,
                     optionsBuilder =>
                    {
                        optionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                        DmOptionsAction?.Invoke(optionsBuilder);
                    });
            }
            else
            {
                return context.DbContextOptions.UseDm(context.ConnectionString,
                    optionsBuilder =>
                    {
                        optionsBuilder.UseQuerySplittingBehavior(QuerySplittingBehavior.SplitQuery);
                        DmOptionsAction?.Invoke(optionsBuilder);
                    });
            }
        }
    }
}
