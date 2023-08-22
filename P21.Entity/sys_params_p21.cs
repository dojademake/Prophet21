namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class sys_params_p21
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int sys_params_uid { get; set; }

        public int configuration_id { get; set; }

        [Required]
        [StringLength(32)]
        public string module { get; set; }

        [Required]
        [StringLength(32)]
        public string sys_param_name { get; set; }

        [Required]
        [StringLength(255)]
        public string sys_param_value { get; set; }

        [Required]
        [StringLength(16)]
        public string sys_param_data_type { get; set; }

        [Required]
        [StringLength(255)]
        public string sys_param_description { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        public int code_group_no { get; set; }
    }
}
