using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiFacturaElectronica.Models
{
    public class Factura
    {
        
        public int IdFactura { get; set; }
        public string NIT { get; set; }
        public string Description { get; set; }        
        public int ValorTotal { get; set; }
        public int PorcentajeIVA { get; set; }
    }
}
