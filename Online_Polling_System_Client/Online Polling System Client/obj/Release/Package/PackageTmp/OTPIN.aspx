<%@ Page Title="OTP_Validation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="OTPIN.aspx.cs" Inherits="Online_Polling_System_Client.OTPIN" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h3>Online Electoral Form</h3>
    <br />
    <br />
    <div class="row" >
        <div class="col-md-4">

        </div>
        <div class="col-md-4" >
            <p style="font-weight:bold">Insert OTPIN<asp:TextBox ID="OTPINTbx" runat="server" CssClass="form-control" ></asp:TextBox></p>
            <div class="col-md-2">

            </div>
            <div class="col-md-4 form-group">
            <asp:Button ID="authenticateBtn" runat="server" Text="Authenticate" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White" OnClick="authenticateBtn_Click"/>
            </div>
            <div class="col-md-4">

            </div>
            <br />
            <asp:RequiredFieldValidator ID="OTPINTbxValidator" runat="server" ControlToValidate="OTPINTbx" CssClass="text-danger" ErrorMessage="OTPIN Field must be filled"></asp:RequiredFieldValidator>   
        </div>
                
    </div>
</asp:Content>
