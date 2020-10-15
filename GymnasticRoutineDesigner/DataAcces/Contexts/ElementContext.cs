using DataAcces.DTOs;
using DataAcces.Interfaces;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAcces.Contexts
{
    public class ElementContext : DbContext, IElementContext
    {
        public DbSet<ElementDTO> Element { get; set; }
        public ElementContext(DbContextOptions<ElementContext> options):base(options)
        {

        }

        //public IReadOnlyList<ElementDTO> GetAllElementsFromSkillGroup(SkillGroupDTO skillGroup)
        //{
        //    List<ElementDTO> allElements = new List<ElementDTO>();
        //    MySqlConnection con = _DB.GetConnection();
        //    {
        //        string query = "SELECT e.*, sg.[Name] AS SkillGroupName FROM Element AS e, SkillGroup AS sg WHERE SkillGroupID = @SkillGroupID";
        //        using (MySqlCommand command = new MySqlCommand(query, con))
        //        {
        //            command.Parameters.AddWithValue("SkillGroupID", skillGroup.Id);

        //            try
        //            {
        //                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                foreach (DataRow dr in dt.Rows)
        //                {
        //                    ElementDTO element = fillElement(dr);
        //                    allElements.Add(element);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            return allElements.AsReadOnly();
        //        }
        //    }
        //    return null;
        //}

        //private ElementDTO fillElement(DataRow dr)
        //{
        //    return new ElementDTO(Convert.ToInt32(dr["ID"]), new SkillGroupDTO(Convert.ToInt32(dr["SkillGroupID"]), new ApparatusDTO(), dr["SkillGroupName"].ToString()), Convert.ToInt32(dr["Priority"]), dr["Name"].ToString(), dr["Difficulty"].ToString(), Convert.ToDecimal(dr["Worth"]));
        //}
    }
}
