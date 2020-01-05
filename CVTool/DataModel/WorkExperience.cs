using System;
using System.Collections.Generic;
using VitaeGeneralis.Interfaces.DataModel;

namespace VitaeGeneralis.DataModel
{
    [Serializable]
    class WorkExperience : IWorkExperience
    {
        public string CompanyName { get; set; }
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public IEnumerable<ISkill> Skills { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public IEnumerable<IWorkExperience> SubContracts { get; set; }
    }
}
