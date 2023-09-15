
namespace Unicorn.Models
{
    [Table("tbl_KH")]
    public class KH
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã khách hàng không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_KH { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên khách hàng không được để trống")]
        public string Name { get; set; }
        public string? Dia_chi { get; set; } = null;
        public string? Ghi_chu { get; set; } = null;
        public bool? Is_NCC { get; set; } = false;
    }
}