using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;

namespace RoseBloom.Common.TCL
{
    /// <summary>
    /// a location in the system it could be a location where you thought about the thought or a location that you are thinking about
    /// </summary>
    public class Location
    {
        public string Name { get; set; }
        public LocationAddress Address { get; set; }
    }

    /// <summary>
    /// not sure why we would need this but better put it
    /// </summary>
    public class LocationAddress
    {
        public string StreetNumber { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public string Postalcode { get; set; }
    }
}
