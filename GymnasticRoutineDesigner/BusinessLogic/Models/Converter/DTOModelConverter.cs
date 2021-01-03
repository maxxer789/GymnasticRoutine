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
        public static SkillGroup SkillGroupDTOToModelMinElements(SkillGroupDTO sg)
        {
            return new SkillGroup(sg.Id, sg.Name);
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
        public static SkillGroupDTO ModelToSkillGroupDTOMinElements(SkillGroup sg)
        {
            return new SkillGroupDTO(sg.Id, sg.Name);
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
            return new Element(el.Id, el.Priority, SkillGroupDTOToModelMinElements(el.SkillGroup), el.Name, el.Difficulty, el.Worth);
        }
        public static List<Element> ElementDTOToModel(List<ElementDTO> el)
        {
            List<Element> elements = new List<Element>();

            foreach (ElementDTO e in el)
            {
                elements.Add(new Element(e.Id, e.Priority, SkillGroupDTOToModelMinElements(e.SkillGroup), e.Name, e.Difficulty, e.Worth));
            }

            return elements;
        }

        public static ElementDTO ModelToElementDTO(Element el)
        {
            return new ElementDTO(el.Id, el.Priority, el.SkillGroup.Id, el.Name, el.Difficulty, el.Worth);
        }
        public static List<ElementDTO> ModelToElementDTO(List<Element> el)
        {
            List<ElementDTO> elements = new List<ElementDTO>();

            foreach (Element e in el)
            {
                elements.Add(new ElementDTO(e.Id, e.Priority, e.SkillGroup.Id, e.Name, e.Difficulty, e.Worth));
            }

            return elements;
        }

        public static List<RoutineElementDTO> ModelToRoutineElementDTO(List<RoutineElement> re)
        {
            List<RoutineElementDTO> elements = new List<RoutineElementDTO>();

            foreach (RoutineElement e in re)
            {
                elements.Add(new RoutineElementDTO(e.Id, e.RoutineId, e.ElementId));
            }

            return elements;
        }

        public static List<RoutineElement> RoutineElementDTOToModel(List<RoutineElementDTO> re)
        {
            List<RoutineElement> elements = new List<RoutineElement>();

            foreach (RoutineElementDTO e in re)
            {
                elements.Add(new RoutineElement(e.Id, e.RoutineId, e.ElementId));
            }

            return elements;
        }

        #endregion
        #region Routine

        public static Routine RoutineDTOToModel(RoutineDTO r)
        {
            return new Routine(r.Id, r.Name, r.Worth, ApparatusDTOToModel(r.Apparatus), SkillGroupDTOToModel(r.SkillLevel), RoutineElementDTOToModel(r.Elements.ToList()));
        }

        public static RoutineDTO ModelToRoutineDTO(Routine r)
        {
            return new RoutineDTO(r.Id, r.SkillLevel.Id, r.Name, r.Apparatus.Id, r.SkillLevel.Id, ModelToRoutineElementDTO(r.Elements.ToList()));
        }

        #endregion
        #region SkillLevel

        public static SkillLevel SkillGroupDTOToModel(SkillLevelDTO sl)
        {
            return new SkillLevel(sl.Id, sl.Level, sl.Division, sl.AgeGroup);
        }

        #endregion
    }
}
