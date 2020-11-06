using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace DataAcces.Contexts
{
    public class ElementContext : BaseContext, IElementContext
    {
        public ElementContext()
        {

        }

        public ElementDTO Create(ElementDTO El)
        {
            Element.Add(El);
            SaveChanges();
            return El;
        }
        public ElementDTO GetById(int Id)
        {
            return Element.ToList().Find(el => el.Id == Id);
        }
    }
}
