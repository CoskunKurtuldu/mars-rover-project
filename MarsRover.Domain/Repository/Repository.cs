using MarsRover.Domain.Abstract;
using MarsRover.Domain.Model;

namespace MarsRover.Domain.Repository
{
    public class Repository : IRepository
    {
        private Position LastDownPosition = Position.Empty;
        public Position AddOrGet(Position position)
        {
            var oldPos = (Position)LastDownPosition.Clone();
            LastDownPosition = position;
            return oldPos;
        }
    }
}
