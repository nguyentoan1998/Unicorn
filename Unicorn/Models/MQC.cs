namespace Unicorn.Models
{
    [Table("tbl_MQC")]
    public class MQC
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã quy cách không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_MQC { get; set; }
        [Required]
        [ForeignKey("NVL")]
        public string ID_NVL { get; set; }
        public virtual NVL NVL { get; private set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên quy cách không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public String Name { get; set; }
        public double Gia { get; set; }
        public int Thoi_gian { get; set; }
        public int SL_Ton { get; set; }
        public double Gia_Ton { get; set; }
        public double Giatri_Ton { get; set; }

    }
}
