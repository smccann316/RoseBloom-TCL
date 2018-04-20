using System;
using System.Collections.Generic;
using System.Text;

// ReSharper disable once CheckNamespace
namespace RoseBloom.Common.TCL.Entities
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
