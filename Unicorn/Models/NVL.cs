namespace Unicorn.Models
{
    [Table("tbl_NVL")]
    public class NVL
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã nguyên vật liệu không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_NVL { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên nguyên vật liệu không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Đơn vị tính không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_DVT { get; set; }
        public string Mo_ta { get; set; }
        public int SL_ton { get; set; }
        public string Nguon_goc { get; set; }
        public string DG_mua { get; set; }
        public string DG_ban { get; set; }
        public string Image { get; set; }
        [NotMapped]
        public FormFile ImageFile { get; set; }
        public string Size { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Loại vật liệu không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public string ID_Loai { get; set; }


    }
}
