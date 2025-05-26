namespace  KiemTra.Models;

using Microsoft.AspNetCore.Mvc;
public class DiemController : Controller
{
    private readonly ILogger<DiemController> _logger;

    public DiemController(ILogger<DiemController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult CalculateDiem(int diemA, int diemB, int diemC)
    {
        var diem = new Diem(diemA, diemB, diemC);
        return View("Result", diem);
    }
}
