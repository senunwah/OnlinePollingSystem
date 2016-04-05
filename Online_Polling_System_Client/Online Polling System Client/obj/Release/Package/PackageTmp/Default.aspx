<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Online_Polling_System_Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div >
    <div class="jumbotron" style="background-image: url('Images/nature001.jpg'); color: #ffffff; " >
        <h1>Welcome!!!</h1>
        <p class="lead" >Elections made Easy & Stress-free</p>
        <p><asp:Button ID="Button1" runat="server" Text="Learn more" CssClass="btn btn-default" ForeColor="White" BackColor="#009933" Height="48px" Width="143px" OnClick="Button1_Click1" />
            
            <asp:Label ID="Label1" runat="server" Text="Click to Learn how to use"></asp:Label></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <h4>Don't have an account yet
            </h4>
            <p>
            <asp:Button ID="SignUpbutton" runat="server" Text="Sign Up"  PostBackUrl="Account/Register.aspx" CssClass="btn btn-default"  ForeColor="White" BackColor="#009933" OnClick="SignUpbutton_Click"/>
            </p>
        </div>

        <div class="col-md-4" >
            <h2>Proceed to Election</h2>
            <h4>Already have an Account
            
            </h4>
            <p>
            <asp:Button ID="Button2" runat="server" Text="Sign In" CssClass="btn btn-default" PostBackUrl="Account/Login.aspx"  ForeColor="White" BackColor="#009933" OnClick="Button2_Click"/>  

            </p>
        </div>

        <div class="col-md-4" >
            <h2>Apply for a Post</h2>
            <h4>Register as a Candidate
            </h4>
            <p>
            <asp:Button ID="Button3" runat="server" Text="Electoral Form" CssClass="btn btn-default" PostBackUrl="~/OTPIN.aspx"  ForeColor="White" BackColor="#009933" OnClick="Button3_Click" />
            </p>
        </div>

    </div>
        
        </div>
    
</asp:Content>
