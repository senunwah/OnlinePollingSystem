<%@ Page Title="Register" Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" MasterPageFile="~/Site.Master" Inherits="Online_Polling_System_Client.Account.Register" %>

<asp:Content runat ="server" ContentPlaceHolderID="MainContent">
    <br />
    <br />
    <asp:Panel runat="server" CssClass="navbar" >
    <div class="row">
        <div class="col-md-3"></div>
        <div class="col-md-6 form-horizontal" style="text-align:center;">
            <h1 style="font-family:Calibri;"><%: Title %></h1>
            <hr style="border-color:#0094ff" />
            <p>Input Registration Details</p>
            <div style="padding-left:40px;">
            <div class="form-group">
                <asp:Label runat="server" CssClass="col-md-4 control-label" Font-Size="Large" ForeColor="#996600">Matric No</asp:Label>
                <div class="col-md-12" style="text-align:center;">
                    
                    <asp:DropDownList ID="yearcombo" runat="server" Font-Size="Large" CssClass="col-md-2 control-label"></asp:DropDownList>
                    <asp:DropDownList ID="facultyinitialcombo" Font-Size="Large" runat="server" CssClass="col-md-2 control-label"></asp:DropDownList>
                    <asp:DropDownList ID="Programmeserialno" Font-Size="Large" runat="server" CssClass="col-md-2 control-label"></asp:DropDownList>
                    <asp:DropDownList ID="serialnocombo" Font-Size="Large" runat="server" CssClass="col-md-2 control-label"></asp:DropDownList>
                    
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12" style="border-color:black;">
                    <br />
                    <p style="color:red;">Click the generate system password for your account</p>
                    <br />
                    <asp:Label runat="server" ID="PasswordLabel" Font-Size="XX-Large" ForeColor="Green" Font-Names="Calibri" CssClass="col-md-12 control-label"></asp:Label>
                    <br />
                    <br />
                    <asp:Button runat="server" ID="generatebtn" CssClass=" btn" OnClick="generatebtn_Click" Text="Generate Password" />
                    <p style="color:red;">Click to generate a new password if you don't like it</p>
                </div>
            </div>
            <div class="form-group">
                <div class="col-md-12">
                    <asp:Button runat="server" ID="Registerbtn" CssClass="btn btn-primary btn-lg" Text="Register" OnClick="Registerbtn_Click" /> 
                </div>
            </div>
            </div>
                   
        </div>
        <div class="col-md-3"></div>
    </div>
    </asp:Panel>
    <asp:Panel runat="server" CssClass="navbar">

    </asp:Panel>
    
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

</asp:Content>