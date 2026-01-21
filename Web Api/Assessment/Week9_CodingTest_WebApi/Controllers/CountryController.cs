using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Week9_CodingTest_WebApi.Models;

namespace Week9_CodingTest_WebApi.Controllers
{
    public class CountryController : ApiController
    {
        static List<Country> countries = new List<Country>()
       {
           new Country{ ID=1, CountryName="India", Capital="Delhi"},
           new Country{ ID=2, CountryName="Australia", Capital="Canberra"},
           new Country{ ID=3, CountryName="Brazil", Capital="Brasilia"}
       };

        public HttpResponseMessage Get()
        {
            return Request.CreateResponse(HttpStatusCode.OK, countries);
        }

        public HttpResponseMessage Get(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, "Country not found");
            return Request.CreateResponse(HttpStatusCode.OK, country);
        }


        public HttpResponseMessage Post(Country country)
        {
            countries.Add(country);
            return Request.CreateResponse(
                HttpStatusCode.Created,
                country   
            );
        }


        public IHttpActionResult Put(int id, Country country)
        {
            var existing = countries.FirstOrDefault(c => c.ID == id);
            if (existing == null)
                return NotFound();
            existing.CountryName = country.CountryName;
            existing.Capital = country.Capital;
            return Ok("Country Updated");
        }
        
        public IHttpActionResult Delete(int id)
        {
            var country = countries.FirstOrDefault(c => c.ID == id);
            if (country == null)
                return NotFound();
            countries.Remove(country);
            return Ok(country);
        }
    }
}
