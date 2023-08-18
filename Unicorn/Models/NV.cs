

using System.ComponentModel;

namespace Unicorn.Models
{
    [Table("tbl.NV")]
    public class NV
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã nhân viên không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_NV { get; set; }
        public string Image { get;set; }
        [NotMapped]
        [DisplayName("Profile Image")]
        public IFormFile ImageFile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên nhân viên không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Năm sinh không được để trống")]
        public DateTime Nam_sinh { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public string Gioi_tinh { get; set; }
        public string Que_quan { set; get; }
        public Nullable<int> SDT { set; get; }
        public Nullable<int> CMT { set; get; }
        [Required(ErrorMessage = "Vui lòng nhập ngày vào")]
        public DateTime Ngay_vao { get; set; }
        public DateTime Ngay_tao { get; set; }
        [Required(ErrorMessage = "Tổ không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_To { get; set; }
        [NotMapped]
        public string Name_To{ get; set; }
        [Required(ErrorMessage = "Chức vụ không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_Chucvu { get; set; }
        [NotMapped]
        public string Name_CV { get; set; }
    }
}
