using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Model
{
    public class Position : ICloneable
    {
        public static readonly Position Empty = new(int.MinValue, int.MinValue);

        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }



        public bool IsBeside(Position pos)
        {
            if (pos == Empty || this == Empty)
                return false;

            return Math.Max(Math.Abs(pos.X - X), Math.Abs(pos.Y - Y)) <= 1;
        }

        public object Clone()
        {
            return new Position(X, Y);
        }
    }
}
