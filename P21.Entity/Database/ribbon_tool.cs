namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_tool
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ribbon_tool()
        {
            ribbon_tool_x_ribbon_tab_group = new HashSet<ribbon_tool_x_ribbon_tab_group>();
        }

        [Key]
        public int ribbon_tool_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string tool_id { get; set; }

        [Required]
        [StringLength(255)]
        public string tool_text { get; set; }

        [Required]
        [StringLength(255)]
        public string description { get; set; }

        [StringLength(255)]
        public string erp_menu { get; set; }

        [StringLength(255)]
        public string erp_event_message { get; set; }

        [StringLength(255)]
        public string erp_menu_attribute { get; set; }

        public int tool_type_cd { get; set; }

        public int default_tool_size { get; set; }

        [StringLength(255)]
        public string image_file { get; set; }

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
        public string used_in_uiserver_flag { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_tool_x_ribbon_tab_group> ribbon_tool_x_ribbon_tab_group { get; set; }
    }
}
