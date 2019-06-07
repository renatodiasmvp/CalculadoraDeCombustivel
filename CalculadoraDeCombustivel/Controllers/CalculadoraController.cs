using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using calculadoradecombustivel.Models;

namespace CalculadoraDeCombustivel.Controllers
{
    public class CalculadoraController : Controller
    {
        [HttpGet]
        public IActionResult Calcular()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Calcular([Bind("ValorPorLitro,ValorPago")] CalculoDeCombustivel calculo)
        {
            ViewBag.Litros = null;
            if (calculo.LitrosAbastecidos() > 0)
            {
                ViewBag.Litros = calculo.LitrosAbastecidos();
            }
            return View();
        }
    }
}