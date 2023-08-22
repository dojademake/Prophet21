namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_tool_x_ribbon_tab_group
    {
        [Key]
        public int ribbon_tool_x_ribbon_tab_group_uid { get; set; }

        public int ribbon_tool_uid { get; set; }

        public int ribbon_tab_group_uid { get; set; }

        public int sequence_no { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public bool enabled_flag { get; set; }

        public int enabled_for_version_cd { get; set; }

        public virtual ribbon_tab_group ribbon_tab_group { get; set; }

        public virtual ribbon_tool ribbon_tool { get; set; }
    }
}
