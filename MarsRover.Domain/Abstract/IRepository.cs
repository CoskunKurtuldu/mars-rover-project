using MarsRover.Domain.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover.Domain.Abstract
{
    public interface IRepository
    {
        Position AddOrGet(Position position);
    }
}
