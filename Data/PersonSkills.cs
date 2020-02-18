using System;
using System.Collections.Generic;

namespace react.Data
{
    public partial class PersonSkills
    {
        public int PersonId { get; set; }
        public int SkillId { get; set; }

        public virtual People Person { get; set; }
        public virtual Skills Skill { get; set; }
    }
}
