using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages;

public class VendedorInput
{
    [Required(ErrorMessage = "El nombre es obligatorio")]
    public string Nombre { get; set; } = string.Empty;

    [Range(0, 999999999, ErrorMessage = "El sueldo base no puede ser negativo")]
    public decimal SueldoBase { get; set; }

    [Range(0, 999999999, ErrorMessage = "La venta 1 no puede ser negativa")]
    public decimal Venta1 { get; set; }

    [Range(0, 999999999, ErrorMessage = "La venta 2 no puede ser negativa")]
    public decimal Venta2 { get; set; }

    [Range(0, 999999999, ErrorMessage = "La venta 3 no puede ser negativa")]
    public decimal Venta3 { get; set; }

    // Datos calculados
    public decimal TotalVentas { get; set; }
    public decimal Comision { get; set; }
    public decimal SueldoTotal { get; set; }
}

public class VendedoresModel : PageModel
{
    private const decimal PorcentajeComision = 0.10m;

    // Cantidad de vendedores (n)



[BindProperty(SupportsGet = true)]
public int N { get; set; }

[BindProperty]
public List<VendedorInput> Vendedores { get; set; } = new();

public bool Calculado { get; set; }
public decimal TotalComisiones { get; set; }
public decimal TotalAPagar { get; set; }

public IActionResult OnGet()
{
    // 1. Si N es negativo, agregamos un error al ModelState y evitamos que explote
    if (N < 0)
    {
        ModelState.AddModelError(nameof(N), "N no puede ser negativo.");
        N = 0; // Opcional: lo reseteamos a 0 para que no rompa la vista
    }
    // 2. Límite para evitar formularios gigantes
    if (N > 100)
    {
        N = 100;
    }

    // 3. Creamos los N vendedores vacíos (si N es negativo, N será 0 y no creará nada)
    int i = 0;
    while (i < N)
    {
        Vendedores.Add(new VendedorInput());
        i++;
    }

    // 4. Retornamos la página (si hubo error en ModelState, se mostrará en el HTML con <span asp-validation-for="N"></span>)
    return Page();
}
    public void OnPost()
    {
        if (!ModelState.IsValid)
        {
            return;
        }

        TotalComisiones = 0;
        TotalAPagar = 0;

        // Calculamos cada vendedor con un while
        int i = 0;
        while (i < Vendedores.Count)
        {
            VendedorInput v = Vendedores[i];

            v.TotalVentas = v.Venta1 + v.Venta2 + v.Venta3;
            v.Comision = v.TotalVentas * PorcentajeComision;
            v.SueldoTotal = v.SueldoBase + v.Comision;

            // Acumulamos los totales generales
            TotalComisiones += v.Comision;
            TotalAPagar += v.SueldoTotal;

            i++;
        }

        Calculado = true;
    }
}