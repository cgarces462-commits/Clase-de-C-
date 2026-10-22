using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MiProyecto.Pages;

public class ObreroInput
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Range(0, 168, ErrorMessage = "Las horas deben estar entre 0 y 168")]
    public decimal Horas { get; set; }

    // Dato calculado
    public decimal Salario { get; set; }
}

public class ObrerosModel : PageModel
{
    private const decimal PagoPorHora = 20;       // Pago normal por hora
    private const decimal PagoHoraExtra = 25;     // Pago por hora extra
    private const decimal HorasNormales = 40;     // Después de 40 horas son extras

    // Cantidad de obreros (n)
    [BindProperty(SupportsGet = true)]
    public int N { get; set; }

    [BindProperty]
    public List<ObreroInput> Obreros { get; set; } = new();

    public bool Calculado { get; set; }
    public decimal TotalAPagar { get; set; }

    public void OnGet()
    {
        // Límite para evitar formularios gigantes
        if (N > 100)
        {
            N = 100;
        }

        // Creamos N obreros vacíos con un while
        int i = 0;
        while (i < N)
        {
            Obreros.Add(new ObreroInput());
            i++;
        }
    }

    public void OnPost() 
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        TotalAPagar = 0;

        // Calculamos el salario de cada obrero con un while
        int i = 0;
        while (i < Obreros.Count)
        {
            ObreroInput o = Obreros[i];

            if (o.Horas <= HorasNormales)
            {
                // Trabajó 40 horas o menos: todas se pagan a $20
                o.Salario = o.Horas * PagoPorHora;
            }
            else
            {
                // Trabajó más de 40 horas: 40 a $20 y el resto a $25
                decimal horasExtra = o.Horas - HorasNormales;
                o.Salario = (HorasNormales * PagoPorHora) + (horasExtra * PagoHoraExtra);
            }

            // Acumulamos el total general
            TotalAPagar += o.Salario;

            i++;
        }

        Calculado = true;
    }
}