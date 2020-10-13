using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BusinessLogic.Models
{
    public class Apparatus
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName ="nvarchar(10)")]
        public string Name { get; set; }
        [Column(TypeName = "nvarchar(2)")]
        public string Abbreviation { get; set; }

        public Apparatus()
        {

        }
        public Apparatus(ApparatusDTO dto)
        {
            Id = dto.Id;
            Name = dto.Name;
            Abbreviation = dto.Abbreviation;
        }
    }
}
