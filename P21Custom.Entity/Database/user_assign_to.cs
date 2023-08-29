namespace P21Custom.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_assign_to
    {
        [Key]
        public int user_assign_to_uid { get; set; }

        [Required]
        [StringLength(30)]
        public string user_id { get; set; }

        [Required]
        [StringLength(30)]
        public string assign_to_user_id { get; set; }

        [Required]
        [StringLength(1)]
        public string delete_flag { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }
    }
}
