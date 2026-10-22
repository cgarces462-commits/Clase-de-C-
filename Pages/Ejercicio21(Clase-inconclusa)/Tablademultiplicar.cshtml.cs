using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages;

public class TablademultiplicarModel : PageModel
{
    [BindProperty(Name = "txtN")]
    public string? TxtN { get; set; }

    public List<string> Lineas { get; set; } = new();
    public string? Error { get; set; }

    public void OnPost()
    {
        if (!int.TryParse(TxtN, out int n) || n < 1 || n > 100)
        {
            Error = "Error: ingresa un número entero entre 1 y 100.";
            return;
        }

        for (int i = 1; i <= 10; i++)
        {
            Lineas.Add($"{n} x {i} = {n * i}");
        }
    }
}