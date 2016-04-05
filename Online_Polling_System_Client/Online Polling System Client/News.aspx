<%@ Page Title="News" Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="News.aspx.cs" Inherits="Online_Polling_System_Client.News" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %></h2>
    <div class="row">
        <div class="col-md-8">
            <asp:Panel runat="server" CssClass="navbar form-control" BorderColor="#996600" Font-Names="Calibri">
                <div class="navbar">
                    <h1><asp:Label runat="server" CssClass="control-label">Welcome to ACU's first Polling Platform</asp:Label></h1>
                    <hr class="col-md-11" style="border-color:black;"/>
                    <div style="padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:10px;">
                        <asp:Image runat="server" CssClass="col-md-12 " ImageUrl="Images/homepg.png"/>
                    </div>
                    <p style="padding:10px;" >
                        <asp:Label CssClass="control-label" runat="server">
                            The first ever polling site to be built to organise free and fair elections especially the Upcoming Acusa Elections, 
                            all persons interested in the voting exercise will have to register themselves on this portal, and login to start voting. 
                            Aspiring candidates can also purchase OTPIN from the student affairs unit to apply for any post on this website.
                        </asp:Label>
                    </p>
                </div>
            </asp:Panel>
            
            </div>
        <div class="col-md-4">

        </div>
    </div>
    <h3>Your contact page.</h3>
    <address>
        One Microsoft Way<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        425.555.0100
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">Support@example.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@example.com</a>
    </address>
</asp:Content>
