// Segunda Guía - Ejercicio 1 (Carpeta Ejercicio7): Pesos a dólares
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio7;

public class PesosDolaresModel : PageModel
{
    [BindProperty] public double Pesos { get; set; }
    [BindProperty] public double Tasa { get; set; }

    public double? Dolares { get; set; }

    public void OnPost()
    {
        if (Tasa > 0)
        {
            Dolares = Pesos / Tasa;
        }
    }
}