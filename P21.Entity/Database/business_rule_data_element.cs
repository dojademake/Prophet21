namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_rule_data_element
    {
        [Key]
        public int business_rule_data_element_uid { get; set; }

        public int business_rule_uid { get; set; }

        [Required]
        [StringLength(255)]
        public string field_name { get; set; }

        [StringLength(255)]
        public string class_name { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        [StringLength(255)]
        public string field_alias { get; set; }

        public virtual business_rule business_rule { get; set; }
    }
}
