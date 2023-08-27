﻿using P21Custom.Entity.Database;
using P21.Extensions.BusinessRule;
using P21.Extensions.Web;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Web;

namespace P21Custom.Entity.Services
{
    public class BusinessRuleService
    {
        private P21DbContext p21Db;

        public Rule CurrentRule { get; set; }

        public P21DbContext Db
        {
            get
            {
                if (p21Db == null)
                {
                    if (CurrentRule != null && CurrentRule.Session != null && CurrentRule.Session.Server.Contains(Environment.MachineName))
                    {
                        //TODO: consider using EntityConnectionStringBuilder if metadata information for model mapping is required.
                        SqlConnectionStringBuilder sqlConnection = new SqlConnectionStringBuilder()
                        {
                            PersistSecurityInfo = false,
                            IntegratedSecurity = true, // Trusted Connection (Windows Authentication)
                            DataSource = CurrentRule.Session.Server,
                            InitialCatalog = CurrentRule.Session.Database,
                            MultipleActiveResultSets = true,
                            ApplicationName = Assembly.GetExecutingAssembly().GetName().Name
                        };
                        p21Db = new P21DbContext(sqlConnection.ConnectionString);
                    }
                    else
                    {
                        //if (RequestData != null && !RequestData.Url.ToString().Contains("localhost"))
                        {
                            p21Db = new P21DbContext("name=P21ConnectionString");
                        }
                    }
                }
                if (p21Db == null)
                {
                    p21Db = new P21DbContext("name=RemoteConnectionString");
                }
                return p21Db;
            }
            set { p21Db = value; }
        }

        public string MaskedConnectionString
        {
            get
            {
                string unmasked = Db.Database.Connection.ConnectionString;
                int pwdIndex = unmasked.ToLower().IndexOf("password");
                if (pwdIndex < 1)
                {
                    pwdIndex = unmasked.Length;
                }
                string result = unmasked.Substring(0, Math.Min(pwdIndex, unmasked.Length));
                return result;
            }
        }

        //public HttpRequest RequestData { get; set; }

        public IEnumerable<business_rule> GetAllRules()
        {
            return Db.business_rule.Where(br => br.internal_rule_flag == "N").OrderBy(br => br.rule_name);
        }
    }
}