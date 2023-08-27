namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class role
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public role()
        {
            business_rule_x_roles = new HashSet<business_rule_x_roles>();
            ribbon_metric_x_roles = new HashSet<ribbon_metric_x_roles>();
            users = new HashSet<user>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int role_uid { get; set; }

        [Column("role")]
        [Required]
        [StringLength(128)]
        public string role1 { get; set; }

        [Required]
        [StringLength(1)]
        public string delete_flag { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        public decimal? minimum_margin_percentage { get; set; }

        [StringLength(1)]
        public string approve_count_above_threshold_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string head_office_access_flag { get; set; }

        [StringLength(1)]
        public string allow_unlinked_cc_on_rma_flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_x_roles> business_rule_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric_x_roles> ribbon_metric_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
