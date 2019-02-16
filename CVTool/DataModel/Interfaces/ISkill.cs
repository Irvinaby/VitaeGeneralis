namespace VitaeGeneralis.Interfaces.DataModel
{
    public interface ISkill
    {
        SkillType SkillType { get; set; }

        string SkillName { get; set; }

        string AdditionalInformation { get; set; }
    }

    public enum SkillType
    {
        ProgrammingLanguage,
        Methodology,
        Tooling,
        SourceControl,
        SoftSkill,
        Language
    }
}