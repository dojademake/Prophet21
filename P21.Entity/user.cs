namespace P21.Entity
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class user
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public user()
        {
            //activity_reminder = new HashSet<activity_reminder>();
            //activity_trans = new HashSet<activity_trans>();
            //activity_trans1 = new HashSet<activity_trans>();
            //ad_role_x_users = new HashSet<ad_role_x_users>();
            //bin_replenishment_order = new HashSet<bin_replenishment_order>();
            //bin_zone = new HashSet<bin_zone>();
            business_rule_x_users = new HashSet<business_rule_x_users>();
            //call_log = new HashSet<call_log>();
            //cash_drawer_default_user = new HashSet<cash_drawer_default_user>();
            //cash_drawer_history = new HashSet<cash_drawer_history>();
            //check_payment_details = new HashSet<check_payment_details>();
            //creditcard_payment_details = new HashSet<creditcard_payment_details>();
            //creditcard_proc_comp_user = new HashSet<creditcard_proc_comp_user>();
            //creditcard_processor_x_users = new HashSet<creditcard_processor_x_users>();
            //custom_objects = new HashSet<custom_objects>();
            //datasource_x_users = new HashSet<datasource_x_users>();
            //dc_nav_drill_source_user = new HashSet<dc_nav_drill_source_user>();
            //dc_nav_drill_x_users = new HashSet<dc_nav_drill_x_users>();
            //dc_security_x_users = new HashSet<dc_security_x_users>();
            //direction_recent_search = new HashSet<direction_recent_search>();
            //dispatch_user_setting = new HashSet<dispatch_user_setting>();
            //dw_syntax_cache = new HashSet<dw_syntax_cache>();
            //email_signature_dflt_user_x_cust = new HashSet<email_signature_dflt_user_x_cust>();
            //eva_skill_security_x_users = new HashSet<eva_skill_security_x_users>();
            //fast_edit_template = new HashSet<fast_edit_template>();
            //fast_edit_template_class = new HashSet<fast_edit_template_class>();
            //fastedit_results = new HashSet<fastedit_results>();
            //grow_metric_x_users = new HashSet<grow_metric_x_users>();
            //master_inquiry_tab_default = new HashSet<master_inquiry_tab_default>();
            //mru_window = new HashSet<mru_window>();
            //opportunities = new HashSet<opportunity>();
            //order_import_exception = new HashSet<order_import_exception>();
            //pc_user_def = new HashSet<pc_user_def>();
            //portal_assignment = new HashSet<portal_assignment>();
            //prod_order_hdr = new HashSet<prod_order_hdr>();
            //report_metadata_x_users = new HashSet<report_metadata_x_users>();
            //reporting_export_log = new HashSet<reporting_export_log>();
            //research_tracking_hdr = new HashSet<research_tracking_hdr>();
            //rf_found_item = new HashSet<rf_found_item>();
            //rf_terminal = new HashSet<rf_terminal>();
            ribbon_metric_x_users = new HashSet<ribbon_metric_x_users>();
            //scheduled_job_x_users = new HashSet<scheduled_job_x_users>();
            //sort_dragdrop = new HashSet<sort_dragdrop>();
            system_alerts = new HashSet<system_alerts>();
            //task_area_x_user = new HashSet<task_area_x_user>();
            //task_auxiliary_assignee = new HashSet<task_auxiliary_assignee>();
            //user_authority = new HashSet<user_authority>();
            //user_configured_tabpage = new HashSet<user_configured_tabpage>();
            //user_preference = new HashSet<user_preference>();
            //user_window_pref = new HashSet<user_window_pref>();
            //users_x_company = new HashSet<users_x_company>();
            //users_crm = new HashSet<users_crm>();
            //users_direct_ship_edit = new HashSet<users_direct_ship_edit>();
            //users_portal = new HashSet<users_portal>();
            //users_x_application_security = new HashSet<users_x_application_security>();
            //users_x_branch = new HashSet<users_x_branch>();
            //users_x_cash_drawer = new HashSet<users_x_cash_drawer>();
            //users_x_location = new HashSet<users_x_location>();
            //users_x_salesrep = new HashSet<users_x_salesrep>();
        }

        [StringLength(30)]
        public string id { get; set; }

        [Required]
        [StringLength(40)]
        public string name { get; set; }

        [StringLength(40)]
        public string password { get; set; }

        public DateTime date_created { get; set; }

        public DateTime date_last_modified { get; set; }

        [Required]
        [StringLength(30)]
        public string last_maintained_by { get; set; }

        [Required]
        [StringLength(1)]
        public string active { get; set; }

        [Required]
        [StringLength(1)]
        public string delete_flag { get; set; }

        [Required]
        [StringLength(8)]
        public string language_id { get; set; }

        [StringLength(8)]
        public string default_company { get; set; }

        [StringLength(8)]
        public string default_branch { get; set; }

        [Required]
        [StringLength(1)]
        public string default_quote_order { get; set; }

        [StringLength(1)]
        public string create_customers { get; set; }

        [StringLength(1)]
        public string create_ship_tos { get; set; }

        public decimal? default_location_id { get; set; }

        [StringLength(1)]
        public string prompt_before_clearing { get; set; }

        public decimal? default_customer_id { get; set; }

        [Required]
        [StringLength(1)]
        public string remote_user { get; set; }

        [Required]
        [StringLength(1)]
        public string company_security { get; set; }

        [Required]
        [StringLength(1)]
        public string window_security { get; set; }

        [Required]
        [StringLength(1)]
        public string system_security { get; set; }

        [StringLength(1)]
        public string create_items_at_oe { get; set; }

        [StringLength(40)]
        public string default_application { get; set; }

        [StringLength(255)]
        public string script_path { get; set; }

        public int create_po_from_oe { get; set; }

        public int role_uid { get; set; }

        [Required]
        [StringLength(8)]
        public string designer_rights { get; set; }

        [StringLength(16)]
        public string contact_id { get; set; }

        public short print_preview_zoom_percentage { get; set; }

        [StringLength(8)]
        public string class_id { get; set; }

        [Required]
        [StringLength(1)]
        public string auto_generate_transfer_in_oe { get; set; }

        [StringLength(255)]
        public string email_address { get; set; }

        [Required]
        [StringLength(1)]
        public string receive_system_alerts { get; set; }

        [StringLength(16)]
        public string salesrep_id { get; set; }

        [Required]
        [StringLength(1)]
        public string receive_import_failure_alert { get; set; }

        [Required]
        [StringLength(1)]
        public string default_to_advanced_search { get; set; }

        public int adj_qty_available_at_oe { get; set; }

        [Required]
        [StringLength(1)]
        public string link_stock_item_to_po { get; set; }

        [Required]
        [StringLength(1)]
        public string historical_cost_in_sales_hist { get; set; }

        [Required]
        [StringLength(1)]
        public string order_cost_basis_order_cost { get; set; }

        [Required]
        [StringLength(1)]
        public string order_cost_basis_comm_cost { get; set; }

        [Required]
        [StringLength(1)]
        public string order_cost_basis_other_cost { get; set; }

        public int default_costing_basis { get; set; }

        public int? time_zone_cd { get; set; }

        public int current_cashdrawer_counter { get; set; }

        public int max_cashdrawer_counter { get; set; }

        public int current_oe_line_counter { get; set; }

        public int max_oe_line_counter { get; set; }

        public int current_invoice_line_counter { get; set; }

        public int max_invoice_line_counter { get; set; }

        public int task_visibility_cd { get; set; }

        public int create_vendor_rfq_cd { get; set; }

        [Required]
        [StringLength(1)]
        public string update_cost_from_rfq_receipt { get; set; }

        [Required]
        [StringLength(1)]
        public string display_transaction_tasks { get; set; }

        [Required]
        [StringLength(1)]
        public string allow_nonstock_tbo { get; set; }

        public int current_inv_tran_counter { get; set; }

        public int max_inv_tran_counter { get; set; }

        public int current_gl_counter { get; set; }

        public int max_gl_counter { get; set; }

        [Required]
        [StringLength(1)]
        public string create_contract_from_oe { get; set; }

        [Required]
        [StringLength(1)]
        public string mgmt_allow_branch_edit { get; set; }

        [Required]
        [StringLength(1)]
        public string mgmt_use_default_branch { get; set; }

        [Required]
        [StringLength(1)]
        public string oe_price_library_override_flag { get; set; }

        [StringLength(255)]
        public string default_label_printer { get; set; }

        [StringLength(1)]
        public string update_prospects_only_flag { get; set; }

        public int default_item_search { get; set; }

        [StringLength(1)]
        public string suppress_manual_adj_alloc_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string shipping_control_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string cnvrt_prospect_to_customer_oe { get; set; }

        [Required]
        [StringLength(1)]
        public string auto_display_rooms { get; set; }

        [Required]
        [StringLength(1)]
        public string display_purchaseprice_breaks { get; set; }

        [StringLength(16)]
        public string default_salesrep_on_order { get; set; }

        [Required]
        [StringLength(1)]
        public string default_rep_on_comm_rpt_flag { get; set; }

        [StringLength(255)]
        public string order_validation_password { get; set; }

        [StringLength(255)]
        public string machine_name { get; set; }

        [Required]
        [StringLength(1)]
        public string sales_supervisor_flag { get; set; }

        public DateTime? vacation_end_date { get; set; }

        [StringLength(16)]
        public string doe_salesrep_id { get; set; }

        [Required]
        [StringLength(1)]
        public string doe_user_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string vacation_end_date_mod_flag { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int users_uid { get; set; }

        public int? inv_group_hdr_uid { get; set; }

        [StringLength(1)]
        public string use_po_approval_threshold_flag { get; set; }

        public decimal? po_approval_threshold { get; set; }

        [Required]
        [StringLength(1)]
        public string prev_requests_search { get; set; }

        [Required]
        [StringLength(1)]
        public string view_cost_on_oe_line { get; set; }

        [StringLength(255)]
        public string bypass_check_verify_password { get; set; }

        [StringLength(255)]
        public string active_directory_role { get; set; }

        [StringLength(1)]
        public string update_branch_oe_reports_flag { get; set; }

        [StringLength(1)]
        public string oe_allow_shipment_edits { get; set; }

        [StringLength(1)]
        public string oe_allow_packing_list_reprint { get; set; }

        [StringLength(1)]
        public string salesrep_security_type { get; set; }

        [StringLength(16)]
        public string user_salesrep_id { get; set; }

        [Required]
        [StringLength(1)]
        public string default_as_taker_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string make_items_sellable_in_oe_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string add_item_locations_in_oe_flag { get; set; }

        [StringLength(1)]
        public string confirm_dea_pt_flag { get; set; }

        public int? strategic_pricing_role_uid { get; set; }

        [StringLength(255)]
        public string dflt_wwms_forms_printer { get; set; }

        [Required]
        [StringLength(1)]
        public string search_item_catalog_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string clear_item_catalog_flag { get; set; }

        [StringLength(8)]
        public string cash_drawer_id { get; set; }

        [StringLength(1)]
        public string show_components_in_sales_hist { get; set; }

        public int field_chooser_perm_cd { get; set; }

        public int? customer_profit_role_uid { get; set; }

        [StringLength(1)]
        public string allow_post_to_closed_gl_period { get; set; }

        [StringLength(1)]
        public string default_send_to_outlook_flag { get; set; }

        public int? display_open_quote_lines_cd { get; set; }

        [StringLength(1)]
        public string create_items_at_soe { get; set; }

        [StringLength(1)]
        public string restricted_class_override_flag { get; set; }

        [StringLength(1)]
        public string allow_ship_to_edit_in_oe_flag { get; set; }

        public int? show_cc_payment_acct_on_save { get; set; }

        [StringLength(1)]
        public string show_ar_cc_failed { get; set; }

        [Required]
        [StringLength(1)]
        public string override_cust_pallet_warn_flag { get; set; }

        [StringLength(255)]
        public string logo_path_filename { get; set; }

        [StringLength(255)]
        public string user_report_path { get; set; }

        [StringLength(1)]
        public string allow_shipment_confirmation { get; set; }

        public int view_vendor_type_cd { get; set; }

        [Required]
        [StringLength(1)]
        public string over_redeem_rewards_flag { get; set; }

        [StringLength(1)]
        public string extended_item_info_porg_flag { get; set; }

        [StringLength(255)]
        public string fedex_label_printer_path { get; set; }

        [Required]
        [StringLength(1)]
        public string default_item_search_in_imi { get; set; }

        public int? po_threshold_currency_id { get; set; }

        [StringLength(1)]
        public string add_customer_part_number_in_oe { get; set; }

        [Required]
        [StringLength(1)]
        public string override_754_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string allow_add_labor_to_completed_po { get; set; }

        [Required]
        [StringLength(1)]
        public string allow_postprint_edit_labor_est { get; set; }

        [StringLength(1)]
        public string do_not_export_carrier_po_flag { get; set; }

        [StringLength(30)]
        public string network_name { get; set; }

        [Required]
        [StringLength(1)]
        public string order_cost_basis_rebate_cost { get; set; }

        [StringLength(1)]
        public string convert_quote_to_order_prompt_flag { get; set; }

        [StringLength(255)]
        public string default_pick_ticket_printer { get; set; }

        [StringLength(255)]
        public string default_invoice_printer { get; set; }

        [StringLength(255)]
        public string user_signature_path { get; set; }

        [Required]
        [StringLength(1)]
        public string disable_item_category_tree_by_desc_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string imi_default_user_location { get; set; }

        [StringLength(255)]
        public string dflt_ucc128_label_printer { get; set; }

        [StringLength(1)]
        public string allow_edi_855_manual_orders_flag { get; set; }

        [Required]
        [StringLength(1)]
        public string oe_change_customer_with_items { get; set; }

        [Required]
        [StringLength(1)]
        public string allow_edit_labor_time_entry { get; set; }

        public string email_signature { get; set; }

        public decimal? default_bss_customer_id { get; set; }

        [Required]
        [StringLength(1)]
        public string rebuild_drill_security_flag { get; set; }

        public int? check_creation_role { get; set; }

        [StringLength(1)]
        public string show_cc_on_save_cash_receipts { get; set; }

        [StringLength(255)]
        public string p21_client_log_path { get; set; }

        [StringLength(255)]
        public string enterprise_search_url { get; set; }

        public int allow_report_creation_in_studio { get; set; }

        [StringLength(255)]
        public string region { get; set; }

        [StringLength(255)]
        public string docstar_server_password { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<activity_reminder> activity_reminder { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<activity_trans> activity_trans { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<activity_trans> activity_trans1 { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<ad_role_x_users> ad_role_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<bin_replenishment_order> bin_replenishment_order { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<bin_zone> bin_zone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<business_rule_x_users> business_rule_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<call_log> call_log { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<cash_drawer_default_user> cash_drawer_default_user { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<cash_drawer_history> cash_drawer_history { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<check_payment_details> check_payment_details { get; set; }

        //public virtual contact contact { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<creditcard_payment_details> creditcard_payment_details { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<creditcard_proc_comp_user> creditcard_proc_comp_user { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<creditcard_processor_x_users> creditcard_processor_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<custom_objects> custom_objects { get; set; }

        //public virtual customer customer { get; set; }

        //public virtual customer_profitability_role customer_profitability_role { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<datasource_x_users> datasource_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dc_nav_drill_source_user> dc_nav_drill_source_user { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dc_nav_drill_x_users> dc_nav_drill_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dc_security_x_users> dc_security_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<direction_recent_search> direction_recent_search { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dispatch_user_setting> dispatch_user_setting { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<dw_syntax_cache> dw_syntax_cache { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<email_signature_dflt_user_x_cust> email_signature_dflt_user_x_cust { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<eva_skill_security_x_users> eva_skill_security_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<fast_edit_template> fast_edit_template { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<fast_edit_template_class> fast_edit_template_class { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<fastedit_results> fastedit_results { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<grow_metric_x_users> grow_metric_x_users { get; set; }

        //public virtual inv_group_hdr inv_group_hdr { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<master_inquiry_tab_default> master_inquiry_tab_default { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<mru_window> mru_window { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<opportunity> opportunities { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<order_import_exception> order_import_exception { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<pc_user_def> pc_user_def { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<portal_assignment> portal_assignment { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<prod_order_hdr> prod_order_hdr { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<report_metadata_x_users> report_metadata_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<reporting_export_log> reporting_export_log { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<research_tracking_hdr> research_tracking_hdr { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<rf_found_item> rf_found_item { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<rf_terminal> rf_terminal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ribbon_metric_x_users> ribbon_metric_x_users { get; set; }

        public virtual role role { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<scheduled_job_x_users> scheduled_job_x_users { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<sort_dragdrop> sort_dragdrop { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<system_alerts> system_alerts { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<task_area_x_user> task_area_x_user { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<task_auxiliary_assignee> task_auxiliary_assignee { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<user_authority> user_authority { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<user_configured_tabpage> user_configured_tabpage { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<user_preference> user_preference { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<user_window_pref> user_window_pref { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_company> users_x_company { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_crm> users_crm { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_direct_ship_edit> users_direct_ship_edit { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_portal> users_portal { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_application_security> users_x_application_security { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_branch> users_x_branch { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_cash_drawer> users_x_cash_drawer { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_location> users_x_location { get; set; }

        //[System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        //public virtual ICollection<users_x_salesrep> users_x_salesrep { get; set; }
    }
}
