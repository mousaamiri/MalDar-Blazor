using System.ComponentModel.DataAnnotations;

namespace MalDar.UI.Models;

public class AddProductRequest
{
    [Required(ErrorMessage = "نام کالا الزامی است")]
    public string Name { get; set; } = string.Empty;
    [Range(0,double.MaxValue,ErrorMessage = "قیمت باید بزرگتر از صفر باشد")]
    public decimal Price { get; set; }
}