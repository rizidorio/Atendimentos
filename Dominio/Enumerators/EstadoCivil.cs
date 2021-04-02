using System.ComponentModel;

namespace Dominio.Enumerators
{
    public enum EstadoCivil
    {
        [Description("")]
        NaoInformado = 0,
        [Description("Solteiro(a)")]
        Solteiro = 1,
        [Description("Casado(a)")]
        Casado = 2,
        [Description("Separado(a)")]
        Separado = 3,
        [Description("Viúvo(a)")]
        Viuvo = 4,
    }
}
