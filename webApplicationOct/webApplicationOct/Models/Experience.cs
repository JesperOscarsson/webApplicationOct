using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApplicationOct.Models
{
    public class Experience
    {
        public Experience()
        {
        }
    }

    public class Education : Experience
    {
        public Education()
        {
        }

        public string Period { get; set; }
        public string School { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return string.Format("Studied {0} at {1} during {2}", Course, School, Period);
        }
    }

    public class TechnicalKnowledge : Experience
    {
        public TechnicalKnowledge()
        {
        }

        public string Skill { get; set; }
        public string Proficiency { get; set; }

        public override string ToString()
        {
            return string.Format("Skill: {0}    Proficiency: {1}", Skill, Proficiency);
        }
    }

    public class CommonKnowledge : Experience
    {
        public CommonKnowledge()
        {
        }

        public string CommonSkill { get; set; }
        public string CommonProficiency { get; set; }

        public override string ToString()
        {
            return string.Format("Skill: {0}    Proficiency: {1}", CommonSkill, CommonProficiency);
        }
    }
}