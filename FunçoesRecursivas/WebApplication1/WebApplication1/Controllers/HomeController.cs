using System;
using System.Diagnostics;
using System.Runtime.Intrinsics.X86;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }

    [HttpGet]
    public string PrintNaturalFor( int n = 10)
    {
        string retorno = string.Empty; 

        int i = 1;
        while (i <= n )
        {
            retorno += $"{i} ";
            i++;
        }
        return retorno;

    }

    [HttpGet]
    public string PrintNaturalRecursion(int count = 10)
    {
        string retorno = string.Empty;

        retorno = NaturalNumbeRecursion(1, count);

        return retorno;
    }
    public string NaturalNumbeRecursion(int n, int count)
    {
        string ret = string.Empty;
        // caso base: se o contador for menor que 1,
        if (count < 1)       
            return $" {n} ";

            ret += $" {n} ";
            count--; //decrementar count

            ret += NaturalNumbeRecursion(n + 1, count); //chamada recursiva: Incrementar n e decrementar count
                                                    //para imprimir o numero

        return ret;
        
        
    }


    // Imprimir um numero de N até 1 (recursivo)

    [HttpGet]
    public string PrintDecrescenteRecursivo(int n = 10)
    {
        return DecrescenteRecursivo(n);
    }

    private string DecrescenteRecursivo(int n)
    {
        if (n < 1)
            return "";
        return $"{n} " + DecrescenteRecursivo(n - 1);
    }


    // 2. Somar os números de 1 até N
    [HttpGet]
    public int SomarNumerosAteN(int n = 10)
    {
        return SomaRecursiva(n);
    }

    private int SomaRecursiva(int n)
    {
        if (n <= 1)
            return n;
        return n + SomaRecursiva(n - 1);
    }

    // 3. Contar quantos caracteres tem em uma string (recursivo)
    [HttpGet]
    public string ContarCaracteres(string texto = "pneumoultramicroscopicossilicovulcanoconiótico")
    {
        int tamanho = texto.Length;
        int retorno = SumString(0, tamanho);

        return $"A String \"{texto}\" possui {retorno} caracteres nesse caraio.";
    }

    public int SumString(int n, int tamanho)
    {
        if (tamanho <= 0)
            return 0;

        return 1 + SumString(n + 1, tamanho - 1);
    }

    // 4. Verificar se uma palavra é palíndromo (recursivo)
    [HttpGet]
    public string EhPalindromo(string palavra = "arara")
    {
        return VerificaPalindromo(palavra.ToLower());       
    }

    private string VerificaPalindromo(string palavra)
    {
        if (palavra.Length <= 1)
            return " É PALINDROMOOO ESSA CARAIAAAA ";
        if (palavra[0] != palavra[^1])
            return " Não é Palidromo essa porra bixu deu o carai";
        return VerificaPalindromo(palavra.Substring(1, palavra.Length - 2));
    }

}
