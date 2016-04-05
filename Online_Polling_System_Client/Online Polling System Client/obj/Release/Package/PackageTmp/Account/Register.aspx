<%@ Page Title="Register" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Online_Polling_System_Client.Account.Register" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2><%: Title %>.</h2>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <div class="form-horizontal">
        <h4>Create a new account</h4>
        <hr />
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="col-md-6">
        <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Firstname" CssClass="col-md-2 control-label" Font-Bold="true">Firstname</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="FirstnameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstnameTbx"
                    CssClass="text-danger" ErrorMessage="The Firstname field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Middlename" CssClass="col-md-2 control-label" Font-Bold="true">Middlename</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="MiddlenameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="MiddlenameTBX"
                    CssClass="text-danger" ErrorMessage="The Middlename field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Surname" CssClass="col-md-2 control-label" Font-Bold="true">Surname</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="SurnameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="SurnameTbx"
                    CssClass="text-danger" ErrorMessage="The Surname field is required." />
                </div>
            </div>
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="Matric No" CssClass="col-md-2 control-label" Font-Bold="true">Matric No.</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="MatricNoTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="MatricNoTbx"
                    CssClass="text-danger" ErrorMessage="The Matric No field is required." />
                </div>
            </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Email" CssClass="col-md-2 control-label">Email</asp:Label>
            <div class="col-md-6">
                <asp:TextBox runat="server" ID="Email" CssClass="form-control" TextMode="Email" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Email"
                    CssClass="text-danger" ErrorMessage="The email field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label">Password</asp:Label>
            <div class="col-md-6">
                <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="Password"
                    CssClass="text-danger" ErrorMessage="The password field is required." />
            </div>
        </div>
        <div class="form-group">
            <asp:Label runat="server" AssociatedControlID="ConfirmPassword" CssClass="col-md-2 control-label">Confirm password</asp:Label>
            <div class="col-md-6">
                <asp:TextBox runat="server" ID="ConfirmPassword" TextMode="Password" CssClass="form-control" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The confirm password field is required." />
                <asp:CompareValidator runat="server" ControlToCompare="Password" ControlToValidate="ConfirmPassword"
                    CssClass="text-danger" Display="Dynamic" ErrorMessage="The password and confirmation password do not match." />
            </div>
        </div>
        <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="First Security Questions" CssClass="col-md-2 control-label" Font-Bold="true"> 1st Security Question</asp:Label>
                <div class="col-md-6">
                    <p>Select your First Security Question</p>
                    <asp:DropDownList ID="sq1combo" runat="server" Height="16px" Width="315px" CssClass="form-control"></asp:DropDownList>
                    <p>Type answer here:</p>
                    <asp:TextBox ID="sq1Tbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="sq1Tbx"
                    CssClass="text-danger" ErrorMessage="The  First Security Question field is required." />
                </div>
            </div>
        <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Second Security Questions" CssClass="col-md-2 control-label" Font-Bold="true"> 2nd Security Question</asp:Label>
                <div class="col-md-6">
                    <p>Select your Second Security Question</p>
                    <asp:DropDownList ID="sq2combo" runat="server" Height="16px" Width="315px" CssClass="form-control"></asp:DropDownList>
                    <p>Type answer here:</p>
                    <asp:TextBox ID="sq2Tbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="sq2Tbx"
                    CssClass="text-danger" ErrorMessage="The Second Security Question field is required." />
                </div>
            </div>
        
        </div>
    </div>
        <div class="col-md-6">
            <div class="form-group">
                <h2>Upload Image</h2>
                <table style="width: 100%;">
                        <tr>
                            <td style="width: 135px">
                    <asp:Image  ID="Image1" runat="server" Height="140px" Width="124px" BackColor="#009933" CssClass="form-control"/>
                            </td>
                            <td>
                   <asp:FileUpload ID="FileUrl" runat="server" CssClass="form-control"/>
                   <asp:Button ID="FileUploadBtn" runat="server" Text="Upload File" CssClass="btn btn-default" BackColor="#009933" ForeColor="#ffffff"/>
                            </td>
                        </tr>
                    </table>
            </div>
        </div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
        <div class="row">
            <div class="col-md-12">
                <p>_______________________________________________________________________________________________________________________________________</p>
                <p>*Be sure to have supplied all necessary and correct information before clicking on this button</p>
                <asp:Button runat="server" OnClick="CreateUser_Click" Text="Register" CssClass="btn btn-default" BackColor="#009933" ForeColor="#ffffff"/>
            </div>
        </div>
</asp:Content>
