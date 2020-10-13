using DataAcces.DTOs;
using DataAcces.Interfaces;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAcces.Contexts
{
    public class SkillGroupContext : Database, ISkillGroupContext
    {
        private readonly IDatabase _DB;
        public SkillGroupContext(string Connectionstring) : base(Connectionstring)
        {

        }
        public IReadOnlyList<SkillGroupDTO> GetSkillGroupsFromApparatus(ApparatusDTO apparatus)
        {
            List<SkillGroupDTO> allGroups = new List<SkillGroupDTO>();
            MySqlConnection con = _DB.GetConnection();
            {
                string query = @"SELECT sg.ID AS SkillGroupID, sg.[Name] AS SkillGroupName, Apparatus.* FROM SkillGroup AS sg
                                INNER JOIN Apparatus ON sg.ApparatusID = Apparatus.ID
                                WHERE ApparatusID = @ID";
                using (MySqlCommand command = new MySqlCommand(query, con))
                {
                    command.Parameters.AddWithValue("ID", apparatus.Id);

                    try
                    {
                        MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        foreach (DataRow dr in dt.Rows)
                        {
                            SkillGroupDTO skillGroup = fillSkillGroup(dr);
                            allGroups.Add(skillGroup);
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    return allGroups.AsReadOnly();
                }
            }
        }

        private SkillGroupDTO fillSkillGroup(DataRow dr)
        {
            return new SkillGroupDTO(Convert.ToInt32(dr["SkillGroupID"]), new ApparatusDTO(Convert.ToInt32(dr["ID"]), dr["Name"].ToString(), dr["Abbreviation"].ToString()),dr["SkillGroupName"].ToString());
        }
    }
}
