using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1
{
    internal class Gyongy
    {
        int _x, _y, _z, _e;

        public Gyongy(int x, int y, int z, int e)
        {
            this._x = x;
            this._y = y;
            this._z = z;
            this._e = e;
        }

        public Gyongy(string CSVsor)
        {
            var sor = CSVsor.Trim().Split(';');
            _x = int.Parse(sor[0]);
            _y = int.Parse(sor[1]);
            _z = int.Parse(sor[2]);
            _e = int.Parse(sor[3]);
        }

        public int X { get => _x; }
        public int Y { get => _y; }
        public int Z { get => _z; }
        public int E { get => _e; }

        public static double Distance(Gyongy first, Gyongy second)
        {
            return Math.Sqrt(Math.Pow(second.X - first.X,2) + Math.Pow(second.Y - first.Y, 2) + Math.Pow(second.Z - first.Z, 2));
        }

        public override string ToString()
        {
            return $"{X};{Y};{Z};{E}";
        }
    }
}
