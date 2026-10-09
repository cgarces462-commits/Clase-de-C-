// Ejercicio 6: Enganche y Pagos de Bienes Raíces
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio19;

public class BienesRaicesModel : PageModel
{
    [BindProperty] public double Ingresos { get; set; }
    [BindProperty] public double CostoCasa { get; set; }

    public double? Enganche { get; set; }
    public double? PagoMensual { get; set; }

    public void OnPost()
    {
        if (Ingresos >= 8000)
        {
            Enganche = CostoCasa * 0.15;
            double resto = CostoCasa - Enganche.Value;
            PagoMensual = resto / (10 * 12); // 10 años = 120 meses
        }
        else
        {
            Enganche = CostoCasa * 0.30;
            double resto = CostoCasa - Enganche.Value;
            PagoMensual = resto / (7 * 12); // 7 años = 84 meses
        }
    }
}