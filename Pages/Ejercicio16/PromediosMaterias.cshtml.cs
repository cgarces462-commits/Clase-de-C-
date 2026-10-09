// Segunda Guía - Ejercicio 10 (Carpeta Ejercicio16): Promedios por materia
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CalculadoraWeb.Pages.Ejercicio16;

public class PromediosMateriasModel : PageModel
{
    // Matemáticas
    [BindProperty] public double ExMat { get; set; }
    [BindProperty] public double T1Mat { get; set; }
    [BindProperty] public double T2Mat { get; set; }
    [BindProperty] public double T3Mat { get; set; }

    // Física
    [BindProperty] public double ExFis { get; set; }
    [BindProperty] public double T1Fis { get; set; }
    [BindProperty] public double T2Fis { get; set; }

    // Química
    [BindProperty] public double ExQui { get; set; }
    [BindProperty] public double T1Qui { get; set; }
    [BindProperty] public double T2Qui { get; set; }
    [BindProperty] public double T3Qui { get; set; }

    // Salidas
    public double? Mate { get; set; }
    public double? Fisica { get; set; }
    public double? Quimica { get; set; }
    public double? General { get; set; }

    public void OnPost()
    {
        Mate = ExMat * 0.90 + ((T1Mat + T2Mat + T3Mat) / 3) * 0.10;
        Fisica = ExFis * 0.80 + ((T1Fis + T2Fis) / 2) * 0.20;
        Quimica = ExQui * 0.85 + ((T1Qui + T2Qui + T3Qui) / 3) * 0.15;
        
        General = (Mate + Fisica + Quimica) / 3;
    }
}
