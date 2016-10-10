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

        //Properties needs adding

        public override string ToString()
        {
            return "tech";
        }
    }

    public class CommonKnowledge : Experience
    {
        public CommonKnowledge()
        {
        }

        //Properties needs adding

        public override string ToString()
        {
            return "common";
        }
    }
}