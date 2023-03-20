using Microsoft.AspNetCore.Mvc;
using SmartScholl.WebAPI.Models;

namespace SmartScholl.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class ProfessorController : ControllerBase
	{
		public List<Professor> Professores = new List<Professor>() {
			new Professor() {
				Id = 1,
				Nome = "Fabio"
			},
			new Professor() {
				Id = 2,
				Nome = "Bia"
			},
			new Professor() {
				Id = 3,
				Nome = "Kyra"
			}
		};

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(Professores);
		}


	}
}