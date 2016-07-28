using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using BackendAPI.Repositories;
using System.Web.Http;
using FrontendAPI.Dto;
using BackendAPI.Entities;
using AutoMapper;

namespace FrontendAPI.Controllers
{

    //[Authorize]
    [RoutePrefix("api/persons")]
    public class PersonsController : ApiController
    {
        private readonly IPersonRepository _personRepo;

        public PersonsController(IPersonRepository personRepo)
        {
            _personRepo = personRepo;
        }

        // GET api/values
        [Route("")]
        public IEnumerable<PersonDto> Get()
        {

            string query = "";

            var response = _personRepo.GetAllPersons(query, 0, 0);

            List<PersonDto> returnList = new List<PersonDto>();

            foreach (var person in response)
            {
                var personToDto = Mapper.Map<PersonDto>(person);

                returnList.Add(personToDto);
            }

            return returnList;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
