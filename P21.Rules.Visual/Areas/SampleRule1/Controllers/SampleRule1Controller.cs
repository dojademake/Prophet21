
using P21.Extensions.Web;
using P21.Rules.Visual.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Web;
using System.Web.Mvc;


namespace P21.Rules.Visual.Areas.SampleRule1.Controllers
{
    public class SampleRule1Controller : BaseRuleController
    {
        //Private Variables for this controller
        private CustomerAddress _customerAddress;

        /// <summary>
        /// This action will display the rule with the form view.
        /// </summary>
        /// <returns>View</returns>
        /// 
        public ActionResult FormView()
        {
            if (!Rule.IsInitialized())
            {
                //catch the error and send it to the Error view with the HandleErrorInfo
                return View("Error", new HandleErrorInfo(
                    new Exception("Error initializing rule"), "SampleRule1", "FormView"));
            }

            try
            {
                DataRow row = Data.Set.Tables["d_customer_maint_address"].Rows[0];
                _customerAddress = new CustomerAddress();
                _customerAddress.Address1 = (string)row["mail_address1"];
                _customerAddress.Address2 = (string)row["mail_address2"];
                _customerAddress.City = (string)row["mail_city"];
                _customerAddress.Country = (string)row["mail_country"];

                return View("FormView", _customerAddress);
            }
            catch (Exception ex)
            {
                //catch the error and send it to the Error view with the HandleErrorInfo
                return View("Error", new HandleErrorInfo(ex, "SampleRule1", "FormView"));
            }
        }

        private int CodeExampleToGetValueFromDB()
        {
            SqlCommand cmd = new SqlCommand();
            Object returnValue;

            cmd.CommandText = "SELECT COUNT(*) FROM system_setting";
            cmd.CommandType = CommandType.Text;
            cmd.Connection = P21SqlConnection;

            returnValue = cmd.ExecuteScalar();

            return (int)returnValue;
        }

        /// <summary>
        /// This action will display the rule with the grid view.
        /// </summary>
        /// <returns></returns>
        /// /SampleRule1/GridView
        public ActionResult GridView()
        {
            try
            {
                List<dynamic> objList = Rule.GetDatatableAsList("d_customer_maint_address");

                return View("GridView", objList);
            }
            catch (Exception ex)
            {
                //catch the error and send it to the Error view with the HandleErrorInfo
                return View("Error", new HandleErrorInfo(ex, "SampleRule1", "FormView"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SaveAndReturn(CustomerAddress address)
        {

            try
            {
                DataRow row = Data.Set.Tables["d_customer_maint_address"].Rows[0];
                row["mail_address1"] = address.Address1;
                row["mail_address2"] = address.Address2;
                row["mail_city"] = address.City;
                row["mail_country"] = address.Country;
                Rule.RuleResult.Success = true;

                return RedirectToAction("Close", "Initialize", new { area = "" });
            }
            catch (Exception ex)
        {
                //catch the error and send it to the Error view with the HandleErrorInfo
                return View("Error", new HandleErrorInfo(ex, "SampleRule1", "FormView"));
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param></param>
        /// <returns></returns>
		[HttpPost]
		public ActionResult Return()
		{
			Rule.RuleResult.Success = true;

			//IMPORTANT - This is what returns the Visual Rule control back to the server
			//DO NOT REMOVE
			return RedirectToAction("Close", "Initialize", new { area = "" });
		}

        public ActionResult RuleView() => View(Rule);


    }

}