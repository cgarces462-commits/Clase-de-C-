using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages;

public class CalculadoraModel : PageModel
{
    [BindProperty] public double Num1 { get; set; }
    [BindProperty] public double Num2 { get; set; }
    public double? Resultado { get; set; }

    public void OnPost()
    {
        Resultado = Num1 + Num2;
    }
}