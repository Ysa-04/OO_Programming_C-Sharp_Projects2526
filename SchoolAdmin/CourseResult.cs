using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolAdmin
{
    internal class CourseResult
    {
        private string name;
        public string Name
        {
            get
            {
                return this.name;
            }
        }
        private byte result;
        public byte Result
        {
            get
            {
                return result;
            }
            set
            {
                if (!(value > 20))
                {
                    result = value;
                }
            }
        }

        public CourseResult(string name, byte result)
        {
            this.name = name;
            this.Result = result;
        }
    }
}
