using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson10
{
    public partial class products : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //use ef to fill the grid
                using (MarcDatabase objEnt = new MarcDatabase())
                {
                    var data = from Product in objEnt.Products
                               select Product;

                    //fill the grid
                    grdProducts2.DataSource = data.ToList();
                    grdProducts2.DataBind();
                }
            }
            catch (Exception objError)
            {
                CException.EmailException(objError);
                Response.Redirect("error.aspx");
            }
        }
    }
}