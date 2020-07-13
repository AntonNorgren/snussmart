using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.EntityFrameworkCore;
using SnusSmartAPI.DAL;
using SnusSmartAPI.Models;
using SnusSmartAPI.Services;

namespace SnusSmartAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SnuffController : ControllerBase
    {
        private readonly ISnuffRepository _snuffRepository;
        public SnuffController(ISnuffRepository snuffRepository)
        {
            _snuffRepository = snuffRepository;
        }

        [HttpGet (Name = "GetAllSnuff")]
        public virtual async Task<ActionResult<IList<Snuff>>> GetAllSnuff()
        {
            try
            {
                var result = await _snuffRepository.GetAllSnuff();
                if (result.Count == 0) return NotFound(result);
                {
                    return Ok(result);
                }
            }
            catch (Exception e)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, $"Databasen bråkar: {e.Message}");
            }
        }
    }
}
