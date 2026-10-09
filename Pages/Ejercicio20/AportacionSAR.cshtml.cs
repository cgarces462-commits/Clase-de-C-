// Ejercicio 7: Aportación al Sistema de Ahorro para el Retiro (SAR)
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio20;

public class AportacionSARModel : PageModel
{
    [BindProperty] public double SalarioBase { get; set; }
    [BindProperty] public double PorcentajeEmpresa { get; set; } // Porcentaje que deposita la empresa (obligatorio)
    [BindProperty] public string TipoAportacionTrabajador { get; set; } = "Porcentaje"; // "Porcentaje" o "Fija"
    [BindProperty] public double ValorAportacionTrabajador { get; set; } // Valor % o monto fijo

    public double? TotalDepositadoSAR { get; set; }
    public double? PagoMensualRecibido { get; set; }

    public void OnPost()
    {
        double aporteEmpresa = SalarioBase * (PorcentajeEmpresa / 100.0);
        double aporteTrabajador = 0;

        if (TipoAportacionTrabajador == "Porcentaje")
        {
            aporteTrabajador = SalarioBase * (ValorAportacionTrabajador / 100.0);
        }
        else
        {
            aporteTrabajador = ValorAportacionTrabajador;
        }

        TotalDepositadoSAR = aporteEmpresa + aporteTrabajador;
        PagoMensualRecibido = SalarioBase - aporteTrabajador;
    }
}