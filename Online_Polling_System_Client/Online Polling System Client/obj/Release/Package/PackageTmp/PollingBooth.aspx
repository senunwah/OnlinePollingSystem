<%@ Page Title="Polling Booth" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PollingBooth.aspx.cs" Inherits="Online_Polling_System_Client.PollingBooth" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="jumbotron" style="background-image: url('http://localhost:49574/Image/green-stripe-background.jpg'); color: #FFFFFF;"> 
    <h1>Polling Booth</h1>
    </div>
    <h3>Vote for your desired Candidate</h3>
    <div class="row">
        <div class="col-md-12">
            <h2><asp:Label ID="PostLabel" runat="server" Text="PRESIDENTIAL CANDIDATES"></asp:Label></h2>
            <p>
            <p>Click the link below the button to view candidate details</p>
           <div class="form-group">
              <asp:Image ID="Image1" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button1" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
              <asp:Image ID="Image3" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button3" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
              <asp:Image ID="Image2" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button2" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
              <asp:Image ID="Image4" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button4" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
            </div>
            <p>
              _________________________________________________________________________________________________________
            </p>
        </div>
        </div>
    <div class="row">
        <div class="col-md-"10">
            <h2>
            <asp:Label ID="Label1" runat="server" Text="VICE-PRESIDENTIAL CANDIDATES"></asp:Label>
            </h2>
            <p>
                Click the link below the button to view candidate details
            </p>
              <asp:Image ID="Image5" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button5" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image6" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button6" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image7" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button7" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image8" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button8" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
            <p>
              ________________________________________________________________________________________________________
            </p>
        </div>
        </div>
    <div class="row">
        <div class="col-md-"10">
            <h2>
            <asp:Label ID="Label2" runat="server" Text="GENERAL SECRETARY CANDIDATES"></asp:Label>
            </h2>
            <p>
                Click the link below the button to view candidate details
            </p>
              <asp:Image ID="Image9" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button9" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image10" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button10" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image11" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button11" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image12" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button12" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
            <p>
              ________________________________________________________________________________________________________
            </p>
        </div>
        </div>
    <div class="row">
        <div class="col-md-"10">
            <h2>
            <asp:Label ID="Label3" runat="server" Text="ASSISTANT GENERAL SECRETARY CANDIDATES"></asp:Label>
            </h2>
            <p>
                Click the link below the button to view candidate details
            </p>
              <asp:Image ID="Image13" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button13" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image14" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button14" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image15" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button15" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
                <asp:Image ID="Image16" runat="server" ImageUrl="Image/logo.jpg" Width="150" Height="150"/>
              <asp:Button ID="Button16" runat="server" Text="VOTE" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
            <p>
              ________________________________________________________________________________________________________
            </p>
        </div>
        <div class="row">
        <div class="col-md-12">
            <p>Be sure to have completed the voting exercise before Clicking on the Finalize button</p>
            <asp:Button ID="Button17" runat="server" Text="Finalize Voting Exercise" CssClass="btn btn-default"  BackColor="#009933" ForeColor="White"/>
        </div>



        </div>
        </div>
</asp:Content>
