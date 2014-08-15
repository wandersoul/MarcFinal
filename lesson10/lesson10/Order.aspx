<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="lesson10.Order1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!--Product Name-->
    <div>
        <asp:Label ID="LabelProductName" runat="server">Product Name:</asp:Label>
        <asp:TextBox ID="TextBoxProductName" runat="server" ReadOnly="True"></asp:TextBox>
    </div>
    <!--Unit Price-->
    <div>
        <asp:Label ID="LabelUnitPrice" runat="server">Unit Price: $</asp:Label>
        <asp:TextBox ID="TextBoxUnitPrice" runat="server" ReadOnly="True"></asp:TextBox>
    </div>
    <!--Quantity-->
    <div>
        <asp:Label runat="server">Quantity:</asp:Label>
        <asp:TextBox ID="TextBoxQuantity" runat="server"></asp:TextBox>
    </div>
    <!--ShipName-->
    <div>
        <asp:Label ID="LabelShipName" runat="server">Your Name:</asp:Label>
        <asp:TextBox ID="TextBoxShipName" runat="server"></asp:TextBox>
    </div>
    <!--ShipAddress-->
    <div>
        <asp:Label ID="LabelShipAddress" runat="server">Street Address:</asp:Label>
        <asp:TextBox ID="TextBoxShipAddress" runat="server" TextMode="MultiLine"></asp:TextBox>
    </div>
    <!--ShipCity-->
    <div>
        <asp:Label ID="LabelShipCity" runat="server">City:</asp:Label>
        <asp:TextBox ID="TextBoxShipCity" runat="server"></asp:TextBox>
    </div>
    <!--ShipRegion-->
    <div>
        <asp:Label ID="LabelShipRegion" runat="server">Province/State:</asp:Label>
        <asp:TextBox ID="TextBoxShipRegion" runat="server"></asp:TextBox>
    </div>
    <!--PostalCode-->
    <div>
        <asp:Label ID="LabelPostalCode" runat="server">Postal Code:</asp:Label>
        <asp:TextBox ID="TextBoxPostalCode" runat="server"></asp:TextBox>
    </div>
    <!--ShipCountry-->
    <div>
        <asp:Label ID="LabelShipCountry" runat="server">Country:</asp:Label>
        <asp:TextBox ID="TextBoxShipCountry" runat="server"></asp:TextBox>
    </div>
    <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
</asp:Content>
