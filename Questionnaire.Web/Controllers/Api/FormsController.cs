using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using Questionnaire.DataAccess.FakeImplementation;
using Questionnaire.DataAccess.Interfaces;
using Questionnaire.Entities;

namespace Questionnaire.Web.Controllers
{
    public class FormsController : ApiController
    {
        private readonly IFormsRepository _formsRepository = new FormsRepositoryFake();

        // GET: api/values
        [HttpGet]
        public IEnumerable<Form> Get()
        {
            return _formsRepository.Get();
        }

        // GET api/values/5
        [HttpGet]
        public Form Get(int id)
        {
            return _formsRepository.GetById(id);
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete]
        public void Delete(int id)
        {
        }
    }
}
