using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;

namespace VitaeGeneralis.Interfaces.DataModel
{
    [XmlRoot("CV", IsNullable = false)]
    public interface IProfile
    {
        [XmlElement]
        string Name { get; set; }
        
        DateTime DateOfBirth { get; set; }

        IContactInfo ContactInformation { get; set; }

        IEnumerable<IWorkExperience> WorkExperience { get; set; }
    }
}
