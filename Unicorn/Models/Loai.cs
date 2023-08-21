namespace Unicorn.Models
{
    [Table("tbl_Loai")]
    public class Loai
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã loại vật liệu không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_Loai { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên loại vật liệu không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public String Name { get; set; }
        public String Ghi_chú { get; set; }
    }
}
