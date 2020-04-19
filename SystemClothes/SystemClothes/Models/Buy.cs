using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SystemClothes.Models
{
    public class Buy
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public long Celular { get; set; }

        [Display(Name = "Valor da Compra")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        public string Produto { get; set; }

        [DataType(DataType.Date)]
        public DateTime Pagamento { get; set; }
    }
}
