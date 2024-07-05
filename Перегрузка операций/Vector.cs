using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Перегрузка_операций
{
      class Vector
    {
        public double X {  get; set; }
        public double Y { get; set; }
        public double Z { get; set; }

        public Vector(double x, double y, double z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public static Vector operator +(Vector v1, Vector v2)
        {
            return new Vector(v1.X + v2.X, v1.Y + v2.Y, v1.Z + v2.Z);
        }

        public static Vector operator -(Vector v1, Vector v2)
        {
            return new Vector(v1.X - v2.X, v1.Y - v2.Y, v1.Z - v2.Z);
        }

        public static double operator *(Vector v1, Vector v2)
        {
            return v1.X * v2.X + v1.X * v2.Y + v1.Z * v2.Z; 
        }
        public double Length()
        {
            return Math.Sqrt(X * X + Y * Y + Z * Z);
        }

        public double Cos(Vector v)
        {
            double dot = this * v;
            double length = this.Length() * v.Length();
            return dot / length;
        }
    }

    
}


