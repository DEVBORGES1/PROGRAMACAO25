using Microsoft.AspNetCore.Mvc;

namespace AULA03.Controllers
{
    // teste
    public class JogoVelhaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(
            string A00, string A01, string A02,
            string A10, string A11, string A12,
            string A20, string A21, string A22
        )
        {
            string[,] tabuleiro = {
                { A00, A01, A02 },
                { A10, A11, A12 },
                { A20, A21, A22 }
            };

            string vencedor = VerificarVencedor(tabuleiro);
            ViewBag.Vencedor = vencedor;

            return View();
        }

        private string VerificarVencedor(string[,] tabuleiro)
        {
            // Verifica linhas e colunas
            for (int i = 0; i < 3; i++)
            {
                if (!string.IsNullOrEmpty(tabuleiro[i, 0]) && tabuleiro[i, 0] == tabuleiro[i, 1] && tabuleiro[i, 1] == tabuleiro[i, 2])
                    return $"O vencedor é {tabuleiro[i, 0]}";

                if (!string.IsNullOrEmpty(tabuleiro[0, i]) && tabuleiro[0, i] == tabuleiro[1, i] && tabuleiro[1, i] == tabuleiro[2, i])
                    return $"O vencedor é {tabuleiro[0, i]}";
            }

            // Verifica diagonais
            if (!string.IsNullOrEmpty(tabuleiro[0, 0]) && tabuleiro[0, 0] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 2])
                return $"O vencedor é {tabuleiro[0, 0]}";

            if (!string.IsNullOrEmpty(tabuleiro[0, 2]) && tabuleiro[0, 2] == tabuleiro[1, 1] && tabuleiro[1, 1] == tabuleiro[2, 0])
                return $"O vencedor é {tabuleiro[0, 2]}";

            return "Nenhum vencedor ainda";
        }
    }
}
