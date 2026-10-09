// Ejercicio 4: Fianza de Compañía de Seguros
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio17;

public class FianzaSegurosModel : PageModel
{
    [BindProperty] public double Monto { get; set; }

    public double? Cuota { get; set; }

    public void OnPost()
    {
        if (Monto < 50000)
        {
            Cuota = Monto * 0.03;
        }
        else
        {
            Cuota = Monto * 0.02;
        }
    }
}