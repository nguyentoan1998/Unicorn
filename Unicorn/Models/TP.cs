namespace Unicorn.Models
{
    [Table("tbl_TP")]
    public class TP
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã Thành phẩm không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_TP { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên Thành phẩm không được để trống")]
        [StringLength(50, ErrorMessage = "Không được vượt quá 50 ký tự")]
        public string Name { get; set; }
        public string? Mo_ta { get; set; } = null;
        public int? SL_ton { get; set; } = 0;
        public string? Nguon_goc { get; set; } = null;
        public string? DG_ban { get; set; } = null;
        public string? Image { get; set; } = "/image/No_Image.png";
        [NotMapped]
        public FormFile ImageFile { get; set; }
        public string? Size { get; set; } = null;
        [Required]
        [ForeignKey("DVT")]
        public string ID_DVT { get; set; }
        public virtual DVT DVT { get; private set; }
        [Required]
        [ForeignKey("Loai")]
        public string ID_Loai { get; set; }
        public virtual Loai Loai { get; private set; }
        public virtual List<MQC> MQC { get; set; } = new List<MQC>();
        public virtual List<DVCD> DVCD{ get; set; } = new List<DVCD>();
        public virtual List<DMNVL> DMNVL{ get; set; } = new List<DMNVL>();



    }
}
