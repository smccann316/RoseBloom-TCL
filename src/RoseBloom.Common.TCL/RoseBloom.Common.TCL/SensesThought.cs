using System;
using System.Collections.Generic;
using System.Text;

namespace RoseBloom.Common.TCL
{
    public class SensesThought : Thought
    {
        public Action ThoughtAction { get; set; }
        public List<Person> ThoughtWith { get; set; }
        

    }
}
