using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public class Point : IProto<Point>
    {
        private static int ID_Point = 0;

        public float X { get; set; }
        public float Y { get; set; }

        private int zz = 1;

        public string name = "";

        public readonly int ID;

        public Point(float x, float y)
        {
            ID_Point++;
            ID = ID_Point;
            zz = ID;
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"X : {X} Y : {Y}";
        }

        public Point Clone()
        {
            // 1 -- using object MemberwiseClone
            //      memberwise clone will not 
            Point result = (Point)this.MemberwiseClone();
            return result;

            // 2 -- my own custom clone
            // will handle well ID_Point
            //Point clone = new Point(this.X, this.Y);
            //return clone;

        }
    }
}
