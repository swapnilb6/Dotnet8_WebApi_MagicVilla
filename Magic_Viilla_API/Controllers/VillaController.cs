using Magic_Viilla_API.Data;
using Magic_Viilla_API.Models;
using Magic_Viilla_API.Models.DTO;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Magic_Viilla_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        [ProducesResponseType(200)]
        public ActionResult<IEnumerable<VillaDto>> GetVillas()
        {
            return Ok(VillaStore.Villalist);
        }

        [HttpGet("id")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(404)]
        public ActionResult<VillaDto> GetVilla(int id)
        {
            if (id <= 0)
            {
                return BadRequest();
            }
            var villa = VillaStore.Villalist.FirstOrDefault(i => i.Id == id);
            if (villa == null)
            {
                return NotFound();
            }

            return Ok(villa);
        }

    }
}
