namespace HonkServices.Models
{
    using System.Runtime.Serialization;

    [DataContract]
    public class Location
    {
        [DataMember(Name="latitude")]
        public double Latitude { get; set; }

        [DataMember(Name="longitude")]
        public double Longitude { get; set; }

        [DataMember(Name="name")]
        public string Name { get; set; }

        [DataMember(Name="description")]
        public string Description { get; set; }
    }
}