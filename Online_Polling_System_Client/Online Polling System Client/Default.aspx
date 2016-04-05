<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Online_Polling_System_Client._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div >
    <div class="jumbotron" style="background-image: url('Images/nature001.jpg'); color: #ffffff; " >
        <h1>Welcome!!!</h1>
        <p class="lead" >Elections made Easy & Stress-free</p>
        <p>
            <a href="~/" class="btn btn-primary btn-lg">Learn More</a>            
            <asp:Label ID="Label1" runat="server" Text="Click to Learn how to use"></asp:Label></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Getting started</h2>
            <p>Don't have an account yet, quickly give yourself the oppurtunity to vote and make a difference, getting your account is one click away.</p>
            <p>
            <asp:Button ID="SignUpbutton" runat="server" Text="Sign Up" CssClass="btn btn-default"  ForeColor="#996600" BackColor="White" OnClick="SignUpbutton_Click"/>
            </p>
        </div>

        <div class="col-md-4" >
            <h2>Proceed to Election</h2>
            <p>Already have an Account, waste no time...head on the Polling Booth and start making the choice you think is right</p>
            <p>
            <asp:Button ID="pollbtn" runat="server" Text="Start Voting" CssClass="btn btn-default"  ForeColor="#996600" BackColor="White" OnClick="pollbtn_Click"/>  
            </p>
        </div>

        <div class="col-md-4" >
            <h2>Apply for a Post</h2>
            <p>Register as a Candidate, do you think you have what it takes to be part of the team that will make a difference in the future</p>
            <p>
            <asp:Button ID="applybtn" runat="server" Text="Electoral Form" CssClass="btn btn-default" ForeColor="#996600" BackColor="White" OnClick="applybtn_Click" />
            </p>
        </div>
    </div>
    </div>
    <hr />
    <div class="container">
        <h2 style="text-align:center">Contact Us</h2>
        <hr style="align-self:center; border-color:blue; width:100px;" />
        <h3 style="text-align:center">Leave a Message</h3>
        <br />
        <br />
        <div class="row">
                <div class="col-md-7">
                    <div class="col-md-12">
                        <asp:TextBox ID="nameTbx" TextMode="Search" CssClass="form-control" placeholder="Your Name" runat="server" Width="600px" ></asp:TextBox>  
                    </div>
                    <br />  
                    <div class="col-md-12">
                        <asp:TextBox ID="emailTbx" TextMode="Search" CssClass="form-control" placeholder="Your Email" runat="server" Width="600px" ></asp:TextBox>
				    </div>
                    <br />
					<div class="col-md-12">
						<asp:TextBox ID="subjectTbx" TextMode="Search" CssClass="form-control" placeholder="Your Subject" runat="server" Width="600px" ></asp:TextBox>
					</div>
                    <br />
					<div class="col-md-12">
                        <asp:TextBox ID="messageTbx" TextMode="MultiLine"  CssClass="form-control" placeholder="Message" runat="server" Width="600px" ></asp:TextBox>				
					</div>
                    <br /> 
                        <asp:Button ID="btnsubmit" runat="server" CssClass="btn btn-blue btn-effect" Text="Submit"></asp:Button>
                </div>
                <div class="col-md-5" style="border-left-color: #000000; border-left-width: 1px; border-left-style: outset;">
                    <h3 style="font-weight:bold">Contact Us</h3>	
                    <address class="contact-details">
								<p><i class="fa fa-pencil"></i>Ajayi Crowther University, Oyo <span>PMB 1066</span> <span>Oyo, Nigeria </span></p>
								<p><i class="fa fa-phone"></i>Phone: (234) 8168850433</p>
								<p><i class="fa fa-envelope"></i>senunwah@yahoo.com</p>
					</address>
                </div>
            </div>
    </div>
</asp:Content>
