namespace HonkServices.Controllers
{
    using System.Collections.Generic;
    using System.Web.Http;
    using HonkServices.Models;

    public class LocationController : ApiController
    {
        // GET api/<controller>
        public LocationsList Get([FromUri]double northEastBoundary, [FromUri]double southWestBoundary)
        {
            return new LocationsList()
            {
                Locations = new List<Location>()
                {
                    new Location()
                    {
                        Latitude = 45.9711883,
                        Longitude = 12.1673287,
                        Name = "Tizio",
                        Description = "Gelati da Tizio"
                    },
                    new Location()
                    {
                        Latitude = 45.9723126,
                        Longitude = 12.1651468,
                        Name = "Paninaro onto",
                        Description = "Ti aspetto fuori dalla discoteca"
                    }
                }
            };
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}