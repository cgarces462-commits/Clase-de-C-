// Segunda Guía - Ejercicio 7 (Carpeta Ejercicio13): Precio de venta
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio13;

public class PrecioVentaModel : PageModel
{
    [BindProperty] public double Costo { get; set; }

    public double? Venta { get; set; }

    public void OnPost()
    {
        Venta = Costo * 1.30;
    }
}