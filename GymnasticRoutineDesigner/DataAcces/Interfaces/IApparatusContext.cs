using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IApparatusContext
    {
        IReadOnlyList<ApparatusDTO> GetAllApparatus();
    }
}
