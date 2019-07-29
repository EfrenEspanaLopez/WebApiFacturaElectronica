using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFacturaElectronica.Models;

namespace WebApiFacturaElectronica.Validators
{
    public class FacturaValidator: AbstractValidator<Factura>
    {
        public FacturaValidator()
        {
            
            RuleFor(x => x.Description)
            .NotNull()
            .NotEmpty();
            
            RuleFor(x => x.IdFactura)
            .NotNull()
            .NotEmpty().
            WithMessage("El IdFactura es un valor entero positivo y unico");

            RuleFor(x => x.NIT)
                .NotNull()
                .NotEmpty()
                .Must((o, list, context) =>
            {                
                return Utilities.IsValidNIT(o.NIT);                
            }).WithMessage("El NIT debe contener sólo valores numéricos.");

            RuleFor(c=>c.ValorTotal)
                .NotEmpty()
                .NotNull()
                .Must((c,list,context) => 
                {
                    if (c.ValorTotal <= 0)
                        return false;
                    else
                        return true;                    
                
                }).WithMessage("El valor total debe ser positivo.");
            RuleFor(x=>x.PorcentajeIVA).NotEmpty().NotNull()
                .Must((o,list,context)=> 
                {
                    return Utilities.IsValidIVA(o.PorcentajeIVA);
                }).WithMessage("El valor del Iva es un valor entre 0(%) y 100(%)");
        }
    }
    
}
