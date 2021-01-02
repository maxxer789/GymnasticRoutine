using DataAcces.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLogic.Repositories
{
    public class RoutineRepository
    {
        private readonly IRoutineContext _Context;
        public RoutineRepository(IRoutineContext context)
        {
            _Context = context;
        }
    }
}
