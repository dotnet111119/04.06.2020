using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public static class ObjectExtension
    {
        public static T CloneToType<T>(this object o) where T : new()
        {
            //Activator.CreateInstance<T>
            return new T();
        }

        public static object MemberwiseCloneToThePeople(this object o)
        {
            Type t = o.GetType();
            MethodInfo m = t.GetMethod("MemberwiseClone");
            object result = null;// m.Invoke(o, BindingFlags.NonPublic, null);
            return result;
        }

        public static string ToStringJson(this object o)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }
    }
}
