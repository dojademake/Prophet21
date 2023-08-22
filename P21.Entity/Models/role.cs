namespace P21.Entity
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
        //    alert_recipient_role = new HashSet<alert_recipient_role>();
        //    api_data_access_x_roles = new HashSet<api_data_access_x_roles>();
            business_rule_x_roles = new HashSet<business_rule_x_roles>();
            //crystal_external_report_x_role = new HashSet<crystal_external_report_x_role>();
            //datasource_x_roles = new HashSet<datasource_x_roles>();
            //dc_nav_drill_x_roles = new HashSet<dc_nav_drill_x_roles>();
            //dc_security_x_roles = new HashSet<dc_security_x_roles>();
            //eva_skill_security_x_roles = new HashSet<eva_skill_security_x_roles>();
            //fastedit_roles = new HashSet<fastedit_roles>();
            //grow_metric_x_roles = new HashSet<grow_metric_x_roles>();
            //portal_assignment = new HashSet<portal_assignment>();
            //report_metadata_x_roles = new HashSet<report_metadata_x_roles>();
            ribbon_metric_x_roles = new HashSet<ribbon_metric_x_roles>();
            //roles_portal = new HashSet<roles_portal>();
            //roles_x_activity = new HashSet<roles_x_activity>();
            //roles_x_hold_class = new HashSet<roles_x_hold_class>();
            //scheduled_job_x_roles = new HashSet<scheduled_job_x_roles>();
            //users = new HashSet<user>();
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

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<alert_recipient_role> alert_recipient_role { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<api_data_access_x_roles> api_data_access_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_x_roles> business_rule_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<crystal_external_report_x_role> crystal_external_report_x_role { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<datasource_x_roles> datasource_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dc_nav_drill_x_roles> dc_nav_drill_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dc_security_x_roles> dc_security_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<eva_skill_security_x_roles> eva_skill_security_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<fastedit_roles> fastedit_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<grow_metric_x_roles> grow_metric_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<portal_assignment> portal_assignment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<report_metadata_x_roles> report_metadata_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric_x_roles> ribbon_metric_x_roles { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<roles_portal> roles_portal { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<roles_x_activity> roles_x_activity { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<roles_x_hold_class> roles_x_hold_class { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<scheduled_job_x_roles> scheduled_job_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<user> users { get; set; }
    }
}
