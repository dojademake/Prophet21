using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P21.Rules.Visual
{
    public partial class Error : System.Web.UI.Page
    {
        public string lastError;
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Server.GetLastError() != null)
                {
                    lastError = Server.GetLastError().ToString();
                }
                else
                {
                    if (Request.QueryString["controller"] != null)
                    {
                        lastError = $"Error reported by: {Request.QueryString["controller"]} - {Request.QueryString["action"]}";
                    }
                    else
                    {
                        lastError = "Something went wrong...";
                    }
                }
            }
            catch (Exception ex)
            {
                lastError = ex.Message;
            }
        }
    }
}