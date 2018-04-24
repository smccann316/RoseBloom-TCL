using System;
using System.Collections.Generic;

// ReSharper disable once CheckNamespace
namespace RoseBloom.Common.TCL.Entities
{
    public class ThoughtDetail
    {
        public Action ThoughtAction { get; set; }
        public List<Person> ThoughtWith { get; set; }
    }
}
