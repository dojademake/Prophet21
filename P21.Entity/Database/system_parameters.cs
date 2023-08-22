namespace P21.Entity.Database
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class system_parameters
    {
        [Required]
        [StringLength(1)]
        public string security_active { get; set; }

        [Required]
        [StringLength(1)]
        public string comp_sec_active { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_modified_by { get; set; }

        [StringLength(255)]
        public string help_directory { get; set; }

        public decimal? no_of_retries { get; set; }

        [StringLength(1)]
        public string set_up_mode { get; set; }

        [StringLength(1)]
        public string inventory_module_installed { get; set; }

        [StringLength(1)]
        public string used_in_us { get; set; }

        [StringLength(1)]
        public string foreign_currency { get; set; }

        [Required]
        [StringLength(1)]
        public string revenue_by_item { get; set; }

        [Required]
        [StringLength(1)]
        public string ap_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string ar_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string oe_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string po_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string prod_ord_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string jc_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string multi_lingual { get; set; }

        [StringLength(50)]
        public string currency_mask { get; set; }

        [Required]
        [StringLength(1)]
        public string number_of_sigs { get; set; }

        [StringLength(255)]
        public string sig1_path { get; set; }

        [StringLength(255)]
        public string sig2_path { get; set; }

        [Required]
        [StringLength(3)]
        public string printer_dpi { get; set; }

        [Required]
        [StringLength(1)]
        public string default_period { get; set; }

        [Required]
        [StringLength(1)]
        public string default_year { get; set; }

        [Required]
        [StringLength(1)]
        public string coa_mask_compliance { get; set; }

        public decimal? amount_req_two_sigs { get; set; }

        [Required]
        [StringLength(1)]
        public string validate_cust_contacts_on_oe { get; set; }

        [StringLength(1)]
        public string default_backorder_qty { get; set; }

        [Required]
        [StringLength(1)]
        public string calc_backorder_in_oe { get; set; }

        [Required]
        [StringLength(1)]
        public string print_detail_on_checkstub { get; set; }

        [Required]
        [StringLength(1)]
        public string gl_intercompany_functionality { get; set; }

        [Required]
        [StringLength(1)]
        public string ap_intercompany_functionality { get; set; }

        [StringLength(8)]
        public string database_version { get; set; }

        [StringLength(1)]
        public string fire_gl_trigger { get; set; }

        [StringLength(255)]
        public string logo_path { get; set; }

        public int? no_of_cycle_days { get; set; }

        [StringLength(1)]
        public string use_billing_address { get; set; }

        [StringLength(1)]
        public string use_payable_groups { get; set; }

        [StringLength(1)]
        public string use_receivable_groups { get; set; }

        [StringLength(1)]
        public string commission_module_installed { get; set; }

        [StringLength(1)]
        public string use_enter_key { get; set; }

        [StringLength(1)]
        public string character_sensitive_popups { get; set; }

        [StringLength(1)]
        public string default_previous_period_year { get; set; }

        [StringLength(1)]
        public string display_update_was_successful { get; set; }

        [StringLength(1)]
        public string buyer_only_to_place_po { get; set; }

        [StringLength(1)]
        public string using_approvals { get; set; }

        [Required]
        [StringLength(2)]
        public string sales_pricing_method { get; set; }

        [StringLength(1)]
        public string tab_sec_active { get; set; }

        [StringLength(1)]
        public string branch_sec_active { get; set; }

        public decimal? reserved1 { get; set; }

        [StringLength(64)]
        public string job_id_mask { get; set; }

        [StringLength(1)]
        public string character_specific_popups { get; set; }

        public decimal num_of_dec_places_unit_price { get; set; }

        public decimal num_of_dec_places_unit_cost { get; set; }

        public decimal? min_char_for_char_specific { get; set; }

        [StringLength(10)]
        public string keystroke_for_popups { get; set; }

        [StringLength(10)]
        public string keystroke_for_new_line_item { get; set; }

        [StringLength(1)]
        public string mail_module_installed { get; set; }

        [Required]
        [StringLength(1)]
        public string security_method { get; set; }

        [Key]
        [Column(TypeName = "numeric")]
        public decimal system_parameter_uid { get; set; }

        public decimal oe_print_qty { get; set; }

        public decimal pick_ticket_print_qty { get; set; }

        public decimal invoice_print_qty { get; set; }

        public decimal po_print_qty { get; set; }

        public decimal transfer_print_qty { get; set; }

        public decimal statement_print_qty { get; set; }

        public decimal quote_print_qty { get; set; }

        [StringLength(255)]
        public string crystal_directory { get; set; }

        [Required]
        [StringLength(1)]
        public string enable_fax { get; set; }

        [StringLength(50)]
        public string fax_file_path { get; set; }

        [Required]
        [StringLength(1)]
        public string voucher_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string cr_dr_memo_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string invoice_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string misc_cash_receipts_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string cash_receipts_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string journal_entries_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string inv_transfer_rec_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string inv_adj_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string transfer_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string physical_count_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string order_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string rma_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string prod_order_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string process_prod_order_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string purchase_order_entry_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string convert_po_voucher_approvals { get; set; }

        [Required]
        [StringLength(1)]
        public string repetitive_jrn_entry_approvals { get; set; }

        public int configuration_id { get; set; }

        [Required]
        [StringLength(255)]
        public string message_log_file_path { get; set; }

        [Required]
        [StringLength(255)]
        public string script_path { get; set; }
    }
}
