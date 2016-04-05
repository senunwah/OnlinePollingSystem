<%@ Page Title="Manage Elections" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Manage_elections.aspx.cs" Inherits="Online_Polling_System_Administrator.Manage_elections" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Manage Elections</h1>   
    <div class="row" >
        <div class="col-md-6">
                    <h2>Create a new election</h2>
                    <h4>Type in the name of the new election you want to manage</h4>
                    <hr />
            
                <p style="color: #996600">Name</p>
                <div>
                    <asp:TextBox ID="electionTbx" runat="server" placeholder="Input election name" CssClass="col-md-12 form-control"></asp:TextBox>
                <br />
                <br />
                <asp:Button ID="newelectionBtn" runat="server" Text="Create" CssClass="btn btn-default" ForeColor="#996600" OnClick="newelectionBtn_Click" />
                </div>
                <br />
                <p style="color:red">*Creating a new election creates a new database for you to manage</p>
                <br />
        </div>
        <div class="col-md-6">
                    <h2>Managed Elections</h2>
                    <h4>You can add/delete/Modify existing and new elections</h4>
                    <hr />
                    <p style="color: #FF0000">*if your new database does not appear here yet, try again!!!</p>
                    <br />
                <div class="form-group">
                    <p style="color: #996600">Select Election</p>
                    <asp:DropDownList ID="electionCombo" runat="server" CssClass="col-md-8 form-control" ></asp:DropDownList>
                    <br />
                    
                </div>
                    <br />
                        <asp:Button ID="deleteBtn" runat="server" Text="Delete" CssClass="col-md-2 form-control" ForeColor="#996600" OnClick="deleteBtn_Click" />
            <br />
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
            <asp:Label ID="goodstatusLabel" runat="server" Text="" CssClass="col-md-12 control-label" ForeColor="Green"></asp:Label>
            </h4>
        </div>
    </div>
</asp:Content>