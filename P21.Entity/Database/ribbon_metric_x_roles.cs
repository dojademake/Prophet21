namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_metric_x_roles
    {
        [Key]
        public int ribbon_metric_x_roles_uid { get; set; }

        public int ribbon_metric_uid { get; set; }

        public int role_uid { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public virtual ribbon_metric ribbon_metric { get; set; }

        public virtual role role { get; set; }
    }
}
