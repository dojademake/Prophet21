namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class code_x_code_group_p21
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short code_group_no { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_no { get; set; }

        public short? sub_group_no { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }
    }
}
