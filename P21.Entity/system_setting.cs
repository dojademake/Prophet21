namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class system_setting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int system_setting_uid { get; set; }

        public int configuration_id { get; set; }

        public int module_cd { get; set; }

        [Required]
        [StringLength(128)]
        public string name { get; set; }

        [Required]
        [StringLength(255)]
        public string value { get; set; }

        public int data_type_cd { get; set; }

        public int data_type_length { get; set; }

        public int data_type_scale { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }
    }
}
