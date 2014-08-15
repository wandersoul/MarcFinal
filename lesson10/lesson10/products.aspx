<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="products.aspx.cs" Inherits="lesson10.products" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <asp:GridView ID="grdProducts2" runat="server" AutoGenerateColumns="false" DataKeyNames="ProductID" >
        <Columns>
            <asp:BoundField DataField="ProductName" HeaderText="Product Name" />
            <asp:BoundField DataField="QuantityPerUnit" HeaderText="Quantity per Unit" />
            <asp:BoundField DataField="UnitPrice" HeaderText="Price per Unit" />
            <asp:HyperLinkField HeaderText="Order Product" NavigateUrl="~/Order.aspx" DataNavigateUrlFields="ProductID" DataNavigateUrlFormatString="~/Order.aspx?ProductID={0}" Text="Order" />
        </Columns>
    </asp:GridView>

</asp:Content>
