<%@ Page Title="Election Report Sheet" Language="C#" AutoEventWireup="true" CodeBehind="ReportSheet.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Online_Polling_System_Administrator.ReportSheet" %>

<asp:Content ID="BodyContent" runat="server" ContentPlaceHolderID="MainContent">
    <h1>Online Polling System</h1>
    <h2>ELECTION REPORT SHEET</h2>
    <div class="row">
        <div class="col-md-2"></div>
        <div class="col-md-6">
            <h3>Generate Report</h3>
            <div class="col-md-12 form-group" >
                <h4>Select Election</h4><asp:DropDownList ID="DropDownList1" runat="server" CssClass="col-md-12 form-control"></asp:DropDownList>
                <h4>Select Post</h4><asp:DropDownList ID="DropDownList2" runat="server" CssClass="col-md-6 form-control"></asp:DropDownList>
            </div>
        </div>
        <div class="col-md-4"></div>
    </div>
        
</asp:Content>
