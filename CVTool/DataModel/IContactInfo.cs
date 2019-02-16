using System.Collections.Generic;

namespace VitaeGeneralis.DataModel
{
    public interface IContactInfo
    {
        string PhoneNumber { get; set; }
        string Email { get; set; }
        IDictionary<string, string> AdditionalInformation { get; set; }
    }
}
