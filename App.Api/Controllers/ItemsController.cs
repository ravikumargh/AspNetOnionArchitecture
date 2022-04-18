using App.Domain.Interfaces.BusinessInterface;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace App.Api.Controllers
{
    [Route("/api/public/v{version:apiVersion}/items")]
    [ApiVersion("1.0")]
    public class ItemsController : BaseApiController
    {
        IItemService itemService;
        public ItemsController(IItemService itemService)
        {
            this.itemService = itemService;
        }

        // GET: api/<ActivitiesController>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            return Ok(await itemService.GetAll());
        }

        // GET api/<ActivitiesController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ActivitiesController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ActivitiesController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ActivitiesController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
