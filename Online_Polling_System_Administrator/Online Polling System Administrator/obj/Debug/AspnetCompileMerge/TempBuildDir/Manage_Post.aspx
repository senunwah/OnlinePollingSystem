<%@ Page Title="Manage Post" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Manage_Post.aspx.cs" Inherits="Online_Polling_System_Administrator.Manage_Post" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Manage Electoral Posts</h1>
    <div class="row">
        <div class="col-md-6">
                <h2>Select your Election</h2>
                <h3>Add post's to your selected Election</h3>
                <hr />
                    <br />
                <div class="form-group">
                    <asp:Label ID="Label1" runat="server" Text="Choose Election" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600">Choose Election</asp:Label>
                    <div class="col-md-12">
                        <p style="font-weight: bold">Select the election you want to manage</p>
                        <asp:DropDownList ID="electiondropdown" AutoPostBack="true" Width="300px" runat="server" CssClass="form-control" OnSelectedIndexChanged="electiondropdown_SelectedIndexChanged" ></asp:DropDownList>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="electiondropdown" CssClass="text-danger" ErrorMessage="*You must add an election"></asp:RequiredFieldValidator>
                        <br />
                    </div> 
                </div>
           <h3>Delete Election Post's</h3>
           <hr />
            <br />
            <div class="form-group">
                <asp:Label ID="Label6" runat="server" CssClass="col-md-2 control-label" Font-Bold="true" ForeColor="#996600">Choose Post</asp:Label>
                <div class="col-md-12">
                <p style="font-weight: bold">Select the election post you want to delete</p>
                <asp:DropDownList ID="electionCombo" ViewStateMode="Enabled" EnableViewState="true" AutoPostBack="true" runat="server" CssClass="form-control" Width="300px"></asp:DropDownList>
                <br />
                <asp:Button ID="deletedrpdownBtn"  runat="server" Text="Delete" CssClass="col-md-2 btn btn-default" ForeColor="#996600" OnClick="deletedrpdownBtn_Click"/>
                </div>
            </div>
        </div>
        <div class="col-md-6">
                        
            <h2>Create an Election Post</h2>
            <h3>Add/ Modify election post's for an election</h3>
            <hr />
            <h3>Modify this Post</h3>
            <asp:CheckBox ID="modifycheckbox" AutoPostBack="true" runat="server" Font-Italic="true" Text="click this to enable" CssClass="control-checkbox" OnCheckedChanged="modifycheckbox_CheckedChanged" />
            <br />
            <asp:DropDownList ID="modifypost" ViewStateMode="Enabled" EnableViewState="true" runat="server" CssClass="col-md-8 form-control" AutoPostBack="true" OnSelectedIndexChanged="modifypost_SelectedIndexChanged"></asp:DropDownList>
            <br />
            <br />
            <p>*Ignore "Modify this Post" if you're creating a new post by not selecting any created post</p>               
            <p style="color: red">Be sure to specify properly the post you want to create correctly</p>
            <table style="width: 100%;">
                <tr>
                    <td><asp:Label ID="Label5" runat="server" Text="Election Post" CssClass="col-md-2 control-label" ForeColor="#996600" Font-Bold="true"></asp:Label></td>
                    <td><asp:DropDownList ID="electionPostNamecombo" runat="server" CssClass="form-control" Width="315px"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator4" CssClass="text-danger" ControlToValidate="electionPostNamecombo" runat="server" ErrorMessage="*Election Name Field must be Filled"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label7" runat="server" Text="No_of Candidates" CssClass="col-md-2 control-label" ForeColor="#996600" Font-Bold="true"></asp:Label></td>
                    <td><asp:DropDownList ID="candidateNumbercombo" runat="server" CssClass="form-control"  Width="315px"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" CssClass="text-danger" ControlToValidate="candidateNumbercombo" runat="server" ErrorMessage="*Candidate Number Field must be Filled"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label3" runat="server" Text="Minimum level" CssClass="col-md-2 control-label" ForeColor="#996600" Font-Bold="true"></asp:Label></td>
                    <td><asp:DropDownList ID="minimumlevelcombo" runat="server" CssClass="form-control"  Width="315px"></asp:DropDownList>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" CssClass="text-danger" ControlToValidate="minimumlevelcombo" runat="server" ErrorMessage="*Minimum Level Field must be Filled"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td><asp:Label ID="Label4" runat="server" Text="Minimum CGPA" CssClass="col-md-2 control-label" ForeColor="#996600" Font-Bold="true"></asp:Label></td>
                    <td><asp:DropDownList ID="minimumcgpacombo" runat="server" CssClass="col-md-6 form-control"  Width="315px"></asp:DropDownList>
                    <br />
                    <br />
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator3" CssClass="text-danger" ControlToValidate="minimumcgpacombo" runat="server" ErrorMessage="*Miminum CGPA Field must be Filled"></asp:RequiredFieldValidator>
                    </td>
                    </tr>
            </table> 
            <br>
            <asp:Button ID="createPostBtn"  runat="server" Text="Create Post" CssClass="col-md-3 btn btn-default" ForeColor="#996600" OnClick="createPostBtn_Click" />
            <asp:Button ID="modifyPostBtn" runat="server" Text="Modify Post" CssClass="col-md-3 btn btn-default" ForeColor="#996600" OnClick="modifyPostBtn_Click" />
            <br />
            <br />
            <br />
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
