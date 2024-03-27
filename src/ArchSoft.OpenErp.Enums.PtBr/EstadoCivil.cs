using System.ComponentModel;

namespace ArchSoft.OpenErp.Enums.PtBr
{
    public enum EstadoCivil
    {
        [Description("Nenhum")]
        Nenhum,

        [Description("Solteiro")]
        Solteiro,

        [Description("Casado")]
        Casado,

        [Description("Viúvo")]
        Viuvo,

        [Description("Divorciado")]
        Divorciado,

        [Description("União Estável")]
        UniaoEstavel
    }
}
