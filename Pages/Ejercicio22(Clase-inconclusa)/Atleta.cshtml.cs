using System.Globalization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages;

public class AtletaModel : PageModel
{
    private const int Dias = 10;

    [BindProperty]
    public List<string> Tiempos { get; set; } = new();

    public string? Error { get; set; }
    public string? Resultado { get; set; }
    public double Promedio { get; set; }
    public bool Cond2 { get; set; }
    public bool Cond3 { get; set; }

    public void OnGet()
    {
        Tiempos = Enumerable.Repeat("", Dias).ToList();
    }

    public void OnPost()
    {
        while (Tiempos.Count < Dias) Tiempos.Add("");

        var valores = new List<double>();

        foreach (var t in Tiempos)
        {
            string texto = (t ?? "").Trim().Replace(',', '.');

            if (!double.TryParse(texto, NumberStyles.Float, CultureInfo.InvariantCulture, out double v) || v <= 0)
            {
                Error = "Ingresa los 10 tiempos como números mayores que 0.";
                return;
            }

            valores.Add(v);
        }

        Promedio = valores.Average();

        Cond2 = valores.Any(v => v > 16);   // al menos una mayor a 16
        Cond3 = Promedio <= 15;             // promedio <= 15

        bool apto = Cond2 || Cond3;         // por lo menos una condición

        Resultado = apto
            ? "El atleta es APTO para la prueba de 5 km."
            : "El atleta NO es apto: debe buscar otra especialidad.";
    }
}