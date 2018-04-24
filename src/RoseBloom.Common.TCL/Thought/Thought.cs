using System;
using System.Collections.Generic;
using System.Text;

// ReSharper disable once CheckNamespace
namespace RoseBloom.Common.TCL.Entities
{
    /// <summary>
    /// The central part of the system; a individual thought
    /// </summary>
    public class Thought : Entity
    {
        public string Description { get; set; }
        public EmotionImpact Impact { get; set; }
        public string Notes { get; set; }
    }
}
