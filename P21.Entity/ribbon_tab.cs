namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_tab
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ribbon_tab()
        {
            ribbon_tab_group_x_ribbon_tab = new HashSet<ribbon_tab_group_x_ribbon_tab>();
            ribbon_tab_x_ribbon = new HashSet<ribbon_tab_x_ribbon>();
        }

        [Key]
        public int ribbon_tab_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string tab_id { get; set; }

        [Required]
        [StringLength(255)]
        public string tab_text { get; set; }

        [StringLength(255)]
        public string description { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_tab_group_x_ribbon_tab> ribbon_tab_group_x_ribbon_tab { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_tab_x_ribbon> ribbon_tab_x_ribbon { get; set; }
    }
}
