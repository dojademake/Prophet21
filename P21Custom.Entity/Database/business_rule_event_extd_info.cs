namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_event_extd_info
    {
        [Key]
        public int business_rule_event_extd_info_uid { get; set; }

        public int business_rule_event_uid { get; set; }

        [Required]
        [StringLength(4000)]
        public string triggered_from { get; set; }

        [Required]
        [StringLength(255)]
        public string keys { get; set; }

        [Required]
        [StringLength(4000)]
        public string context { get; set; }

        [Required]
        [StringLength(255)]
        public string special_return_values { get; set; }

        [Required]
        [StringLength(255)]
        public string see_also { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public virtual business_rule_event business_rule_event { get; set; }
    }
}
