using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Model
{
    public class Plateau
    {
        private readonly int MaxX;
        private readonly int MaxY;
        private readonly int MinX;
        private readonly int MinY;

        public Plateau(Position startingPosition, int size)
        {
            MaxX = startingPosition.X;
            MaxY = startingPosition.Y;
            MinX = startingPosition.X + size;
            MinY = startingPosition.Y + size;
        }

        public bool Contains(Position pos)
        {
            return pos.X >= MaxX && pos.Y >= MaxY && pos.X <= MinX && pos.Y <= MinY;
        }
    }
}
