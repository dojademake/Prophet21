namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_tab_group
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ribbon_tab_group()
        {
            ribbon_tab_group_x_ribbon_tab = new HashSet<ribbon_tab_group_x_ribbon_tab>();
            ribbon_tool_x_ribbon_tab_group = new HashSet<ribbon_tool_x_ribbon_tab_group>();
        }

        [Key]
        public int ribbon_tab_group_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string tab_group_id { get; set; }

        [Required]
        [StringLength(255)]
        public string tab_group_text { get; set; }

        [Required]
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
        public virtual ICollection<ribbon_tool_x_ribbon_tab_group> ribbon_tool_x_ribbon_tab_group { get; set; }
    }
}
