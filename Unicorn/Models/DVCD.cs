﻿namespace Unicorn.Models
{
    [Table("tbl_DVCD")]
    public class DVCD
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã đơn vị không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_DVCD { get; set; }
        [Required]
        [ForeignKey("NVL")]
        public string ID_NVL { get; set; }
        public virtual NVL NVL { get; private set; }
        public int Ty_le { get; set; }
        public String Phep_tinh { get; set; }
        public String? Dien_giai { get; set; } = null;
    }
}
