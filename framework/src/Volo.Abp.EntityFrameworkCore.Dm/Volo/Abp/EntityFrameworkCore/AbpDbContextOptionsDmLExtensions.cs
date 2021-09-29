using JetBrains.Annotations;
using System;
using Microsoft.EntityFrameworkCore.Infrastructure;

namespace Volo.Abp.EntityFrameworkCore
{
    public static class AbpDbContextOptionsDmLExtensions
    {
        public static void UseDm(
                [NotNull] this AbpDbContextOptions options,
                [CanBeNull] Action<DmDbContextOptionsBuilder> DmOptionsAction = null)
        {
            options.Configure(context =>
            {
                context.UseDm(DmOptionsAction);
            });
        }

        public static void UseDm<TDbContext>(
            [NotNull] this AbpDbContextOptions options,
            [CanBeNull] Action<DmDbContextOptionsBuilder> DmOptionsAction = null)
            where TDbContext : AbpDbContext<TDbContext>
        {
            options.Configure<TDbContext>(context =>
            {
                context.UseDm(DmOptionsAction);
            });
        }
    }
}
