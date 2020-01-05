using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using VitaeGeneralis.Interfaces.DataModel;

namespace VitaeGeneralis.DataModel
{
    [XmlRoot("Profile", IsNullable = false)]
    class Profile : IProfile
    {
        [XmlAttribute]
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IContactInfo ContactInformation { get; set; }
        public IEnumerable<IWorkExperience> WorkExperience { get; set; }
    }
}
