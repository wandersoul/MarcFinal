using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace lesson10
{
    public partial class Order1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //getProduct();
        }

        protected void getProduct()
        {
            //get the selected ID from the url
            int ProductID;

            //if the id is an integer, look up the supplier to populate the form
            if (int.TryParse(Request.QueryString["ProductID"].ToString(), out ProductID))
            {
                using (MarcDatabase objEnt = new MarcDatabase())
                {
                    Product objS = objEnt.Products.Where(s => s.ProductID == ProductID).FirstOrDefault();
                    //fill the form controls from the model
                    TextBoxProductName.Text = objS.ProductName;
                    TextBoxUnitPrice.Text = objS.UnitPrice.ToString();
                }
            }
        }
        protected void btnSave_Click() 
        {
            //order inputs have been validated
            //save the order
            using (MarcDatabase objEnt = new MarcDatabase())
            {
                //create a new order object from EF
                Order objS;
                Order_Detail objO;
                
                //make sure we have a productID
                if (!String.IsNullOrWhiteSpace(Request.QueryString["ProductID"]))
                {
                    objS = new Order();
                    //fill the object properties from our UI
                    objS.CustomerID = TextBoxProductName.Text;
                    objS.EmployeeID = 1;
                    objS.Freight = 20;
                    objS.OrderDate = DateTime.Now;
                    objS.RequiredDate = DateTime.Now;
                    objS.ShippedDate = DateTime.Now;
                    objS.ShipVia = int.Parse(TextBoxProductName.Text);
                    objS.ShipName = TextBoxShipName.Text;
                    objS.ShipAddress = TextBoxShipAddress.Text;
                    objS.ShipCity = TextBoxShipCity.Text;
                    objS.ShipRegion = TextBoxShipRegion.Text;
                    objS.ShipPostalCode = TextBoxPostalCode.Text;
                    objS.ShipCountry = TextBoxShipCountry.Text;
                    //add the new order to the database
                    objEnt.Orders.Add(objS);

                    //additonally, we need to create a related OrderDetail entry
                    objO = new Order_Detail();
                    //fill the object properties from our UI
                    int ProductID;
                    int.TryParse(Request.QueryString["ProductID"].ToString(), out ProductID);
                    objO.ProductID = ProductID;
                    objO.UnitPrice = decimal.Parse(TextBoxUnitPrice.Text);
                    objO.Quantity = short.Parse(TextBoxQuantity.Text);
                    objO.Discount = 0;
                    //add the new order detail to the database
                    objEnt.Orders.Add(objS);
                }
            }

            //redirect to the order confirmed page
            Response.Redirect("Order_Confirm.aspx");
        }
    }
}