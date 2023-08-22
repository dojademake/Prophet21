namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_metric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ribbon_metric()
        {
            ribbon_metric_x_roles = new HashSet<ribbon_metric_x_roles>();
            ribbon_metric_x_users = new HashSet<ribbon_metric_x_users>();
        }

        [Key]
        public int ribbon_metric_uid { get; set; }

        [StringLength(255)]
        public string window_name { get; set; }

        [StringLength(255)]
        public string trigger_datawindow { get; set; }

        [Required]
        [StringLength(255)]
        public string trigger_field { get; set; }

        [StringLength(8000)]
        public string url { get; set; }

        [StringLength(255)]
        public string metric_datawindow { get; set; }

        [StringLength(255)]
        public string metric_field { get; set; }

        [StringLength(255)]
        public string metric_title { get; set; }

        [StringLength(255)]
        public string metric_desc { get; set; }

        [StringLength(255)]
        public string metric_value { get; set; }

        [StringLength(8)]
        public string metric_color { get; set; }

        public int metric_type { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        [StringLength(255)]
        public string image_type { get; set; }

        [StringLength(255)]
        public string image_mode { get; set; }

        public int row_status_flag { get; set; }

        [StringLength(1)]
        public string apply_to_all_users { get; set; }

        [StringLength(255)]
        public string metric_format { get; set; }

        [Required]
        [StringLength(1)]
        public string global_metric { get; set; }

        [StringLength(255)]
        public string business_rule { get; set; }

        [StringLength(8000)]
        public string business_rule_field_detail { get; set; }

        [StringLength(8000)]
        public string secondary_url { get; set; }

        [StringLength(255)]
        public string on_click_business_rule { get; set; }

        [StringLength(255)]
        public string window_title { get; set; }

        [StringLength(255)]
        public string color_expression_datawindow { get; set; }

        [StringLength(255)]
        public string color_expression_field { get; set; }

        public int? grow_metric_uid { get; set; }

        public decimal? grow_metric_id { get; set; }

        public virtual grow_metric grow_metric { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric_x_roles> ribbon_metric_x_roles { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric_x_users> ribbon_metric_x_users { get; set; }
    }
}
