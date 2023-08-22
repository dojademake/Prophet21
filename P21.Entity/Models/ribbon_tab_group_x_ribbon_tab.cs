namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_tab_group_x_ribbon_tab
    {
        [Key]
        public int ribbon_tab_group_x_ribbon_tab_uid { get; set; }

        public int ribbon_tab_group_uid { get; set; }

        public int ribbon_tab_uid { get; set; }

        public int sequence_no { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public virtual ribbon_tab ribbon_tab { get; set; }

        public virtual ribbon_tab_group ribbon_tab_group { get; set; }
    }
}
