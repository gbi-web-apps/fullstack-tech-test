using System;
using System.Collections.Generic;

namespace react.Data
{
    public partial class Skills
    {
        public Skills()
        {
            PersonSkills = new HashSet<PersonSkills>();
        }

        public int SkillId { get; set; }
        public string Name { get; set; }
        public bool IsEnabled { get; set; }

        public virtual ICollection<PersonSkills> PersonSkills { get; set; }
    }
}
