using System.ComponentModel;

namespace RepositorioIdeias.DTO.Enum
{
    public enum EnumTipoItem
    {
        [Description("Educação")]
        Educacao = 0,
        [Description("Saúde")]
        Saude = 1,
        [Description("Laser")]
        Laser = 2,
        [Description("Mercado")]
        Mercado = 3,
        [Description("Outros")]
        Outros = 4
    }
}
