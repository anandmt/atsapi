using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using atsapi.Models;
using atsapi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace atsapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AtsController : ControllerBase
    {
        private readonly AtsService _atsService;
        public AtsController(AtsService atsService)
        {
            _atsService = atsService;
        }

        [HttpGet]
        public ActionResult<List<Users>> Get() =>
            _atsService.Get();


        [HttpGet("{id:length(24)}", Name = "GetUser")]
        public ActionResult<Users> Get(string id)
        {
            var book = _atsService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            return book;
        }

        [HttpPost]
        public ActionResult<Users> Create(Users user)
        {
            _atsService.Create(user);

            return CreatedAtRoute("GetUser", new { id = user.id.ToString() }, user);
        }

        [HttpPut("{id:length(24)}")]
        public IActionResult Update(string id, Users userIn)
        {
            var book = _atsService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _atsService.Update(id, userIn);

            return NoContent();
        }

        [HttpDelete("{id:length(24)}")]
        public IActionResult Delete(string id)
        {
            var book = _atsService.Get(id);

            if (book == null)
            {
                return NotFound();
            }

            _atsService.Remove(book.id);

            return NoContent();
        }

    }
}