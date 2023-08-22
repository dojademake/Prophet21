namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_event_class
    {
        [Key]
        public int business_rule_event_class_uid { get; set; }

        public int business_rule_event_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string rule_class_name { get; set; }

        public int run_type_cd { get; set; }

        public int? configuration_id { get; set; }

        public int sequence_no { get; set; }

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
