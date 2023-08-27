namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_event_key
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public business_rule_event_key()
        {
            business_rule = new HashSet<business_rule>();
        }

        [Key]
        public int business_rule_event_key_uid { get; set; }

        public int business_rule_event_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string key_value { get; set; }

        [Required]
        [StringLength(255)]
        public string display_value { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule> business_rule { get; set; }

        public virtual business_rule_event business_rule_event { get; set; }
    }
}
