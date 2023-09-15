
namespace Unicorn.Models
{
    [Table("tbl_To")]
    public class To
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã tổ không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_To { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên tổ không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        public string? Ghi_chu { get; set; } = null;
    }
}