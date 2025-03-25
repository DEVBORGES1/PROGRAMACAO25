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
        if(EXPRESSÃO BOOLEANA)
        {
            Sentença de codigo a ser executada,
            caso a condição seja verdadeira
        }
          caso o if tenha apenas uma linha de comando 
        a ser executada na condicional, não ha necessidades
        do uso das chaves

        if (Exoressão boleana)
        apenas um comando

         */
        string retorno = string.Empty;

        // int x = 10;
        if (x < 9)
            retorno = "X é maior que 9";

        // x = 8;
        if (x > 9)
            retorno = "X é Maior que 9";
        else
            retorno = "X é Menor que 9";

        // x = 11;
        if (x == 10)
        {
            retorno = "Ora ora ";
            retorno += "X é igual a 10";
        }
        else if (x == 9)
        {
            retorno = "Hmmmmmm ";
            retorno = "x é igual a 9";
        }
        else if (x == 8)
        {
            retorno = "Bahhhhh ";
            retorno = "x é igual a 8, tchê";
        }
        else retorno = "Sei lá que número é x";

        return retorno;
     }

    [HttpGet]
    public string GetSwitch(int x)
    {
        string retorno = string.Empty;

        switch (x)
        {
            case 0:
                retorno = "x é zero";
                break; 
            case 1:
                retorno = "x é Um";
                break;
            case 2:
                retorno = "x é dois";
                break;
            case 3:
                retorno = "x é três";
                break;
            case 4:
                retorno = "x é quando eu morrer eu quero ser enterrada de 4...";
                break;

            default:
                retorno = "x é algum numero não previsto";
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
