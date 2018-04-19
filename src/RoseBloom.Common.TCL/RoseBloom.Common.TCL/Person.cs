using System;
using System.Collections.Generic;
using System.Text;

namespace RoseBloom.Common.TCL
{
    /// <summary>
    /// Represents a person in the system
    /// </summary>
    public class Person : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public RelationshipType RelatedType { get; set; }
    }

    
}
