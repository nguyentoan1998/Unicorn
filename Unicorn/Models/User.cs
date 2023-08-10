
namespace Unicorn.Models
{ 
    [Table("tbl_User")]
    public class User
    {
        [Key]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Mã User không được để trống")]
        [StringLength(10)]
        public string ID_User { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(50)]
        public string TK { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50)]
        public string MK { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Quyền hạn không được để trống")]
        [StringLength(10)]
        public string ID_Quyen { get; set; }
        [StringLength(10)]
        public string ID_NV { get; set; }

    }
}