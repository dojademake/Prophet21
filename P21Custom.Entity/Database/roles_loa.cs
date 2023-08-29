namespace P21Custom.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class roles_loa
    {
        [Key]
        public int roles_loa_uid { get; set; }

        public int role_uid { get; set; }

        public decimal? order_approval_max_amt { get; set; }

        public decimal? osmi_item_loa_pct { get; set; }

        public decimal? local_item_loa_pct { get; set; }

        public decimal? price_floor_pct { get; set; }

        [StringLength(1)]
        public string price_floor_basis_flag { get; set; }

        public int? row_status_flag { get; set; }

        public DateTime date_created { get; set; }

        [Required]
        [StringLength(255)]
        public string created_by { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(255)]
        public string last_maintained_by { get; set; }

        public decimal? restricted_item_loa_pct { get; set; }
    }
}
