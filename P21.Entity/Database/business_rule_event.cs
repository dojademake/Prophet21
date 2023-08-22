namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_event
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public business_rule_event()
        {
            business_rule_event_class = new HashSet<business_rule_event_class>();
            business_rule_event_extd_info = new HashSet<business_rule_event_extd_info>();
            business_rule_event_key = new HashSet<business_rule_event_key>();
        }

        [Key]
        public int business_rule_event_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string published_event_name { get; set; }

        [Required]
        [StringLength(255)]
        public string display_name { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [Required]
        [StringLength(1)]
        public string internal_only_flag { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        [Required]
        [StringLength(1)]
        public string allow_new_rows_flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_event_class> business_rule_event_class { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_event_extd_info> business_rule_event_extd_info { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_event_key> business_rule_event_key { get; set; }
    }
}
