
using System.ComponentModel;

namespace Unicorn.Models
{
    [Table("tbl.NV")]
    public class NV
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã nhân viên không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_NV { get; set; }
        public string? Image { get; set; } = "/image/No_Image.png";
        [NotMapped]
        public IFormFile ImageFile { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên nhân viên không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Năm sinh không được để trống")]
        public DateTime Nam_sinh { get; set; }
        [Required(ErrorMessage = "Vui lòng chọn giới tính")]
        public string Gioi_tinh { get; set; }
        public string? Que_quan { set; get; } = null;
        public int? SDT { set; get; } = null;
        public int? CMT { set; get; } = null;
        [Required(ErrorMessage = "Vui lòng nhập ngày vào")]
        public DateTime Ngay_vao { get; set; }
        public DateTime Ngay_tao { get; set; } = DateTime.Now;
        [Required]
        [ForeignKey("To")]
        public string ID_To { get; set; }
        public virtual To Tos { get; set; }
        [Required]
        [ForeignKey("CV")]
        public string ID_CV { get; set; }
        public virtual CV CVs { get; set; }
    }
}
