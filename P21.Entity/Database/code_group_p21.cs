namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class code_group_p21
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_group_uid { get; set; }

        public short code_group_no { get; set; }

        public byte group_type_no { get; set; }

        [Required]
        [StringLength(255)]
        public string code_group_description { get; set; }

        [Required]
        [StringLength(1)]
        public string row_status_flag { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }
    }
}
