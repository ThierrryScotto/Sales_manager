using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace SystemClothes.Models
{
    public class Clothes
    {
        public int Id { get; set; }
        public string Marca { get; set; }
        public string Quantidade { get; set; }

        [Display(Name = "Valor da Compra")]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal Valor { get; set; }
        public int Tamanho { get; set; }
    }
}
