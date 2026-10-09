// Segunda Guía - Ejercicio 2 (Carpeta Ejercicio8): Valor absoluto
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio8;

public class ValorAbsolutoModel : PageModel
{
    [BindProperty] public double Numero { get; set; }

    public double? Resultado { get; set; }

    public void OnPost()
    {
        Resultado = Math.Abs(Numero);
    }
}
