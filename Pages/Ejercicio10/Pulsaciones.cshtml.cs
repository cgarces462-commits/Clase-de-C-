// Segunda Guía - Ejercicio 4 (Carpeta Ejercicio10): Pulsaciones
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio10;

public class PulsacionesModel : PageModel
{
    [BindProperty] public double Edad { get; set; }

    public double? Pulsaciones { get; set; }

    public void OnPost()
    {
        Pulsaciones = (220 - Edad) / 10.0;
    }
}