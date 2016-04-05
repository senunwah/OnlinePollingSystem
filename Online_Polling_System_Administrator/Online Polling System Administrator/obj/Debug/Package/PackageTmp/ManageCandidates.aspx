<%@ Page Title="Manage Candidates" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ManageCandidates.aspx.cs" Inherits="Online_Polling_System_Administrator.ManageCandidates" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Manage Candidates</h1>
    <div class="row">
        <div class="col-md-6" >
            <h2 >Select Election Details</h2>
            <h3 >Choose your Election:</h3>
            <hr />
            <br />
            <div class="form-group">
                <asp:Label ID="Label8" runat="server" Text="Choose Election" Font-Bold="true" ForeColor="#996600" CssClass="col-md-3 control-label"></asp:Label>
                <p style="font-weight:bold">Select the election you want to manage</p>
                <asp:DropDownList ID="electionCombo" runat="server" CssClass="form-control" Width="300px" OnSelectedIndexChanged="electionCombo_SelectedIndexChanged" AutoPostBack="true"></asp:DropDownList>
            </div>
            <br />
            <br />
            <h3 >Select Election Post</h3>
            <hr />
            <br />
            <div class="form-group">
                <asp:Label ID="Label9" runat="server" Text="Choose Post" Font-Bold="true" ForeColor="#996600" CssClass="col-md-3 control-label"></asp:Label>
                <asp:DropDownList ID="postCombo" runat="server" CssClass="form-control" Width="300px" AutoPostBack="true" OnSelectedIndexChanged="postCombo_SelectedIndexChanged"></asp:DropDownList>
            </div>
            <br />
            <br />
            <br />
            <br />
            <h3>View Candidate Image</h3>
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
            <h2>Select Candidate</h2>
            <h3>Edit Candidate Details</h3>
            <hr />
            <br />
            <div class="form-group">
                <asp:Label ID="Label10" runat="server" Text="Select Candidate" Font-Bold="true" ForeColor="#996600" CssClass="col-md-3 control-label"></asp:Label>
                <p style="font-weight:bold">Select the candidate you want to manage</p>
                <asp:DropDownList ID="candidateCombo" AutoPostBack="true" runat="server" Width="300px" CssClass="form-control" OnSelectedIndexChanged="candidateCombo_SelectedIndexChanged"></asp:DropDownList>
                <br />
                <p class="col-md-12" style="color:red">Cannot find candidate, create a new one <a href="NewCandidate.aspx">here</a></p>
                <hr />
                <p style="color:red">*Be sure to specify the candidate details correctly before saving</p>
                <br />
            </div>
            <div class="form-group">
                <asp:Label ID="Label1" runat="server" Text="Candidate Name" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="candidatenameTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:Label ID="Label2" runat="server" Text="Matric No" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="matricnoTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:Label ID="Label3" runat="server" Text="Faculty" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="facultyTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:Label ID="Label4" runat="server" Text="Department" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="departmentTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
             <div class="form-group">
                <asp:Label ID="Label5" runat="server" Text="Programme" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="programmeTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
             <div class="form-group">
                <asp:Label ID="Label6" runat="server" Text="CGPA" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="cgpaTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:Label ID="Label7" runat="server" Text="Purpose" Font-Bold="true" CssClass="col-md-3 control-label" ForeColor="#996600"></asp:Label>
                <asp:TextBox ID="purposeTbx" runat="server" CssClass="form-control" Width="300px"></asp:TextBox>
                <br />
            </div>
            <div class="form-group">
                <asp:Button ID="modifybtn" runat="server" Text="Modify" CssClass="btn btn-default" ForeColor="#996600" OnClick="modifybtn_Click" />
                <asp:Button ID="clearbtn" runat="server" Text="Clear" CssClass="btn btn-default" ForeColor="#996600" OnClick="clearbtn_Click" />
            </div>
       </div>
    </div>
    <div class="col-md-12">
            <h3>Status</h3>
            <hr />
            <asp:Label ID="badstatusLabel" runat="server" Text="" CssClass="col-md-12 control-label" ForeColor="Red"></asp:Label>
            <h4>
            <asp:Label ID="goodstatusLabel" runat="server" Text="" Font-Italic="true"  CssClass="col-md-12 control-label" ForeColor="Green"></asp:Label>
            </h4>
        </div>
     
   
     
</asp:Content>
