// Segunda Guía - Ejercicio 8 (Carpeta Ejercicio14): Tiempo promedio
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio14;

public class TiempoPromedioModel : PageModel
{
    [BindProperty] public double T1 { get; set; }
    [BindProperty] public double T2 { get; set; }
    [BindProperty] public double T3 { get; set; }

    public double? Promedio { get; set; }

    public void OnPost()
    {
        Promedio = (T1 + T2 + T3) / 3;
    }
}