
namespace Unicorn.Models
{
    [Table("tbl_Quyen")]
    public class Quyen
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã quyền hạn không được để trống")]
        [MaxLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_Quyen { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên quyền hạn không được để trống")]
        [MaxLength(50, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string Name { get; set; }
        public bool IS_Quy { get; set; }
        public bool IS_Mua { get; set; }
        public bool IS_Ban { get; set; }
        public bool IS_Kho { get; set; }
        public bool IS_CCDC { get; set; }
        public bool IS_TSCD { get; set; }
        public bool IS_THP { get; set; }
        public bool IS_TL { get; set; }
        public bool IS_TP { get; set; }
        public bool IS_QLUser { get; set; }
        public bool IS_Quyen { get; set; }
    }
}