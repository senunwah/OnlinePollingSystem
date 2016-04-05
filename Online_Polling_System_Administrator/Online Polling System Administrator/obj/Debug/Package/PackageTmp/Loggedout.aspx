<%@ Page Language="C#" Title="Thank you!!!" AutoEventWireup="true" CodeBehind="Loggedout.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Online_Polling_System_Administrator.Loggedout" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <div class="row">
        <h2>You are Successfully Logged out</h2>
        <div class="col-md-2"></div>
        <div class="col-md-8">
            <h1>Thank you for Using this Service</h1>
            <br />
            <asp:Button Text="Log In" runat="server" CssClass="form-control" ForeColor="#996600" />
        </div>
        <div class="col-md-8"></div>
    </div>
</asp:Content>
