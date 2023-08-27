namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class system_alerts
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int system_alerts_uid { get; set; }

        [Required]
        [StringLength(30)]
        public string user_id { get; set; }

        public int system_alert_type_cd { get; set; }

        [Required]
        [StringLength(255)]
        public string subject { get; set; }

        [Required]
        [StringLength(255)]
        public string notes { get; set; }

        public int row_status_flag { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        public virtual user user { get; set; }
    }
}
