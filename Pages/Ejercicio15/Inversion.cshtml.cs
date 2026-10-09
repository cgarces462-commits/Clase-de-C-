// Segunda Guía - Ejercicio 9 (Carpeta Ejercicio15): Porcentaje de inversión
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio15;

public class InversionModel : PageModel
{
    [BindProperty] public double A { get; set; }
    [BindProperty] public double B { get; set; }
    [BindProperty] public double C { get; set; }

    public double? Pa { get; set; }
    public double? Pb { get; set; }
    public double? Pc { get; set; }

    public void OnPost()
    {
        double total = A + B + C;
        if (total > 0)
        {
            Pa = (A * 100) / total;
            Pb = (B * 100) / total;
            Pc = (C * 100) / total;
        }
    }
}