namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class ribbon_metric_x_users
    {
        [Key]
        public int ribbon_metric_x_users_uid { get; set; }

        public int ribbon_metric_uid { get; set; }

        [Required]
        [StringLength(30)]
        public string users_id { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public virtual ribbon_metric ribbon_metric { get; set; }

        public virtual user user { get; set; }
    }
}
