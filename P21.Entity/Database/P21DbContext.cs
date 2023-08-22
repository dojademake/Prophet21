using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace P21.Entity.Database
{
    public partial class P21DbContext : DbContext
    {
        public P21DbContext()
            : base("name=P21DbContext")
        {
        }

        public virtual DbSet<business_rule> business_rule { get; set; }
        public virtual DbSet<business_rule_data_element> business_rule_data_element { get; set; }
        public virtual DbSet<business_rule_event> business_rule_event { get; set; }
        public virtual DbSet<business_rule_event_class> business_rule_event_class { get; set; }
        public virtual DbSet<business_rule_event_extd_info> business_rule_event_extd_info { get; set; }
        public virtual DbSet<business_rule_event_key> business_rule_event_key { get; set; }
        public virtual DbSet<business_rule_log> business_rule_log { get; set; }
        public virtual DbSet<business_rule_rmb> business_rule_rmb { get; set; }
        public virtual DbSet<business_rule_x_roles> business_rule_x_roles { get; set; }
        public virtual DbSet<business_rule_x_users> business_rule_x_users { get; set; }
        public virtual DbSet<code_group_p21> code_group_p21 { get; set; }
        public virtual DbSet<code_p21> code_p21 { get; set; }
        public virtual DbSet<code_x_code_group_p21> code_x_code_group_p21 { get; set; }
        public virtual DbSet<code_x_code_p21> code_x_code_p21 { get; set; }
        public virtual DbSet<grow_metric> grow_metric { get; set; }
        public virtual DbSet<ribbon> ribbons { get; set; }
        public virtual DbSet<ribbon_metric> ribbon_metric { get; set; }
        public virtual DbSet<ribbon_metric_x_roles> ribbon_metric_x_roles { get; set; }
        public virtual DbSet<ribbon_metric_x_users> ribbon_metric_x_users { get; set; }
        public virtual DbSet<ribbon_tab> ribbon_tab { get; set; }
        public virtual DbSet<ribbon_tab_group> ribbon_tab_group { get; set; }
        public virtual DbSet<ribbon_tab_group_x_ribbon_tab> ribbon_tab_group_x_ribbon_tab { get; set; }
        public virtual DbSet<ribbon_tab_x_ribbon> ribbon_tab_x_ribbon { get; set; }
        public virtual DbSet<ribbon_tool> ribbon_tool { get; set; }
        public virtual DbSet<ribbon_tool_x_ribbon_tab_group> ribbon_tool_x_ribbon_tab_group { get; set; }
        public virtual DbSet<role> roles { get; set; }
        public virtual DbSet<sys_params_p21> sys_params_p21 { get; set; }
        public virtual DbSet<system_alerts> system_alerts { get; set; }
        public virtual DbSet<system_parameters> system_parameters { get; set; }
        public virtual DbSet<system_setting> system_setting { get; set; }
        public virtual DbSet<user> users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<business_rule>()
                .Property(e => e.rule_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.field_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.class_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.apply_during_save_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.apply_globally_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.run_for_all_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.window_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.window_title)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.license_key)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.apply_to_all_rows_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.multirow_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.internal_rule_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.rule_page_url)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.show_rule_page_url_desktop_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.order_entry_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.front_counter_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .Property(e => e.rma_entry_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule>()
                .HasMany(e => e.business_rule_data_element)
                .WithRequired(e => e.business_rule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule>()
                .HasMany(e => e.business_rule_x_roles)
                .WithRequired(e => e.business_rule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule>()
                .HasMany(e => e.business_rule_x_users)
                .WithRequired(e => e.business_rule)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule_data_element>()
                .Property(e => e.field_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_data_element>()
                .Property(e => e.class_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_data_element>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_data_element>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_data_element>()
                .Property(e => e.field_alias)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.published_event_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.display_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.internal_only_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .Property(e => e.allow_new_rows_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event>()
                .HasMany(e => e.business_rule_event_class)
                .WithRequired(e => e.business_rule_event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule_event>()
                .HasMany(e => e.business_rule_event_extd_info)
                .WithRequired(e => e.business_rule_event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule_event>()
                .HasMany(e => e.business_rule_event_key)
                .WithRequired(e => e.business_rule_event)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<business_rule_event_class>()
                .Property(e => e.rule_class_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_class>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_class>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_extd_info>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_extd_info>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_key>()
                .Property(e => e.key_value)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_key>()
                .Property(e => e.display_value)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_key>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_event_key>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.log_action)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.rule_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.rule_manager_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.rule_assembly_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.run_type)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.xml)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.return_value)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.return_message)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.update_class_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.update_field_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.update_field_value)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_log>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.rmb_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.rmb_display_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.rmb_description)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.window_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.tabpage_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.datawindow_name)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.delete_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_rmb>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_x_roles>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_x_roles>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_x_users>()
                .Property(e => e.users_id)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_x_users>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<business_rule_x_users>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<code_group_p21>()
                .Property(e => e.code_group_description)
                .IsUnicode(false);

            modelBuilder.Entity<code_group_p21>()
                .Property(e => e.row_status_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<code_group_p21>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<code_p21>()
                .Property(e => e.language_id)
                .IsUnicode(false);

            modelBuilder.Entity<code_p21>()
                .Property(e => e.code_description)
                .IsUnicode(false);

            modelBuilder.Entity<code_p21>()
                .Property(e => e.row_status_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<code_p21>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<code_p21>()
                .Property(e => e.code_sub_description)
                .IsUnicode(false);

            modelBuilder.Entity<code_x_code_group_p21>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<code_x_code_p21>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.grow_metric_name)
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.grow_metric_desc)
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.show_focus_values)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.show_title)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<grow_metric>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon>()
                .HasMany(e => e.ribbon_tab_x_ribbon)
                .WithRequired(e => e.ribbon)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.window_name)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.trigger_datawindow)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.trigger_field)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.url)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_datawindow)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_field)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_title)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_desc)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_value)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_color)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.image_type)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.image_mode)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.apply_to_all_users)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.metric_format)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.global_metric)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.business_rule)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.business_rule_field_detail)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.secondary_url)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.on_click_business_rule)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.window_title)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.color_expression_datawindow)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.color_expression_field)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric>()
                .Property(e => e.grow_metric_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<ribbon_metric>()
                .HasMany(e => e.ribbon_metric_x_roles)
                .WithRequired(e => e.ribbon_metric)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_metric>()
                .HasMany(e => e.ribbon_metric_x_users)
                .WithRequired(e => e.ribbon_metric)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_metric_x_roles>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric_x_roles>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric_x_users>()
                .Property(e => e.users_id)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric_x_users>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_metric_x_users>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .Property(e => e.tab_id)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .Property(e => e.tab_text)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab>()
                .HasMany(e => e.ribbon_tab_group_x_ribbon_tab)
                .WithRequired(e => e.ribbon_tab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_tab>()
                .HasMany(e => e.ribbon_tab_x_ribbon)
                .WithRequired(e => e.ribbon_tab)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .Property(e => e.tab_group_id)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .Property(e => e.tab_group_text)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .HasMany(e => e.ribbon_tab_group_x_ribbon_tab)
                .WithRequired(e => e.ribbon_tab_group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_tab_group>()
                .HasMany(e => e.ribbon_tool_x_ribbon_tab_group)
                .WithRequired(e => e.ribbon_tab_group)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_tab_group_x_ribbon_tab>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_group_x_ribbon_tab>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_x_ribbon>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tab_x_ribbon>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.tool_id)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.tool_text)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.description)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.erp_menu)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.erp_event_message)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.erp_menu_attribute)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.image_file)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .Property(e => e.used_in_uiserver_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool>()
                .HasMany(e => e.ribbon_tool_x_ribbon_tab_group)
                .WithRequired(e => e.ribbon_tool)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<ribbon_tool_x_ribbon_tab_group>()
                .Property(e => e.created_by)
                .IsUnicode(false);

            modelBuilder.Entity<ribbon_tool_x_ribbon_tab_group>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.role1)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.delete_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.minimum_margin_percentage)
                .HasPrecision(19, 9);

            modelBuilder.Entity<role>()
                .Property(e => e.approve_count_above_threshold_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.head_office_access_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .Property(e => e.allow_unlinked_cc_on_rma_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.business_rule_x_roles)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.ribbon_metric_x_roles)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<role>()
                .HasMany(e => e.users)
                .WithRequired(e => e.role)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.module)
                .IsUnicode(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.sys_param_name)
                .IsUnicode(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.sys_param_value)
                .IsUnicode(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.sys_param_data_type)
                .IsUnicode(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.sys_param_description)
                .IsUnicode(false);

            modelBuilder.Entity<sys_params_p21>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<system_alerts>()
                .Property(e => e.user_id)
                .IsUnicode(false);

            modelBuilder.Entity<system_alerts>()
                .Property(e => e.subject)
                .IsUnicode(false);

            modelBuilder.Entity<system_alerts>()
                .Property(e => e.notes)
                .IsUnicode(false);

            modelBuilder.Entity<system_alerts>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.security_active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.comp_sec_active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.last_modified_by)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.help_directory)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.no_of_retries)
                .HasPrecision(19, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.set_up_mode)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.inventory_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.used_in_us)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.foreign_currency)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.revenue_by_item)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.ap_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.ar_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.oe_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.po_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.prod_ord_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.jc_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.multi_lingual)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.currency_mask)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.number_of_sigs)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.sig1_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.sig2_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.printer_dpi)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.default_period)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.default_year)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.coa_mask_compliance)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.amount_req_two_sigs)
                .HasPrecision(19, 4);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.validate_cust_contacts_on_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.default_backorder_qty)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.calc_backorder_in_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.print_detail_on_checkstub)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.gl_intercompany_functionality)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.ap_intercompany_functionality)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.database_version)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.fire_gl_trigger)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.logo_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.use_billing_address)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.use_payable_groups)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.use_receivable_groups)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.commission_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.use_enter_key)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.character_sensitive_popups)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.default_previous_period_year)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.display_update_was_successful)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.buyer_only_to_place_po)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.using_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.sales_pricing_method)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.tab_sec_active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.branch_sec_active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.reserved1)
                .HasPrecision(1, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.job_id_mask)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.character_specific_popups)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.num_of_dec_places_unit_price)
                .HasPrecision(1, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.num_of_dec_places_unit_cost)
                .HasPrecision(1, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.min_char_for_char_specific)
                .HasPrecision(2, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.keystroke_for_popups)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.keystroke_for_new_line_item)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.mail_module_installed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.security_method)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.system_parameter_uid)
                .HasPrecision(19, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.oe_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.pick_ticket_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.invoice_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.po_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.transfer_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.statement_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.quote_print_qty)
                .HasPrecision(5, 0);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.crystal_directory)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.enable_fax)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.fax_file_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.voucher_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.cr_dr_memo_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.invoice_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.misc_cash_receipts_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.cash_receipts_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.journal_entries_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.inv_transfer_rec_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.inv_adj_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.transfer_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.physical_count_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.order_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.rma_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.prod_order_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.process_prod_order_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.purchase_order_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.convert_po_voucher_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.repetitive_jrn_entry_approvals)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.message_log_file_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_parameters>()
                .Property(e => e.script_path)
                .IsUnicode(false);

            modelBuilder.Entity<system_setting>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<system_setting>()
                .Property(e => e.value)
                .IsUnicode(false);

            modelBuilder.Entity<system_setting>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.last_maintained_by)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.active)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.delete_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.language_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_company)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_branch)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_quote_order)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.create_customers)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.create_ship_tos)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_location_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<user>()
                .Property(e => e.prompt_before_clearing)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_customer_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<user>()
                .Property(e => e.remote_user)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.company_security)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.window_security)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.system_security)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.create_items_at_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_application)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.script_path)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.designer_rights)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.contact_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.class_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.auto_generate_transfer_in_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email_address)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.receive_system_alerts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.salesrep_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.receive_import_failure_alert)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_to_advanced_search)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.link_stock_item_to_po)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.historical_cost_in_sales_hist)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.order_cost_basis_order_cost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.order_cost_basis_comm_cost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.order_cost_basis_other_cost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.update_cost_from_rfq_receipt)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.display_transaction_tasks)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_nonstock_tbo)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.create_contract_from_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mgmt_allow_branch_edit)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.mgmt_use_default_branch)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.oe_price_library_override_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_label_printer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.update_prospects_only_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.suppress_manual_adj_alloc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.shipping_control_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.cnvrt_prospect_to_customer_oe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.auto_display_rooms)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.display_purchaseprice_breaks)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_salesrep_on_order)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_rep_on_comm_rpt_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.order_validation_password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.machine_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.sales_supervisor_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.doe_salesrep_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.doe_user_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.vacation_end_date_mod_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.use_po_approval_threshold_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.po_approval_threshold)
                .HasPrecision(19, 9);

            modelBuilder.Entity<user>()
                .Property(e => e.prev_requests_search)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.view_cost_on_oe_line)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.bypass_check_verify_password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.active_directory_role)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.update_branch_oe_reports_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.oe_allow_shipment_edits)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.oe_allow_packing_list_reprint)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.salesrep_security_type)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_salesrep_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_as_taker_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.make_items_sellable_in_oe_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.add_item_locations_in_oe_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.confirm_dea_pt_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.dflt_wwms_forms_printer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.search_item_catalog_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.clear_item_catalog_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.cash_drawer_id)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.show_components_in_sales_hist)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_post_to_closed_gl_period)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_send_to_outlook_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.create_items_at_soe)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.restricted_class_override_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_ship_to_edit_in_oe_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.show_ar_cc_failed)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.override_cust_pallet_warn_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.logo_path_filename)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_report_path)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_shipment_confirmation)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.over_redeem_rewards_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.extended_item_info_porg_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.fedex_label_printer_path)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_item_search_in_imi)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.add_customer_part_number_in_oe)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.override_754_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_add_labor_to_completed_po)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_postprint_edit_labor_est)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.do_not_export_carrier_po_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.network_name)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.order_cost_basis_rebate_cost)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.convert_quote_to_order_prompt_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_pick_ticket_printer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_invoice_printer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.user_signature_path)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.disable_item_category_tree_by_desc_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.imi_default_user_location)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.dflt_ucc128_label_printer)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_edi_855_manual_orders_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.oe_change_customer_with_items)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.allow_edit_labor_time_entry)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.email_signature)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.default_bss_customer_id)
                .HasPrecision(19, 0);

            modelBuilder.Entity<user>()
                .Property(e => e.rebuild_drill_security_flag)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.show_cc_on_save_cash_receipts)
                .IsFixedLength()
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.p21_client_log_path)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.enterprise_search_url)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.region)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .Property(e => e.docstar_server_password)
                .IsUnicode(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.business_rule_x_users)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.ribbon_metric_x_users)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.users_id)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<user>()
                .HasMany(e => e.system_alerts)
                .WithRequired(e => e.user)
                .HasForeignKey(e => e.user_id)
                .WillCascadeOnDelete(false);
        }
    }
}
