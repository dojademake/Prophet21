using P21.Entity.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P21.Shared.Services
{
    public class BusinessRuleService
    {
        public BusinessRuleService()
        {
            Db = new P21DbContext();
        }

        public P21DbContext Db { get; set; }

        public IEnumerable<business_rule> GetAllRules()
        {
            return Db.business_rule.Where(br => br.internal_rule_flag == "N").OrderBy(br => br.rule_name);
        }
    }
}
