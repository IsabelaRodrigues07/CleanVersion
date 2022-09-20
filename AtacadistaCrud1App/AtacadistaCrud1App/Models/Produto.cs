using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AtacadistaCrud1App.Models
{//criar a table do db
    [Table("Produto")]
    public class Produto
    {
        //propriedades dos produtos da atacadista
        [Column("Id")]
        [Display(Name ="Identificador")]
        public int Id { get; set; }

        [Column("Nome")]
        [Display(Name = "Nome")]
        public string Nome { get; set; }

        [Column("Quantidade")]
        [Display(Name = "Quantidade")]
        public int Quantidade { get; set; }

        [Column("Categoria")]
        [Display(Name = "Categoria")]
        public string Categoria { get; set; }

        [Column("Valor")]
        [Display(Name = "Valor")]
        public decimal Valor { get; set; }


    }
}
