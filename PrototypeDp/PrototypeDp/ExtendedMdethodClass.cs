using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public static class ExtendedMdethodClass
    {
        public static void Print(this Employee e1)
        {
            Console.WriteLine($"{e1.FName} {e1.LName}");
        }
        public static int Div2(this Int32 i)
        {
            return i / 2;
        }
        //public static T CloneObject<T>(this object source)
        //{
        //    T result = Activator.CreateInstance<T>();
        //    // with reflection - copy all properties
        //    // use deep copy
        //    return result;
        //}
    }
}
