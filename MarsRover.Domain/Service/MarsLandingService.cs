using MarsRover.Domain.Abstract;
using MarsRover.Domain.Enum;
using MarsRover.Domain.Exceptions;
using MarsRover.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Service
{
    public class MarsLandingService
    {
        private readonly IRepository repository;
        private readonly int size;
        private readonly Plateau plateau;

        public MarsLandingService(IRepository repository, int size, Plateau landingPlatform)
        {
            this.repository = repository;
            this.size = size;
            this.plateau = landingPlatform;
        }

        public ResponseType MarsDes(Position pos)
        {
            if (pos.X > size || pos.Y > size || pos.X < 0 || pos.Y < 0)
                throw new InvalidPositionException($"{pos.X},{pos.Y}");

            var lastPosition = repository.AddOrGet(pos);

            if (lastPosition.IsBeside(pos))
                return ResponseType.Crash;
            if (plateau.Contains(pos))
                return ResponseType.MarsDescent;

            return ResponseType.OutOfPlateau;
        }
    }
}