
namespace Unicorn.Models
{
    [Table("tbl_CV")]
    public class CV
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã chức vụ không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_CV { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên chức vụ không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        public string Ghi_chu { get; set; }
    }
}