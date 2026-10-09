// Primera Guía - Ejercicio 6: Edad
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio6;

public class EdadModel : PageModel
{
    [BindProperty] public int Fnac { get; set; }
    [BindProperty] public int Fact { get; set; }

    public int? Edad { get; set; }

    public void OnPost()
    {
        Edad = Fact - Fnac;
    }
}