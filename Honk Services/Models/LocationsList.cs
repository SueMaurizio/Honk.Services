namespace HonkServices.Models
{
    using System.Collections.Generic;
    using System.Runtime.Serialization;

    /// <summary>
    /// A wrapper around a collection of locations.
    /// </summary>
    /// <remarks>
    /// A wrapper is required by the JSON serializer on the Android side.
    /// </remarks>
    [DataContract]
    public class LocationsList
    {
        [DataMember(Name ="locations")]
        public List<Location> Locations { get; set; }
    }
}