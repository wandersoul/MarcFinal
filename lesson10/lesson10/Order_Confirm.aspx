<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Order_Confirm.aspx.cs" Inherits="lesson10.Order_Confirm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Congratulations, you have successfully placed your order!</h1>
    <div>
        <asp:Label ID="Label1" runat="server">Your new order ID number is:</asp:Label>
        <asp:Label ID="OrderID_Out" runat="server"></asp:Label>
    </div>
    
</asp:Content>
