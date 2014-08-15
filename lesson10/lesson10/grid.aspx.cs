using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson10
{
    public partial class grid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                //use ef to fill the grid
                using (NorthwindEntities objEnt = new NorthwindEntities())
                {
                    var data = from Supplier in objEnt.Suppliers
                               select Supplier;

                    //fill the grid
                    grdSuppliers.DataSource = data.ToList();
                    grdSuppliers.DataBind();
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