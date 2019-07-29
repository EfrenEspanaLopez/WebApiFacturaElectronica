using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApiFacturaElectronica.Models;

namespace WebApiFacturaElectronica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {

        private List<Factura> Facturas = new List<Factura>();

        // POST api/Factura
        [HttpPost]
        public ActionResult<string> Post([FromBody] Factura factura)
        {
            CalcularIva(factura);
            Facturas.Add(factura);    
            return Ok(SumarTotal());
        }

        //Metod para calcular el IVA
        private void CalcularIva(Factura factura)
        {
            var valorIva = (factura.ValorTotal * (factura.PorcentajeIVA / 100));
        }

        ///Metodo suma el total de la lista de facturas
        private int SumarTotal()
        {
            return Facturas.Sum(x => x.ValorTotal);
        }

        
    }
}
