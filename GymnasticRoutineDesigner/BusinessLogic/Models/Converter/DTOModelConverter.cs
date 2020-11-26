using DataAcces.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BusinessLogic.Models.Converter
{
    public class DTOModelConverter
    {
        #region Apparatus
        public static Apparatus ApparatusDTOToModel(ApparatusDTO app)
        {
            return new Apparatus(app.Id, app.Name, app.Abbreviation, SkillGroupDTOToModel(app.SkillGroups.ToList()));
        }
        public static List<Apparatus> ApparatusDTOToModel(List<ApparatusDTO> apps)
        {
            List<Apparatus> vmapps = new List<Apparatus>();

            foreach (ApparatusDTO app in apps)
            {
                vmapps.Add(new Apparatus(app.Id, app.Name, app.Abbreviation, SkillGroupDTOToModel(app.SkillGroups.ToList())));
            }

            return vmapps;
        }

        public static ApparatusDTO ModelToApparatusDTO(Apparatus app)
        {
            return new ApparatusDTO(app.Id, app.Name, app.Abbreviation, ModelToSkillGroupDTO(app.SkillGroups.ToList()));
        }
        public static List<ApparatusDTO> ModelToApparatusDTO(List<Apparatus> apps)
        {
            List<ApparatusDTO> vmapps = new List<ApparatusDTO>();

            foreach (Apparatus app in apps)
            {
                vmapps.Add(new ApparatusDTO(app.Id, app.Name, app.Abbreviation, ModelToSkillGroupDTO(app.SkillGroups.ToList())));
            }

            return vmapps;
        }
        #endregion
        #region SkillGroup
        public static SkillGroup SkillGroupDTOToModel(SkillGroupDTO sg)
        {
            return new SkillGroup(sg.Id, sg.Name, ElementDTOToModel(sg.Elements.ToList()));
        }
        public static List<SkillGroup> SkillGroupDTOToModel(List<SkillGroupDTO> sgs)
        {
            List<SkillGroup> skillGroups = new List<SkillGroup>();
            foreach (SkillGroupDTO sg in sgs)
            {
                skillGroups.Add(new SkillGroup(sg.Id, sg.Name, ElementDTOToModel(sg.Elements.ToList())));
            }
            return skillGroups;
        }

        public static SkillGroupDTO ModelToSkillGroupDTO(SkillGroup sg)
        {
            return new SkillGroupDTO(sg.Id, sg.Name, ModelToElementDTO(sg.Elements.ToList()));
        }
        public static List<SkillGroupDTO> ModelToSkillGroupDTO(List<SkillGroup> sgs)
        {
            List<SkillGroupDTO> skillGroups = new List<SkillGroupDTO>();

            foreach (SkillGroup sg in sgs)
            {
                skillGroups.Add(new SkillGroupDTO(sg.Id, sg.Name, ModelToElementDTO(sg.Elements.ToList())));
            }

            return skillGroups;
        }
        #endregion
        #region Element
        public static Element ElementDTOToModel(ElementDTO el)
        {
            return new Element(el.Id, el.Priority, el.SkillGroupId, el.Name, el.Difficulty, el.Worth);
        }
        public static List<Element> ElementDTOToModel(List<ElementDTO> el)
        {
            List<Element> elements = new List<Element>();

            foreach (ElementDTO e in el)
            {
                elements.Add(new Element(e.Id, e.Priority, e.SkillGroupId, e.Name, e.Difficulty, e.Worth));
            }

            return elements;
        }

        public static ElementDTO ModelToElementDTO(Element el)
        {
            return new ElementDTO(el.Id, el.Priority, el.SkillGroupId, el.Name, el.Difficulty, el.Worth);
        }
        public static List<ElementDTO> ModelToElementDTO(List<Element> el)
        {
            List<ElementDTO> elements = new List<ElementDTO>();

            foreach (Element e in el)
            {
                elements.Add(new ElementDTO(e.Id, e.Priority, e.SkillGroupId, e.Name, e.Difficulty, e.Worth));
            }

            return elements;
        }
        #endregion
    }
}
