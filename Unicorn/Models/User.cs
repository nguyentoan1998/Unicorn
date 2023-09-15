
namespace Unicorn.Models
{ 
    [Table("tbl_User")]
    public class User
    {
        [Key]
        [Required(AllowEmptyStrings = false,ErrorMessage = "Mã User không được để trống")]
        [StringLength(10)]
        public String ID_User { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Tài khoản không được để trống")]
        [StringLength(50)]
        public string TK { get; set; }
        [Required(AllowEmptyStrings = false,ErrorMessage = "Mật khẩu không được để trống")]
        [StringLength(50)]
        public string MK { get; set; }
        [Required]
        [ForeignKey("NV")]
        public string ID_NV { get; set; }
        public virtual NV NV { get; private set; }

    }
}