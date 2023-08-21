namespace Unicorn.Models
{
    [Table("tbl_DVT")]
    public class DVT
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã đơn vị tính không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_DVT { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên đơn vị tính không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public String Name { get; set; }
        public String Ghi_chú { get; set; }
    }
}
