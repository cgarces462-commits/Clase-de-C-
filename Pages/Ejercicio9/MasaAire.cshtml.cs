// Segunda Guía - Ejercicio 3 (Carpeta Ejercicio9): Masa de aire
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio9;

public class MasaAireModel : PageModel
{
    [BindProperty] public double Presion { get; set; }
    [BindProperty] public double Volumen { get; set; }
    [BindProperty] public double Temperatura { get; set; }

    public double? Masa { get; set; }

    public void OnPost()
    {
        double denominador = 0.37 * (Temperatura + 460);
        if (denominador != 0)
        {
            Masa = (Presion * Volumen) / denominador;
        }
    }
}