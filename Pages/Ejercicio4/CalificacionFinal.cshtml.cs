// Primera Guía - Ejercicio 4: Calificación final
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio4;

public class CalificacionFinalModel : PageModel
{
    [BindProperty] public double C1 { get; set; }
    [BindProperty] public double C2 { get; set; }
    [BindProperty] public double C3 { get; set; }
    [BindProperty] public double Ef { get; set; }
    [BindProperty] public double Tf { get; set; }

    public double? Cf { get; set; }

    public void OnPost()
    {
        Cf = ((C1 + C2 + C3) / 3) * 0.55 + Ef * 0.30 + Tf * 0.15;
    }
}