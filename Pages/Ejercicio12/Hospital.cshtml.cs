// Segunda Guía - Ejercicio 6 (Carpeta Ejercicio12): Presupuesto Hospital
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio12;

public class HospitalModel : PageModel
{
    [BindProperty] public double Presupuesto { get; set; }

    public double? Gineco { get; set; }
    public double? Trauma { get; set; }
    public double? Pediatria { get; set; }

    public void OnPost()
    {
        Gineco = Presupuesto * 0.40;
        Trauma = Presupuesto * 0.30;
        Pediatria = Presupuesto * 0.30;
    }
}