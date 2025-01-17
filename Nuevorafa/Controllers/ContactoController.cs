using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.Extensions.Logging;
using Nuevorafa.Models;
using Nuevorafa.Data;

namespace Nuevorafa.Controllers
{
    public class ContactoController : Controller
    {
        private readonly ILogger<ContactoController> _logger;

        private readonly ApplicationDbContext _context;
      public ContactoController(ILogger<ContactoController> logger,ApplicationDbContext context)
      {
        _logger = logger;
        _context = context;
      }  
      public IActionResult Index()
      {
        return View();
      }


    [HttpPost]
    public IActionResult EnviarMensaje(Contacto objcontacto)
      {
        _logger.LogDebug("Ingreso a Enviar Mensaje");

        _context.Add(objcontacto);
        _context.SaveChanges();

        ViewData["Message"]="Se registro el contacto";

        return View("Index");
      }

      [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
      public IActionResult Error()
      {
        return View("Error!");
      }
    }
}