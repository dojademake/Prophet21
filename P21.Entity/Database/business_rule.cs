namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public business_rule()
        {
            business_rule_data_element = new HashSet<business_rule_data_element>();
            business_rule_x_roles = new HashSet<business_rule_x_roles>();
            business_rule_x_users = new HashSet<business_rule_x_users>();
        }

        [Key]
        public int business_rule_uid { get; set; }

        public int rule_type_cd { get; set; }

        [Required]
        [StringLength(255)]
        public string rule_name { get; set; }

        [StringLength(255)]
        public string field_name { get; set; }

        [StringLength(255)]
        public string class_name { get; set; }

        [Required]
        [StringLength(1)]
        public string apply_during_save_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string apply_globally_flag { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public int row_status_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string run_for_all_flag { get; set; }

        [StringLength(255)]
        public string window_name { get; set; }

        [StringLength(255)]
        public string window_title { get; set; }

        [StringLength(255)]
        public string license_key { get; set; }

        [Required]
        [StringLength(1)]
        public string apply_to_all_rows_flag { get; set; }

        [StringLength(1)]
        public string multirow_flag { get; set; }

        public int? business_rule_event_uid { get; set; }

        public int run_type_cd { get; set; }

        public int? business_rule_event_key_uid { get; set; }

        public int enabled_for_version_cd { get; set; }

        [StringLength(1)]
        public string internal_rule_flag { get; set; }

        [StringLength(8000)]
        public string rule_page_url { get; set; }

        [StringLength(1)]
        public string show_rule_page_url_desktop_flag { get; set; }

        [StringLength(1)]
        public string order_entry_flag { get; set; }

        [StringLength(1)]
        public string front_counter_flag { get; set; }

        [StringLength(1)]
        public string rma_entry_flag { get; set; }

        public virtual business_rule_event_key business_rule_event_key { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_data_element> business_rule_data_element { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_x_roles> business_rule_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_x_users> business_rule_x_users { get; set; }
    }
}
