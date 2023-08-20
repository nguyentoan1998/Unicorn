
namespace Unicorn.Models
{
    [Table("tbl_NCC")]
    public class NCC
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã nhà cung cấp không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_NCC { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên nhà cung cấp không được để trống")]
        public string Name { get; set; }
        public string Dia_chi { get; set; }
        public string Ghi_chu { get; set; }
        public bool Is_KH { get; set; }
    }
}