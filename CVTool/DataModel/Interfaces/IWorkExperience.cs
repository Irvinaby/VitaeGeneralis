using System;
using System.Collections.Generic;

namespace VitaeGeneralis.Interfaces.DataModel
{
    public interface IWorkExperience
    {
        string CompanyName { get; set; }

        string ProjectName { get; set; }

        DateTime StartDate { get; set; }

        DateTime? EndDate { get; set; }

        IEnumerable<ISkill> Skills { get; set; }

        string ShortDescription { get; set; }

        string LongDescription { get; set; }
    }
}
