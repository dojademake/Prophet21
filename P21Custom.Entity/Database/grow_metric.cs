namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class grow_metric
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public grow_metric()
        {
            ribbon_metric = new HashSet<ribbon_metric>();
        }

        public int grow_metric_id { get; set; }

        [Required]
        [StringLength(255)]
        public string grow_metric_name { get; set; }

        [StringLength(255)]
        public string grow_metric_desc { get; set; }

        public int? height { get; set; }

        public int? width { get; set; }

        [Required]
        [StringLength(1)]
        public string show_focus_values { get; set; }

        [Required]
        [StringLength(1)]
        public string show_title { get; set; }

        public int theme { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public int p21_integration_x_company_uid { get; set; }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int grow_metric_uid { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric> ribbon_metric { get; set; }
    }
}
