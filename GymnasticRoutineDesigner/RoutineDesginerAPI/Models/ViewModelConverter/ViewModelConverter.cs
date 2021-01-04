using BusinessLogic.Models;
using GymnasticRoutineDesigner.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoutineDesginerAPI.Models.ViewModelConverter
{
    public class ViewModelConverter
    {
        #region Apparatus
        public static ApparatusViewModel ApparatusToViewModel(Apparatus app)
        {
            return new ApparatusViewModel(app.Id, app.Name, app.Abbreviation, SkillGroupToViewModel(app.SkillGroups.ToList()));
        }
        public static List<ApparatusViewModel> ApparatusToViewModel(List<Apparatus> apps)
        {
            List<ApparatusViewModel> vmapps = new List<ApparatusViewModel>();
            foreach (Apparatus app in apps)
            {
                vmapps.Add(new ApparatusViewModel(app.Id, app.Name, app.Abbreviation, SkillGroupToViewModel(app.SkillGroups.ToList())));
            }
            return vmapps;
        }

        public static Apparatus ApparatusViewModelToApparatus(ApparatusViewModel app)
        {
            return new Apparatus(app.Id, app.Name, app.Abbreviation, SkillGroupViewModelToSkillGroup(app.SkillGroups.ToList()));
        }
        public static List<Apparatus> ApparatusToViewModel(List<ApparatusViewModel> apps)
        {
            List<Apparatus> vmapps = new List<Apparatus>();
            foreach (ApparatusViewModel app in apps)
            {
                vmapps.Add(new Apparatus(app.Id, app.Name, app.Abbreviation, SkillGroupViewModelToSkillGroup(app.SkillGroups.ToList())));
            }
            return vmapps;
        }
        #endregion
        #region SkillGroup
        public static SkillGroupViewModel SkillGroupToViewModel(SkillGroup sg)
        {
            return new SkillGroupViewModel(sg.Id, sg.Name, ElementToViewModel(sg.Elements.ToList()));
        }
        public static List<SkillGroupViewModel> SkillGroupToViewModel(List<SkillGroup> sgs)
        {
            List<SkillGroupViewModel> skillGroups = new List<SkillGroupViewModel>();
            foreach (SkillGroup sg in sgs)
            {
                skillGroups.Add(new SkillGroupViewModel(sg.Id, sg.Name, ElementToViewModel(sg.Elements.ToList())));
            }
            return skillGroups;
        }

        public static SkillGroup SkillGroupViewModelToSkillGroup(SkillGroupViewModel sg)
        {
            return new SkillGroup(sg.Id, sg.Name, ElementViewModelToElement(sg.Elements.ToList()));
        }
        
        public static List<SkillGroup> SkillGroupViewModelToSkillGroup(List<SkillGroupViewModel> sgs)
        {
            List<SkillGroup> skillGroups = new List<SkillGroup>();
            foreach (SkillGroupViewModel sg in sgs)
            {
                skillGroups.Add(new SkillGroup(sg.Id, sg.Name, ElementViewModelToElement(sg.Elements.ToList())));
            }
            return skillGroups;
        }
        #endregion
        #region Element
        public static ElementViewModel ElementToViewModel(Element el)
        {
            return new ElementViewModel(el.Id, el.Priority, el.Name, el.Difficulty, el.Worth);
        }
        public static List<ElementViewModel> ElementToViewModel(List<Element> el)
        {
            List<ElementViewModel> elements = new List<ElementViewModel>();
            foreach (Element e in el)
            {
                elements.Add(new ElementViewModel(e.Id, e.Priority, e.Name, e.Difficulty, e.Worth));
            }
            return elements;
        }

        public static Element ElementViewModelToElement(ElementViewModel el)
        {
            return new Element(el.Id, el.Priority,  el.Name, el.Difficulty, el.Worth);
        }
        public static Element ElementViewModelToElement(ElementCreateViewModel el)
        {
            return new Element(el.Priority, el.Name, el.Difficulty, el.Worth);
        }

        public static List<Element> ElementViewModelToElement(List<ElementViewModel> el)
        {
            List<Element> elements = new List<Element>();
            foreach (ElementViewModel e in el)
            {
                elements.Add(new Element(e.Id, e.Priority, e.Name, e.Difficulty, e.Worth));
            }
            return elements;
        }
        #endregion
        #region Routine
        //public static RoutineViewModel RoutineToViewModel(Routine rout)
        //{
        //    return new ElementViewModel(el.Id, el.Priority, el.SkillGroupId, el.Name, el.Difficulty, el.Worth);
        //}

        public static Routine ViewModelToRoutine(RoutineCreateViewModel rcvm)
        {
            return new Routine(rcvm.Name, ApparatusViewModelToApparatus(rcvm.Apparatus), ViewModelToSkillLevel(rcvm.SkillLevel));
        }

        #endregion
        #region SkillLevel
        public static SkillLevel ViewModelToSkillLevel(SkillLevelViewModel slvm)
        {
            return new SkillLevel(slvm.Id, slvm.Level, slvm.Division, slvm.AgeGroup);
        }
        #endregion
    }
}
