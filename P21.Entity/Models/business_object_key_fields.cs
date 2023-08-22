namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class business_object_key_fields
    {
        [Key]
        public int business_object_key_fields_uid { get; set; }

        [Required]
        [StringLength(100)]
        public string business_object_name { get; set; }

        [Required]
        [StringLength(255)]
        public string key_field_names { get; set; }

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
