using DataAcces.DTOs;
using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Contexts
{
    public class RoutineContext : IRoutineContext
    {
        public RoutineDTO Create()
        {
            return new RoutineDTO();
        }
    }
}
