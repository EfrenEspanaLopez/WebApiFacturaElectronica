using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApiFacturaElectronica.Models;

namespace WebApiFacturaElectronica.Validators
{
    public class FacturaCollectionValidator : AbstractValidator<List<Factura>>
    {
        public FacturaCollectionValidator()
        {
            RuleForEach(list => list).SetValidator(new FacturaValidator());
        }
    }
}
