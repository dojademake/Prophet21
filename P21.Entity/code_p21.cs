namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class code_p21
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_uid { get; set; }

        public int code_no { get; set; }

        [Required]
        [StringLength(8)]
        public string language_id { get; set; }

        [Required]
        [StringLength(255)]
        public string code_description { get; set; }

        [Required]
        [StringLength(1)]
        public string row_status_flag { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        [StringLength(255)]
        public string code_sub_description { get; set; }
    }
}
