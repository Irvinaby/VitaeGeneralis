using System;
using System.Collections.Generic;
using VitaeGeneralis.Interfaces.DataModel;

namespace VitaeGeneralis.DataModel
{
    class Profile : IProfile
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public IContactInfo ContactInformation { get; set; }
        public IEnumerable<IWorkExperience> WorkExperience { get; set; }
    }
}
