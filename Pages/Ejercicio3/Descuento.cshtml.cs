using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio3;

public class DescuentoModel : PageModel
{
    // entrada
    [BindProperty] public double Tc { get; set; }

    // salida
    public double? Tp { get; set; }

    public void OnPost()
    {
        double d = Tc * 0.15;
        Tp = Tc - d;
    }
}