using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{


    class Program
    {
        static void Main(string[] args)
        {
            // 1. struct vs class
            // 2. immutable vs mutable
            // 3. string
            // 4. extension methods

            List<int> arr = new List<int>();
            //arr.Where

            Employee e1 = new Employee();
            Employee clone_cmp = e1.CloneToType<Employee>();
            e1.FName = "itay";
            e1.LName = "gold";
            e1.Salary = 50000;
            Console.WriteLine(e1.ToStringJson());

            Point secretPoint = new Point(4.5f, 9.876f);
            secretPoint.name = "abc";

            Point clone_point = secretPoint.Clone();

            // string has a value-type behavior
            // immutable

            int z = 20;
            clone_point.name = "efd"; // string also ref
            object o = new object();

            // why not the same ??? string also ref
            Console.WriteLine(secretPoint.name == clone_point.name);

            LineW line1 = new LineW(new Point(1, 1), new Point(2, 2));
            LineW line2 = line1.Clone() as LineW; // shallow
            line1.P1.X = 10; // will affect both


            ShareSecretData(secretPoint.Clone());

            Console.WriteLine(secretPoint);

            LineW line12 = new LineW(new Point(1, 1), new Point(2, 2));
            ShareSecretData(line1.Clone() as LineW);
            Console.WriteLine();

            Point p1 = new Point(1, 1);
            Point p2 = p1;
            p2.X = 12;

            int x = 3;
            int y = x;
            x = 5;




        }
        static void ShareSecretData(Point p)
        {
            Console.WriteLine("Register point");
            p.X = -999;
            Console.WriteLine($"Point in ShareSecretData {p}");
        }

        static void ShareSecretData(LineW l1)
        {
            l1.P1.X = -999;
        }
    }
}
