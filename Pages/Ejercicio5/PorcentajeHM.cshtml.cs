// Primera Guía - Ejercicio 5: Porcentaje de hombres y mujeres
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio5;

public class PorcentajeHMModel : PageModel
{
    [BindProperty] public double Nh { get; set; }
    [BindProperty] public double Nm { get; set; }

    public double? Ph { get; set; }
    public double? Pm { get; set; }

    public void OnPost()
    {
        double ta = Nh + Nm;
        if (ta > 0)
        {
            Ph = (Nh * 100) / ta;
            Pm = (Nm * 100) / ta;
        }
    }
}