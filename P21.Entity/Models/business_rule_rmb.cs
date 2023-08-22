namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_rmb
    {
        [Key]
        public int business_rule_rmb_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string rmb_name { get; set; }

        [Required]
        [StringLength(255)]
        public string rmb_display_name { get; set; }

        [Required]
        [StringLength(255)]
        public string rmb_description { get; set; }

        [Required]
        [StringLength(255)]
        public string window_name { get; set; }

        [Required]
        [StringLength(255)]
        public string tabpage_name { get; set; }

        [Required]
        [StringLength(255)]
        public string datawindow_name { get; set; }

        public int rmb_sequence_no { get; set; }

        public int business_rule_uid { get; set; }

        [Required]
        [StringLength(1)]
        public string delete_flag { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }
    }
}
