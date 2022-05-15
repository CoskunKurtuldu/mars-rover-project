using MarsRover.Domain.Enum;
using MarsRover.Domain.Exceptions;
using MarsRover.Domain.Model;
using MarsRover.Domain.Service;
using System;
using Xunit;

namespace MarsRover.Test
{
    public class ProgramTest:ProgramTestBase
    {
        [Fact]
        public void marsrover_gets_descent_positive()
        {
            Assert.Equal(ResponseType.MarsDescent, MarsLandingService.MarsDes(new Position(5, 5)));
        }

        [Fact]
        public void marsrover_gets_outof_plateau()
        {
            Assert.Equal(ResponseType.OutOfPlateau, MarsLandingService.MarsDes(new Position(16, 15)));
        }

        [Fact]
        public void marsrover_gets_clash_at_the_same_point_with_previous_marsrover()
        {
            MarsLandingService.MarsDes(new Position(7, 7));
            var res = MarsLandingService.MarsDes(new Position(7, 7));
            Assert.Equal(ResponseType.Crash, res);
        }

        [Fact]
        public void marsrover_gets_clash_at_1_point_near_with_previous_marsrover()
        {
            MarsLandingService.MarsDes(new Position(7, 7));
            var res = MarsLandingService.MarsDes(new Position(6, 6));
            Assert.Equal(ResponseType.Crash, res);
        }
        [Fact]
        public void if_position_is_outside_of_plateau_marsrover_gets_invalid_position_exception()
        {
            Assert.Throws<InvalidPositionException>(() => MarsLandingService.MarsDes(new Position(101, 55)));
        }
    }
}
