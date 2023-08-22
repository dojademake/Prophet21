namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class code_x_code_p21
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_x_code_uid { get; set; }

        public int source_code_no { get; set; }

        public int target_code_no { get; set; }

        public int sequence_number { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }
    }
}
