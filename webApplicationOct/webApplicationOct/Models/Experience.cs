using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webApplicationOct.Models
{
    public class Education
    {
        public Education()
        {
        }

        public string Period { get; set; }
        public string School { get; set; }
        public string Course { get; set; }

        public string getEducation()
        {
            return string.Format("Studied {0} at {1} during {2}", Course, School, Period);
        }
    }

    public class TechicalKnowledge
    {
        public TechicalKnowledge()
        {
        }
    }

    public class CommonKnowledge
    {
        public CommonKnowledge()
        {
        }
    }
}