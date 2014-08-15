<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="lesson10._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        X: <asp:TextBox ID="txtX" runat="server" />
    </div>
    <div>
        Y: <asp:TextBox ID="txtY" runat="server" />
    </div>
    <div>
        <asp:Button ID="btnAdd" runat="server" Text="Add" OnClick="btnAdd_Click" />
    </div>
    <div>
        <asp:Label ID="lblResult" runat="server" />
    </div>
</asp:Content>
