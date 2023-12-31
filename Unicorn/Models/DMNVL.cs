﻿namespace Unicorn.Models
{
    [Table("tbl_DMNVL")]
    public class DMNVL
    {
        [Key]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Mã định múc không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_DMNVL { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Tên nguyên vật liệu không được để trống")]
        [StringLength(10, ErrorMessage = "Không được vượt quá 10 ký tự")]
        public String ID_NVL { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Số lượng không được để trống")]
        public int SL { get; set; }
        public String Ghi_chu { get; set; }
        [ForeignKey("TP")]
        public string ID_TP { get; set; }
        public virtual TP TP { get; private set; }
        [ForeignKey("BTP")]
        public string ID_BTP { get; set; }
        public virtual BTP BTP { get; private set; }
    }
}
