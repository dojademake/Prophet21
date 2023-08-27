namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_log
    {
        [Key]
        public int business_rule_log_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string user_id { get; set; }

        [Required]
        [StringLength(255)]
        public string log_action { get; set; }

        [StringLength(255)]
        public string rule_name { get; set; }

        [StringLength(255)]
        public string rule_manager_name { get; set; }

        [StringLength(255)]
        public string rule_assembly_name { get; set; }

        [StringLength(255)]
        public string run_type { get; set; }

        [Column(TypeName = "text")]
        public string xml { get; set; }

        [StringLength(255)]
        public string return_value { get; set; }

        [StringLength(8000)]
        public string return_message { get; set; }

        [StringLength(255)]
        public string update_class_name { get; set; }

        public int? update_row_id { get; set; }

        public int? update_row_number { get; set; }

        [StringLength(255)]
        public string update_field_name { get; set; }

        [StringLength(8000)]
        public string update_field_value { get; set; }

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
