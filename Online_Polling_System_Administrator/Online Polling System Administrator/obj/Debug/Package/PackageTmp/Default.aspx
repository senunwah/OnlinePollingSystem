<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Online_Polling_System_Administrator._Default" %>
<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="jumbotron" style="background-image: url('/Images/fundos.jpg'); color: #FFFFFF;">
        <h1>Poll Admin</h1>
        <p class="lead">Here, you can create and manage elections, create electoral posts and add candidates to election Modules.</p>
        <p><a href="~/" class="btn btn-primary btn-lg" >Learn more &raquo;</a></p>
    </div>

    <div class="row">
        <div class="col-md-4">
            <h2>Manage Elections </h2>
            <p>Setup a new election platform or modify/delete an old one. This is the first step to the management of a new voting exercise.</p>
            <p>
                <asp:Button ID="newelectionBtn" OnClick="newelectionBtn_Click" runat="server" Text="Manage Elections" CssClass="btn btn-default" ForeColor="#996600" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Manage Electoral Posts</h2>
            <p>
                Create electoral posts for each election module the posts that the candidates will be running for in the polling exercise.
            </p>
            <p>
                <asp:Button ID="electoralpostBtn" OnClick="electoralpostBtn_Click" runat="server" Text="Manage Election Posts" CssClass="btn btn-default" ForeColor="#996600"  /> 
            </p>
        </div>
        <div class="col-md-4">
            <h2>Manage Candidates</h2>
            <p>
                Add new or modify/delete candidates for any of the election modules. Be sure to correctly allocate any new candidate to the appropraite election module.
            </p>
            <p>
                <asp:Button  OnClick="addcandidateBtn_Click" ID="addcandidateBtn" runat="server" Text="Manage Candidates" CssClass="btn btn-default" ForeColor="#996600" />
            </p>
        </div>
    </div>
    <div class="row">
        <div class="col-md-4">
            <h2>Election Overview</h2>
            <p>View and generate election results, have a glimpse of your ongoing election status</p>
            <p>
                <asp:Button ID="electionoverviewbtn" OnClick="electionoverviewbtn_Click" runat="server" Text="Election Overview" CssClass="btn btn-default" ForeColor="#996600" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>New Candidate</h2>
            <p>Create an entirely new candidate and add to an election, select post's as well & add Images</p>
            <p>
                <asp:Button ID="newcandidatebtn" OnClick="newcandidatebtn_Click" runat="server" Text="New Candidate" CssClass="btn btn-default" ForeColor="#996600" />
            </p>
        </div>
        <div class="col-md-4">
            <h2>Create New Admin</h2>
            <p>Add a new Admin User to this Portal, only an admin user can create a new admin</p>
            <p>
                <asp:Button ID="newadminbtn" PostBackUrl="~/Account/Register.aspx" OnClick="newadminbtn_Click" runat="server" Text="New Admin" CssClass="btn btn-default" ForeColor="#996600" />
            </p>
        </div>
    </div>
    <br />
    <br />
    <hr style="background-color:#0e4c6c" />
    <div class="container">
        <h2 style="text-align:center">Contact Us</h2>
        <hr style="align-self:center; width:100px; color:blue;" />
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
