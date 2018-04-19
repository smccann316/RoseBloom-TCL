using System;
using System.Collections.Generic;
using System.Text;

namespace RoseBloom.Common.TCL
{
    /// <summary>
    /// a entity that is used for look up 
    /// for staic data such as location, action, emotion
    /// </summary>
    public class LookupEntity : Entity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string Notes { get; set; }
    }
}
