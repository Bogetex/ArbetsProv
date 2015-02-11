using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MessageCenterWebClient
{
    public partial class Message : System.Web.UI.Page
    {
        /// <summary>
        /// Initialized service proxy
        /// </summary>
        MessageService.MessageServiceClient proxy;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                proxy = new MessageService.MessageServiceClient();
                BoundField gridField = new BoundField();
                try
                {
                    grdViewMessages.AutoGenerateColumns = false;
                    grdViewMessages.DataSource = proxy.GetAllMessage();
                    grdViewMessages.DataBind();
                    
                    
                }
                catch (Exception ex)
                {
                    Response.Write("<script>alert('" + ex.Message + "');</script>");
                }
            }
        }
    }
}