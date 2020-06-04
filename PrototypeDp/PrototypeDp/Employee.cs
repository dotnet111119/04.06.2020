using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public class Employee
    {
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }

        public double Salary { get; set; }

        public override string ToString()
        {
            return $"{Id} {FName} {LName}";
        }
    }
}
