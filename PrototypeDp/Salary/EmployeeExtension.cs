using PrototypeDp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salary
{
    public static class EmployeeExtension
    {
        public static double CalcMultipleSalary(this Employee e, int times)
        {
            //EmployeeExtension
            return e.Salary * times;
        }
        public static IEnumerable<TSource> MyWhere<TSource>(this IEnumerable<TSource> source, Func<TSource, bool> predicate)
        {
            return null;
        }

    }
}
