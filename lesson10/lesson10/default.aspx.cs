using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson10
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //capture inputs and convert to int
                int x = int.Parse(txtX.Text);
                int y = int.Parse(txtY.Text);

                //calculate
                int sum = x + y;

                //display sum
                lblResult.Text = sum.ToString();
            }
            catch (Exception objError) {
                lblResult.Text = objError.Message;
            }
        }
    }
}