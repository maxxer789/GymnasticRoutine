using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAcces.Interfaces
{
    public interface IElementContext
    {
        ElementDTO Create(ElementDTO El);
        ElementDTO GetById(int Id);
    }
}
