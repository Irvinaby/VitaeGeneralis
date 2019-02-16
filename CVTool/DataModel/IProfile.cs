using System;
using System.Xml;
using System.Xml.Serialization;

namespace VitaeGeneralis.DataModel
{
    [XmlRoot("CV", IsNullable = false)]
    public interface IProfile
    {
        [XmlElement]
        string Name { get; set; }
        
        DateTime DateOfBirth { get; set; }

        IContactInfo ContactInformation { get; set; }
    }
}
