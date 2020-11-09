using System;
using System.Text.Json;
using System.Threading.Tasks;
using Assignment.Data;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("/FamilyError")]
    public class FamilyErrorController : ControllerBase
    {
        private IFamilyService familyService;

        public FamilyErrorController()
        {
            familyService = new FamilyService();
        }
        
        [HttpGet]
        public async Task<ActionResult<string>> GetError()
        {
            try
            {
                string error = familyService.getFamilyError();
                return Ok(error);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}