// Ejercicio 5: Colegiatura de Escuela
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio18;

public class ColegiaturaEscuelaModel : PageModel
{
    [BindProperty] public int NumMaterias { get; set; }
    [BindProperty] public double CostoMateria { get; set; }
    [BindProperty] public double Promedio { get; set; }

    public double? TotalPagar { get; set; }

    public void OnPost()
    {
        double subtotal = NumMaterias * CostoMateria;

        if (Promedio >= 9)
        {
            // Descuento del 30% sin IVA
            TotalPagar = subtotal * 0.70;
        }
        else
        {
            // Colegiatura completa incluye 10% de IVA
            TotalPagar = subtotal * 1.10;
        }
    }
}