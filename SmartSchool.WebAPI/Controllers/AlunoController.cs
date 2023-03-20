using Microsoft.AspNetCore.Mvc;
using SmartScholl.WebAPI.Models;

namespace SmartScholl.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AlunoController : ControllerBase
	{
		public List<Aluno> Alunos = new List<Aluno>() {
			new Aluno() {
				Id = 1,
				Nome = "Fabio",
				SobreNome = "Lima",
				Telefone = "123456789"
			},
			new Aluno() {
				Id = 2,
				Nome = "Bia",
				SobreNome = "Preza",
				Telefone = "123456789"
			},
			new Aluno() {
				Id = 3,
				SobreNome = "Preza Lima",
				Nome = "Kyra",
				Telefone = "123456789"
			}
		};
		[HttpGet]
		public IActionResult Get()
		{
			return Ok(Alunos);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var aluno = Alunos.FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			return Ok(aluno);
		}

		[HttpPost]
		public IActionResult Post(Aluno aluno)
		{
			return Ok(aluno);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, Aluno aluno)
		{
			return Ok(aluno);
		}

		[HttpPatch("{id}")]
		public IActionResult Patch(int id)
		{
			var aluno = Alunos.FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			return Ok(aluno);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var aluno = Alunos.FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			return Ok(aluno);
		}
	}
}