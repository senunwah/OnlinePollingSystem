<%@ Page Title="Candidateform" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Candidateform.aspx.cs" Inherits="Online_Polling_System_Client.Candidateform" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <h2>Candidate Application Form</h2>
    <div class="col-md-6">
            <h2>Add Candidates to Election Module</h2>
            <h3>Select Election Module:</h3>
                <p>
                <asp:DropDownList ID="DropDownList1" runat="server" Height="19px" Width="394px" CssClass="form-control"></asp:DropDownList>
                </p>
            <div>
                <table style="width: 83%;">
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label1" runat="server" Text="Candidate Name" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="candidateNameTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="candidateNameTbx" ID="RequiredFieldValidator1" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator>   
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label2" runat="server" Text="Matric No" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="matricTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                        <asp:RequiredFieldValidator ControlToValidate="matricTbx" ID="RequiredFieldValidator2" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label3" runat="server" Text="Faculty" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="facultyTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="facultyTbx" ID="RequiredFieldValidator3" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label4" runat="server" Text="Department" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="departmentTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="departmentTbx" ID="RequiredFieldValidator4" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label5" runat="server" Text="Programme" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="programmeTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="programmeTbx" ID="RequiredFieldValidator5" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                            <asp:Label ID="Label8" runat="server" Text="Post" Font-Bold="true"></asp:Label>
                            </td>
                        <td>
                            <asp:TextBox ID="postTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="postTbx" ID="RequiredFieldValidator6" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label6" runat="server" Text="CGPA" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="cgpaTbx" runat="server" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="cgpaTbx" ID="RequiredFieldValidator7" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                    <tr>
                        <td style="width: 190px">
                    <asp:Label ID="Label7" runat="server" Text="Purpose" Font-Bold="true"></asp:Label>
                        </td>
                        <td>
                    <asp:TextBox ID="purposeTbx" runat="server" Height="64px" Width="460px" CssClass="form-control"></asp:TextBox>
                            <asp:RequiredFieldValidator ControlToValidate="purposeTbx" ID="RequiredFieldValidator8" runat="server" ErrorMessage="Candidate Name Required"></asp:RequiredFieldValidator> 
                        </td>
                    </tr>
                </table>
            </div>
        
        
            </div>
        
            <div class="col-md-6">
            <div class="form-group">
                <h2>Upload Image</h2>
                <table style="width: 100%;">
                        <tr>
                            <td style="width: 135px">
                    <asp:Image ID="Image1" runat="server" Height="140px" Width="124px" BackColor="#009933" CssClass="form-control"/>
                            </td>
                            <td>
                   <asp:FileUpload ID="FileUpload1" runat="server" CssClass="form-control"/>
                   <asp:Button ID="FileUploadBtn" runat="server" Text="Upload File" CssClass="btn btn-default" BackColor="#009933" ForeColor="#ffffff"/>
                            </td>
                        </tr>
                    </table>
            </div>
            </div>
    
    <div>        
    <div class="col-md-6">  
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
        <p>
            ___________________________________________________________________________________________________________________________________
        </p>
        <p>
            *Click this only after you have finished filling your application
            </p>
        <p>
           <asp:Button ID="addCandidateBtn" runat="server" Text="Add Candidate"  CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
          </p>
        </div>
        
</asp:Content>

