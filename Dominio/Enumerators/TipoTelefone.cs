using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Enumerators
{
    public enum TipoTelefone
    {
        [Description("")]
        NaoInformado = 0,
        Comercial = 1,
        Residencial = 2,
        Celular = 3,
    }
}
