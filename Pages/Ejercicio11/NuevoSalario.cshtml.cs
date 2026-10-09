// Segunda Guía - Ejercicio 5 (Carpeta Ejercicio11): Nuevo salario
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio11;

public class NuevoSalarioModel : PageModel
{
    [BindProperty] public double Salario { get; set; }

    public double? Nuevo { get; set; }

    public void OnPost()
    {
        Nuevo = Salario * 1.25;
    }
}