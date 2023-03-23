using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SmartScholl.WebAPI.Models;
using SmartSchool.WebAPI.Data;

namespace SmartScholl.WebAPI.Controllers
{
	[ApiController]
	[Route("api/[controller]")]
	public class AlunoController : ControllerBase
	{
		private readonly SmartContext _context;
		public AlunoController(SmartContext context)
		{
			_context = context;
		}

		[HttpGet]
		public IActionResult Get()
		{
			return Ok(_context.Alunos);
		}

		[HttpGet("{id}")]
		public IActionResult GetById(int id)
		{
			var aluno = _context.Alunos?.FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			return Ok(aluno);
		}

		[HttpPost]
		public IActionResult Post(Aluno aluno)
		{
			_context.Add(aluno);
			_context.SaveChanges();
			return Ok(aluno);
		}

		[HttpPut("{id}")]
		public IActionResult Put(int id, Aluno aluno)
		{
			var alu = _context.Alunos?.AsNoTracking().FirstOrDefault(a => a.Id == id);

			if (alu == null) return BadRequest("Aluno não encontrado.");

			_context.Update<Aluno>(aluno);
			_context.SaveChanges();
			return Ok(aluno);
		}

		[HttpPatch("{id}")]
		public IActionResult Patch(int id)
		{
			var aluno = _context.Alunos?.AsNoTracking().FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			_context.Update<Aluno>(aluno);
			_context.SaveChanges();
			return Ok(aluno);
		}

		[HttpDelete("{id}")]
		public IActionResult Delete(int id)
		{
			var aluno = _context.Alunos?.FirstOrDefault(a => a.Id == id);

			if (aluno == null) return BadRequest("Aluno não encontrado.");

			_context.Remove(aluno);
			_context.SaveChanges();
			return Ok(aluno);
		}
	}
}