using HeinHtetNaing_ADI.Common.Attributes;
using HeinHtetNaing_ADI.Common.Utils;

namespace HeinHtetNaing_ADI.Models
{
    public class Skill
    {
        [SqlColumnName("skill_id")] // Specify column name for skill_id
        public long SkillId { get; set; }

        [SqlColumnName("freelancer_id")] // Specify column name for freelancer_id
        public long? FreelancerId { get; set; }

        [SqlColumnName("skill_name")] // Specify column name for skill_name
        [SqlType("VARCHAR(100)")]      // Use VARCHAR(100) for skill_name (suitable for descriptive names)
        public string? SkillName { get; set; }

        [SqlColumnName("skill_level")]
        [SqlType("VARCHAR(50)")]
        public string? SkillLevel { get; set; }

        public Skill() { }

        public Skill(long freelancerId, string skillName, string skillLevel)
        {
            SkillId = GuidUtil.GenerateNewLongGuid();
            FreelancerId = freelancerId;
            SkillName = skillName;
            SkillLevel = skillLevel;
        }
    }

}
