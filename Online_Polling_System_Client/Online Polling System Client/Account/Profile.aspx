<%@ Page Title="Profile" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Online_Polling_System_Client.Account.Profile" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h1 style="font-family:Calibri;"><%: Title %></h1>
    <p class="text-danger">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
    <div class="row" style="font-family:Calibri">
        <asp:ValidationSummary runat="server" CssClass="text-danger" />
        <div class="col-md-6">
            <h2>Basic Data</h2>
            <hr style="border-color:#0094ff" />
            <div class="form-horizontal">
                <div class="form-group">
                <asp:Label ID="Label6" runat="server" ForeColor="#996600" Text="Matric No" CssClass="col-md-2 control-label" Font-Bold="true">Matric No.</asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox ID="MatricNoTbx" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="MatricNoTbx"
                        CssClass="text-danger" ErrorMessage="The Matric No field is required." />
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label3" runat="server" Text="Firstname" ForeColor="#996600" CssClass="col-md-2 control-label" Font-Bold="true">Firstname</asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox ID="FirstnameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator runat="server" ControlToValidate="FirstnameTbx"
                        CssClass="text-danger" ErrorMessage="The Firstname field is required." />
                    </div>
                </div>
                <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Middlename" ForeColor="#996600" CssClass="col-md-2 control-label" Font-Bold="true">Middlename</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="MiddlenameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <br />
                </div>
                </div>
                <div class="form-group">
                <asp:Label ID="Label5" runat="server" ForeColor="#996600" Text="Surname" CssClass="col-md-2 control-label" Font-Bold="true">Surname</asp:Label>
                <div class="col-md-6">
                    <asp:TextBox ID="SurnameTbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="SurnameTbx"
                    CssClass="text-danger" ErrorMessage="The Surname field is required." />
                </div>
                </div>
                
                <div class="form-group">
                    <asp:Label ID="Label7" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600" Text="Faculty"></asp:Label>
                    <div class="col-md-6">
                        <asp:DropDownList ID="FacultyTbx" runat="server" AutoPostBack="true" CssClass="form-control" OnSelectedIndexChanged="FacultyTbx_SelectedIndexChanged"></asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="FacultyTbx" CssClass="text-danger" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Field must be filled"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label8" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600" Text="Department"></asp:Label>
                    <div class="col-md-6">
                        <asp:DropDownList ID="DepartmentTbx" AutoPostBack="true" runat="server" CssClass="form-control" OnSelectedIndexChanged="DepartmentTbx_SelectedIndexChanged"></asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="DepartmentTbx" CssClass="text-danger" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Field must be filled"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label9" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600" Text="Programme"></asp:Label>
                    <div class="col-md-6">
                        <asp:DropDownList ID="ProgrammeTbx" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="ProgrammeTbx" CssClass="text-danger" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Field must be filled"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label10" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600" Text="Hostel"></asp:Label>
                    <div class="col-md-6">
                        <asp:DropDownList ID="hosteldrp" runat="server" CssClass="form-control"></asp:DropDownList>
                        <asp:RequiredFieldValidator ControlToValidate="hosteldrp" CssClass="text-danger" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Field must be filled"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="form-group">
                    <asp:Label ID="Label11" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600" Text="Room No:"></asp:Label>
                    <div class="col-md-6">
                        <asp:TextBox ID="roomtbx" runat="server" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="roomtbx" CssClass="text-danger" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Field must be filled"></asp:RequiredFieldValidator>
                    </div>
                </div>        
                <div class="form-group">
                    <asp:Label runat="server" AssociatedControlID="Password" ForeColor="#996600" CssClass="col-md-2 control-label">Password</asp:Label>
                    <div class="col-md-6">
                    <asp:TextBox runat="server" ID="Password" TextMode="Password" CssClass="form-control" CausesValidation="false" />
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="The password field is required." />
                    </div>
                </div>
                </div>
        </div>
        <div class="col-md-6">
            <h2 style="font-family:Calibri;">Upload Image</h2>
            <hr style="border-color:#0094ff" />
            <div class="form-group">
                <table style="width: 100%;">
                        <tr>
                            <td style="width: 135px">
                                <asp:Image  ID="VoterImage" runat="server" Height="200px" Width="200px" ImageUrl="~/Images/DefaultImage.png" CssClass="form-control"/>
                            </td>
                            <td>
                                <asp:FileUpload ID="FileUpload" runat="server" CssClass="form-control"/>
                                <asp:Button ID="FileUploadBtn" runat="server" OnClick="FileUploadBtn_Click1" Text="Upload Photo" CssClass="btn btn-default" BackColor="White" ForeColor="#996600"/>
                            </td>
                        </tr>
                </table>
            </div>
            <br />
            <p class="text-danger">Ensure you have uploaded a Profile Picture of yourself before registering as it is very important for verification</p>
            <br />
            <h2 style="font-family:Calibri;">Security Questions</h2>
            <hr style="border-color:#0094ff" />
            <div class="form-horizontal">
                <div class="form-group">
                <asp:Label ID="Label1" runat="server" ForeColor="#996600" Text="First Security Questions" CssClass="col-md-2 control-label" Font-Bold="true"> 1st Security Question</asp:Label>
                <div class="col-md-6">
                    <p>Select your First Security Question</p>
                    <asp:DropDownList ID="sq1combo" runat="server" Width="315px" CssClass="form-control"></asp:DropDownList>
                    <asp:Checkbox ID="pq1" runat="server" CssClass="control-label" Text="Personal Question" AutoPostBack="true" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="alternatequestiontbx1" Width="315px" Visible="false" Placeholder="Type your own question here:"></asp:TextBox>
                    <p>Type answer here:</p>
                    <asp:TextBox ID="sq1Tbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="sq1Tbx"
                    CssClass="text-danger" ErrorMessage="The First Security Question field is required." />
                </div>
            </div>
                <div class="form-group">
                <asp:Label ID="Label2" runat="server" ForeColor="#996600" Text="Second Security Questions" CssClass="col-md-2 control-label" Font-Bold="true"> 2nd Security Question</asp:Label>
                <div class="col-md-6">
                    <p>Select your Second Security Question</p>
                    <asp:DropDownList ID="sq2combo" runat="server" Width="315px" CssClass="form-control"></asp:DropDownList>
                    <asp:Checkbox ID="pq2" runat="server" CssClass="control-label" Text="Personal Question" AutoPostBack="true" />
                    <asp:TextBox runat="server" CssClass="form-control" ID="alternatequestiontbx2" Width="315px" Visible="false" Placeholder="Type your own question here:"></asp:TextBox>
                    <p>Type answer here:</p>
                    <asp:TextBox ID="sq2Tbx" runat="server" CssClass="form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator runat="server" ControlToValidate="sq2Tbx"
                    CssClass="text-danger" ErrorMessage="The Second Security Question field is required." />
                </div>
            </div>
            </div>
            
        </div>
    </div>
        <div class="row">
            <div class="col-md-12">
                <hr style="border-color:#0094ff" />
                <p>*Be sure to have supplied all necessary and correct information before clicking on this button</p>
                <asp:Button ID="registerbtn" runat="server" OnClick="registerbtn_Click" Text="Update" CssClass="btn btn-primary btn-lg" BackColor="White" ForeColor="#996600"/>
            </div>
        </div>
</asp:Content>
