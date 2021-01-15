using BusinessLogic.Models;
using DataAcces.Interfaces;
using BusinessLogic.Models.Converter;
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

        public Routine Create(Routine rout)
        {
            if (rout.Name != null && rout.Name.Length >= 5)
            {
                return DTOModelConverter.RoutineDTOToModel(_Context.Create(DTOModelConverter.ModelToRoutineDTO(rout)));
            }
            else return new Routine();
        }

        public Routine GetById(int Id)
        {
            try
            {
                return DTOModelConverter.RoutineDTOToModel(_Context.GetById(Id));
            }
            catch
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public Routine AddElement(RoutineElement Re)
        {
            return DTOModelConverter.RoutineDTOToModel(_Context.AddElement(DTOModelConverter.ModelToRoutineElementDTO(Re)));
        }
    }
}
