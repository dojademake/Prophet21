namespace P21Custom.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user_authority
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int user_authority_uid { get; set; }

        public int user_approval_level { get; set; }

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

        public virtual user user { get; set; }
    }
}
