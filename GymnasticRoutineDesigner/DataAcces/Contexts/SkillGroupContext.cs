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
    public class SkillGroupContext : DbContext, ISkillGroupContext
    {
        public DbSet<SkillGroupDTO> SkillGroup { get; set; }
        public DbSet<ElementDTO> Element { get; set; }
        public SkillGroupContext(DbContextOptions<SkillGroupContext> options) : base(options)
        {

        }

        //public IReadOnlyList<SkillGroupDTO> GetSkillGroupsFromApparatus(ApparatusDTO apparatus)
        //{
        //    List<SkillGroupDTO> allGroups = new List<SkillGroupDTO>();
        //    MySqlConnection con = _DB.GetConnection();
        //    {
        //        string query = @"SELECT sg.ID AS SkillGroupID, sg.[Name] AS SkillGroupName, Apparatus.* FROM SkillGroup AS sg
        //                        INNER JOIN Apparatus ON sg.ApparatusID = Apparatus.ID
        //                        WHERE ApparatusID = @ID";
        //        using (MySqlCommand command = new MySqlCommand(query, con))
        //        {
        //            command.Parameters.AddWithValue("ID", apparatus.Id);

        //            try
        //            {
        //                MySqlDataAdapter adapter = new MySqlDataAdapter(command);
        //                DataTable dt = new DataTable();
        //                adapter.Fill(dt);

        //                foreach (DataRow dr in dt.Rows)
        //                {
        //                    SkillGroupDTO skillGroup = fillSkillGroup(dr);
        //                    allGroups.Add(skillGroup);
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                Console.WriteLine(ex.Message);
        //            }
        //            return allGroups.AsReadOnly();
        //        }
        //    }
        //}

        //private SkillGroupDTO fillSkillGroup(DataRow dr)
        //{
        //    return new SkillGroupDTO(Convert.ToInt32(dr["SkillGroupID"]), new ApparatusDTO(Convert.ToInt32(dr["ID"]), dr["Name"].ToString(), dr["Abbreviation"].ToString()), dr["SkillGroupName"].ToString());
        //}
    }
}
