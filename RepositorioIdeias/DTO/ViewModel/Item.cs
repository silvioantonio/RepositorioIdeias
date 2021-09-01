using RepositorioIdeias.DTO.Enum;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RepositorioIdeias.DTO.ViewModel
{
    public class Item
    {
        public int IdItem { get; set; }

        [DisplayName("Título"), Required]
        public string Titulo { get; set; }

        [DisplayName("Descrição")]
        public string Descricao { get; set; }

        public DateTime DataCriacao { get; set; }

        public EnumTipoItem TipoItem { get; set; }

        public EnumStatusItem StatusItem { get; set; }
    }
}
