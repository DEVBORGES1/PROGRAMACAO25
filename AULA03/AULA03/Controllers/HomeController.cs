using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using AULA03.Models;
using System.Globalization;

namespace AULA03.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }


    [HttpGet]
    public String GetIf(int x)
    {

        /*
         Estrutura sintatica do IF
        if(EXPRESS�O BOOLEANA)
        {
            Senten�a de codigo a ser executada,
            caso a condi��o seja verdadeira
        }
          caso o if tenha apenas uma linha de comando 
        a ser executada na condicional, n�o ha necessidades
        do uso das chaves

        if (Exoress�o boleana)
        apenas um comando

         */
        string retorno = string.Empty;

        // int x = 10;
        if (x < 9)
            retorno = "X � maior que 9";

        // x = 8;
        if (x > 9)
            retorno = "X � Maior que 9";
        else
            retorno = "X � Menor que 9";

        // x = 11;
        if (x == 10)
        {
            retorno = "Ora ora ";
            retorno += "X � igual a 10";
        }
        else if (x == 9)
        {
            retorno = "Hmmmmmm ";
            retorno = "x � igual a 9";
        }
        else if (x == 8)
        {
            retorno = "Bahhhhh ";
            retorno = "x � igual a 8, tch�";
        }
        else retorno = "Sei l� que n�mero � x";

        return retorno;
     }

    [HttpGet]
    public string GetSwitch(int x)
    {
        string retorno = string.Empty;

        switch (x)
        {
            case 0:
                retorno = "x � zero";
                break; 
            case 1:
                retorno = "x � Um";
                break;
            case 2:
                retorno = "x � dois";
                break;
            case 3:
                retorno = "x � tr�s";
                break;
            case 4:
                retorno = "x � quando eu morrer eu quero ser enterrada de 4...";
                break;

            default:
                retorno = "x � algum numero n�o previsto";
                break;


        }
        return retorno;
    }

    [HttpGet]
    public string GetFor(int x)
    {
        string retorno = string.Empty;

        for (int i = 0; i < x; i++)
        {
            retorno += $"{i}; ";
        }
        return retorno;
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
}
