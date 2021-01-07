using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IRoutineContext
    {
        RoutineDTO Create(RoutineDTO rout);
        RoutineDTO GetById(int Id);
    }
}
