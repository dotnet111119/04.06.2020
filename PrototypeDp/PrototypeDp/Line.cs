using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeDp
{
    public class Line : IProto<Line>
    {
        public Point P1 { get; set; }
        public Point P2 { get; set; }

        public Line(Point p1, Point p2)
        {
            P1 = p1;
            P2 = p2;
        }

       

        public override string ToString()
        {
            return $"P1 {P1} P2 {P2}";
        }

        public Line Clone()
        {
            // not good- will shallow copy meaning the Point 1, 2 will not be duplicated
            // but still use the same references!!
            // return this.MemberwiseClone() as Line;

            Line result = new Line(new Point(P1.X, P2.Y), new Point(P2.X, P2.Y));
            return result;
        }
    }
}
