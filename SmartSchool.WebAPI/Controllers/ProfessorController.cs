using Microsoft.AspNetCore.Mvc;

namespace SmartScholl.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProfessorController : ControllerBase
	{

		[HttpGet]
		public IActionResult Get()
		{
			return Ok();
		}


	}
}