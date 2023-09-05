namespace P21Custom.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class code_p21
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public code_p21()
        {
            this.business_rule_types = new HashSet<business_rule>();
            this.business_rule_runs = new HashSet<business_rule>();
        }

        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int code_uid { get; set; }

        [Key]
        public int code_no { get; set; }

        [Required]
        [StringLength(8)]
        public string language_id { get; set; }

        [Required]
        [StringLength(255)]
        public string code_description { get; set; }

        [Required]
        [StringLength(1)]
        public string row_status_flag { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        [StringLength(255)]
        public string code_sub_description { get; set; }

        [InverseProperty("rule_type")]
        public virtual ICollection<business_rule> business_rule_types { get; set; }

        [InverseProperty("run_type")]
        public virtual ICollection<business_rule> business_rule_runs { get; set; }
    }
}
