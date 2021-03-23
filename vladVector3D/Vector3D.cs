using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vladVector3D
{
    public class Vector3D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Z { get; set; }

        public Vector3D()
        {
            X = 0;
            Y = 0;
            Z = 0;
        }
        public Vector3D(int x, int y, int z)
        {
            X = x;
            Y = y;
            Z = z;
        }

        public Vector3D(Vector3D vector)
        {
            X = vector.X;
            Y = vector.Y;
            Z = vector.Z;
        }

        public Vector3D SumOfVectors(Vector3D vector)
        {
            return new Vector3D(X + vector.X, Y + vector.Y, Z + vector.Z);
        }
        public Vector3D SubstractionOfVectors(Vector3D vector)
        {
            return new Vector3D(X - vector.X, Y - vector.Y, Z - vector.Z);
        }

        public int ScalarOfVectors(Vector3D vector)
        {
            return (X * vector.X) + (Y * vector.Y) + (Z * vector.Z);
        }

        public static Vector3D operator ++(Vector3D vector) => new Vector3D(vector.X + 1, vector.Y + 1, vector.Z + 1);
        public static Vector3D operator --(Vector3D vector) => new Vector3D(vector.X - 1, vector.Y - 1, vector.Z - 1);

        public  static implicit operator  string(Vector3D vector) => vector.ToString();
        public override string ToString() => $"X: {X}. Y: {Y}. Z: {Z}.";
    }
}
