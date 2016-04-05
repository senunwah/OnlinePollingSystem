 <%@ Page Title="New Candidate" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="NewCandidate.aspx.cs" Inherits="Online_Polling_System_Administrator.NewCandidate" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
     <div>
        <h2 >Add Candidates</h2>
        <h3 >Add Candidates to your Election Post:</h3>
        <hr />
        <p style="color: #ff0000; ">*Kindly input Candidate Details</p>
         <div class="row">
            <div class="col-md-6">
                <h3>Select Election</h3>
                <asp:DropDownList ID="electioncombo" CssClass="form-control" Width="400px" runat="server" AutoPostBack="true" OnSelectedIndexChanged="electioncombo_SelectedIndexChanged"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" CssClass="text-danger" ControlToValidate="electioncombo" runat="server" ErrorMessage="You must add an Election"></asp:RequiredFieldValidator>
            </div>
            <div class="col-md-6">
                <h3>Select Post</h3>
                <asp:DropDownList ID="postcombo" CssClass="form-control" Width="400px" runat="server" AutoPostBack="true"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger" ControlToValidate="postcombo" runat="server" ErrorMessage="You must select a post"></asp:RequiredFieldValidator>
                <br />
            </div>
         </div>
        <div class="row">
            <div class="col-md-6">
                <h2>Add your Candidate's Image</h2>
                <hr />
                <table style="width: 58%;">
                    <tr>
                        <td style="width: 233px">
                            <p style="color:#996600; font-weight:bold">Add Image:</p>
                            <asp:Image ID="CandidateImage" runat="server" Height="165px" Width="165px" CssClass="form-control" ImageUrl="~/Images/DefaultImage.png"/>
                        </td>
                        <td>
                            <asp:FileUpload ID="FileUpload" runat="server" CssClass="form-control"  />
                            <asp:Button ID="addImagebtn" CssClass="btn btn-default" runat="server" Text="Add Image" OnClick="addImagebtn_Click" />
                            <br />
                        </td>
                    </tr>
                </table>
            </div>
            <div class="col-md-6">
            <h2>Fill in Candidate Details</h2>
            <hr />
            <div>
            <asp:Label ID="Label1" runat="server" Text="Candidate Name" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                    <asp:TextBox ID="nameTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                    <br />
                    <asp:RequiredFieldValidator ID="nameValidator" ControlToValidate="nameTbx" runat="server" CssClass="text-danger" ErrorMessage="Firstname field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="form-group">
            <asp:Label ID="Label2" runat="server" Text="Matric No" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                    <asp:DropDownList ID="yearCombo" runat="server" CssClass="col-md-2 form-control"></asp:DropDownList>
                    <asp:DropDownList ID="facultyinitialsCombo" runat="server" CssClass="col-md-2 form-control"></asp:DropDownList>
                    <asp:DropDownList ID="programmecodeCombo" runat="server" CssClass="col-md-2 form-control"></asp:DropDownList>
                    <h4 class="col-md-1" style="font-weight: bold">/</h4>
                    <asp:DropDownList ID="serialnoCombo" runat="server" CssClass="col-md-3 form-control"></asp:DropDownList>
                    <br />
                    <br />
                </div>
            </div>
            <div class="form-group">
            <asp:Label ID="Label3" runat="server" Text="Faculty" CssClass="control-label" ForeColor="#996600" Font-Bold="true"></asp:Label>
                <div>
                     <asp:DropDownList ID="facultyCombo" runat="server" CssClass="col-md-10 form-control" AutoPostBack="true" OnSelectedIndexChanged="facultyCombo_SelectedIndexChanged" ></asp:DropDownList>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="facultyValidator" ControlToValidate="facultyCombo" runat="server" CssClass="text-danger" ErrorMessage="Faculty field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div>
            <asp:Label ID="Label4" runat="server" Text="Department" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                    <asp:DropDownList ID="departmentCombo" runat="server" CssClass="col-md-10 form-control" AutoPostBack="true" OnSelectedIndexChanged="departmentCombo_SelectedIndexChanged" ></asp:DropDownList>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="departmentValidator" ControlToValidate="departmentCombo" runat="server" CssClass="text-danger" ErrorMessage="Department field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div>
            <asp:Label ID="Label5" runat="server" Text="Programme" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                     
                    <asp:DropDownList ID="programmeCombo" runat="server" CssClass="col-md-10 form-control" ></asp:DropDownList>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="programmeValidator" ControlToValidate="programmeCombo" runat="server" CssClass="text-danger" ErrorMessage="Programme field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div>
                <asp:Label ID="Label6" runat="server" Text="C.G.P.A" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                    <asp:DropDownList ID="cgpaCombo" runat="server" CssClass="col-md-10 form-control" ></asp:DropDownList>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="cgpaValidator" ControlToValidate="cgpaCombo" runat="server" CssClass="text-danger" ErrorMessage="C.G.P.A field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div>
            <asp:Label ID="Label7" runat="server" Text="Purpose" CssClass="control-label" Font-Bold="true" ForeColor="#996600"></asp:Label>
                <div>
                    <asp:TextBox ID="purposeTbx" TextMode="MultiLine" Height="90px" runat="server" CssClass="col-md-12 form-control"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="purposeValidator" ControlToValidate="purposeTbx" runat="server" CssClass="text-danger" ErrorMessage="Purpose field must be filled!!!"></asp:RequiredFieldValidator>
                </div>
            </div>
            <br />
            <asp:Button ID="createBtn" runat="server" Text="Add Candidate" CssClass="form-control" ForeColor="#996600" OnClick="createBtn_Click" />
            <br />
            </div>
        </div>
    </div>
    <div class="row">
        <div class="col-md-12">
            <h3>Status</h3>
            <hr />
            <asp:Label ID="badstatusLabel" runat="server" Text="" CssClass="col-md-12 control-label" ForeColor="Red"></asp:Label>
            <h4>
            <asp:Label ID="goodstatusLabel" runat="server" Text="" Font-Italic="true"  CssClass="col-md-12 control-label" ForeColor="Green"></asp:Label>
            </h4>
        </div>
    </div>
</asp:Content>
