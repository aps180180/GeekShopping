using System.ComponentModel.DataAnnotations;


namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        public long Id { get; set; }

        [Required(ErrorMessage ="O Campo é obrigatório")]
        [StringLength(150)]
        public string? Name { get; set; }


        [Required(ErrorMessage = "O Campo é obrigatório")]
        //[RegularExpression(@"^\d+(\.\d{1,2})?$", ErrorMessage = "O campo Preço deve ter até duas casas decimais.")]
        public decimal Price { get; set; }

        [Required(ErrorMessage = "O Campo é obrigatório")]
        [StringLength(500)]
        public string? Description { get; set; }


        [Required(ErrorMessage = "O Campo é obrigatório")]
        [StringLength(50)]
        public string? CategoryName { get; set; }


        [Required(ErrorMessage = "O Campo é obrigatório")]
        [StringLength(300)]
        public string? ImageURL { get; set; }
    }
}
