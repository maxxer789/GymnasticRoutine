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
            return new Element(el.Id, el.Priority, el.Name, el.Difficulty, el.Worth);
        }
        public static List<Element> ElementDTOToModel(List<ElementDTO> el)
        {
            List<Element> elements = new List<Element>();

            foreach (ElementDTO e in el)
            {
                elements.Add(new Element(e.Id, e.Priority, e.Name, e.Difficulty, e.Worth));
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

        public static List<RoutineElementDTO> ModelToRoutineElementDTO(List<RoutineElement> re)
        {
            List<RoutineElementDTO> elements = new List<RoutineElementDTO>();

            foreach (RoutineElement e in re)
            {
                elements.Add(new RoutineElementDTO(e.Id, e.RoutineId, e.ElementId));
            }

            return elements;
        }
        public static ElementDTO RoutineElementDTOToElementDTO(RoutineElementDTO re)
        {
            return new ElementDTO(re.Element.Id, re.Element.Priority, re.Element.Name, re.Element.Difficulty, re.Element.Worth);
        }
        public static List<ElementDTO> RoutineElementDTOToElementDTO(List<RoutineElementDTO> res)
        {
            List<ElementDTO> redtos = new List<ElementDTO>();
            foreach (RoutineElementDTO re in res)
            {
                redtos.Add(new ElementDTO(re.Element.Id, re.Element.Priority, re.Element.Name, re.Element.Difficulty, re.Element.Worth));
            }
            return redtos;
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

        public static RoutineElementDTO RoutineWithElmentToRoutineElmentDTO(int routineId, int elementId)
        {
            return new RoutineElementDTO(routineId, elementId);
        }

        #endregion
        #region Routine

        public static Routine RoutineDTOToModel(RoutineDTO r)
        {
            return new Routine(r.Id, r.Name, r.Worth, ApparatusDTOToModel(r.Apparatus), SkillLevelDTOToModel(r.SkillLevel), ElementDTOToModel(RoutineElementDTOToElementDTO(r.Elements.ToList())));
        }

        public static RoutineDTO ModelToRoutineDTO(Routine r)
        {
            List<RoutineElementDTO> res = new List<RoutineElementDTO>();
            if (r.Elements.Count > 0)
            {
                foreach (Element e in r.Elements)
                {
                    res.Add(RoutineWithElmentToRoutineElmentDTO(r.Id, e.Id));
                }
            }
            return new RoutineDTO(r.Id, r.SkillLevel.Id, r.Name, r.Apparatus.Id, r.SkillLevel.Id, res);
        }

        #endregion
        #region SkillLevel

        public static SkillLevel SkillLevelDTOToModel(SkillLevelDTO sl)
        {
            return new SkillLevel(sl.Id, sl.Level, sl.Division, sl.AgeGroup);
        }
        public static SkillLevelDTO ModelToSkillLevelDTO(SkillLevel sl)
        {
            return new SkillLevelDTO(sl.Id, sl.Level, sl.Division, sl.AgeGroup);
        }

        #endregion
        #region RoutineElement

        public static RoutineElement RoutineElementDTOToModel(RoutineElementDTO Re)
        {
            return new RoutineElement(Re.RoutineId, Re.ElementId);
        }
        public static RoutineElementDTO ModelToRoutineElementDTO(RoutineElement Re)
        {
            return new RoutineElementDTO(Re.RoutineId, Re.ElementId);
        }

        #endregion
    }
}
