using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MudSpeRece.Shared
{
    public static class CustomExtension
    {
        public static IQueryable<TSource> WhereIf<TSource>(this IQueryable<TSource> Source, bool Condition, Expression<Func<TSource, bool>> Predicate)
        {
            if (Condition)
            {
                return Source.Where(Predicate);
            }
            else
            {
                return Source;
            }
        }
    }
}
