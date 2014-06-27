using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Zouave.Api.Models;

namespace Zouave.Api.Controllers
{

    public class TestController : ApiController
    {

        List<TestModel> _data = new List<TestModel>();

        public TestController()
        {
            for (int loop = 0; loop < 10; loop++)
            {
                _data.Add(new TestModel { Id = loop, IsActive = (loop % 2) == 0, Name = loop.ToString(), Price = loop * 2.54M });
            }
        }

        // GET api/test
        public IEnumerable<TestModel> Get()
        {
            return _data;
        }

        // GET api/test/5
        public TestModel Get(int id)
        {
            return _data.Find(s => s.Id == id);
        }

        // POST api/test
        public void Post([FromBody]string value)
        {
        }

        // PUT api/test/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/test/5
        public void Delete(int id)
        {
        }
    }
}
