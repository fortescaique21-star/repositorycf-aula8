using Microsoft.AspNetCore.Mvc;

namespace ExercicioAula08.Controllers
{
    public class AlunoController : Controller
    {
        // Método Index - Passo 3
        public IActionResult Index()
        {
            // Definindo os dados do aluno na ViewBag
            ViewBag.Nome = "Seu Nome Completo";
            ViewBag.Curso = "Análise e Desenvolvimento de Sistemas";
            ViewBag.Semestre = "1º Semestre";

            return View();
        }

        // Método Detalhes - Passo 6
        public IActionResult Detalhes(int id)
        {
            // Passando o ID recebido para a View exibir
            ViewBag.IdAluno = id;
            
            return View();
        }
    }
}