<%@ Page Title="Polling Booth" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PollingBooth.aspx.cs" Inherits="Online_Polling_System_Client.PollingBooth" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class=" jumbotron" style="background-color: #333333";>
        <table>
            <tr>
                <td>
                    <img src="Images/AcuLogo.png" />
                </td>
                <td style="padding-left:10px">
                    <h1 style="color:white;">Polling Booth</h1>
                    <p class="lead" style="color:white">Vote for your desired Candidate</p>
                    <h6 style="color:white;">You are Logged in as <%: Session["firstname"] %>!</h6>
                    <h6 class="text-danger">*if it is not your name, Kindly Log out</h6>
                </td>
            </tr>
        </table>
    </div>
    <div class="row">
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="PresidentialPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="PostLabel" runat="server" Text="PRESIDENTIAL CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                    <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="VicePresidentialPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label1" runat="server" Text="VICE-PRESIDENTIAL CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="VPLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="VPImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="VPCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="VPLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="VPImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="VPCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="VPLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="VPImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="VPCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="VPLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="VPImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="VPCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="VPLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="VPImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="VPCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                    <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="GenSecPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label2" runat="server" Text="GENERAL SECRETARY CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="GSLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="GSImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="GSCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="GSLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="GSImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="GSCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="GSLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="GSImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="GSCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="GSLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="GSImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="GSCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="GSLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="GSImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="GSCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="AsstGenSecPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label3" runat="server" Text="ASSISTANT GENERAL SECRETARY CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AGSLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AGSImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AGSCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AGSLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AGSImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AGSCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AGSLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AGSImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AGSCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AGSLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AGSImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AGSCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AGSLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AGSImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AGSCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="FinSecPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label4" runat="server" Text="FINANCIAL SECRETARY CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="FSLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="FSImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="FSCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="FSLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="FSImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="FSCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="FSLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="FSImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="FSCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="FSLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="FSImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="FSCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="FSLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="FSImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="FSCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="TreasurerPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label5" runat="server" Text="TREASURER CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="TLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="TImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="TCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="TLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="TImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="TCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="TLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="TImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="TCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="TLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="TImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="TCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="TLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="TImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="TCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="AcadOffPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label6" runat="server" Text="ACADEMIC OFFICER CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AOCLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AOCImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AOCCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AOCLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AOCImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AOCCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AOCLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AOCImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AOCCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AOCLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AOCImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AOCCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="AOCLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="AOCImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="AOCCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="SportsOffPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label7" runat="server" Text="SPORT OFFICER CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SOLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SOImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SOCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SOLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SOImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SOCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SOLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SOImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SOCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SOLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SOImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SOCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SOLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SOImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SOCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="WelfOffPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label8" runat="server" Text="WELFARE OFFICER CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="WOLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="WOImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="WOCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="WOLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="WOImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="WOCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="WOLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="WOImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="WOCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="WOLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="WOImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="WOCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="WOLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="WOImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="WOCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="PROPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label9" runat="server" Text="PUBLIC RELATIONS OFFICER CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PRLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PRImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PRCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PRLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PRImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PRCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PRLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PRImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PRCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PRLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PRImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PRCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="PRLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="PRImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="PRCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="SocDirPanel" CssClass="navbar form-control">
                <h2><asp:Label ID="Label10" runat="server" Text="SOCIAL DIRECTOR CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SDLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SDImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SDCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SDLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SDImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SDCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SDLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SDImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SDCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SDLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SDImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SDCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="SDLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="SDImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="SDCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="JAHHR" CssClass="navbar form-control">
                <h2><asp:Label ID="Label11" runat="server" Text="HALL REP (JOSEPH ADETILOYE HALL) CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="JAHLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="JAHImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="JAHCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="JAHLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="JAHImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="JAHCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="JAHLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="JAHImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="JAHCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="JAHLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="JAHImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="JAHCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="JAHLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="JAHImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="JAHCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="IBHR" CssClass="navbar form-control">
                <h2><asp:Label ID="Label12" runat="server" Text="HALL REP (JASPER AKINOLA HALL) CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="IBLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="IBImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="IBCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="IBLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="IBImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="IBCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="IBLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="IBImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="IBCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="IBLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="IBImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="IBCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="IBLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="IBImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="IBCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="LAGHR" CssClass="navbar form-control">
                <h2><asp:Label ID="Label13" runat="server" Text="HALL REP (DIOCESE OF LAGOS HOSTEL) CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LGLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LGImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LGCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LGLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LGImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LGCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LGLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LGImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LGCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LGLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LGImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LGCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LGLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LGImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LGCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="DLWHR" CssClass="navbar form-control">
                <h2><asp:Label ID="Label14" runat="server" Text="HALL REP (DIOCESE OF LAGOS WEST HOSTEL) CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LWLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LWImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LWCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LWLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LWImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LWCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LWLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LWImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LWCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LWLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LWImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LWCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="LWLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="LWImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="LWCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
        <div class="col-md-12">
            <asp:Panel runat="server" BorderColor="#996600" ID="UFHHR" CssClass="navbar form-control">
                <h2><asp:Label ID="Label15" runat="server" Text="HALL REP (UNIVERSITY FEMALE HOSTEL) CANDIDATES"></asp:Label></h2>
                <p>Click the link below the button to view candidate details</p>
                <hr class="col-md-11" style="border-color:black;" />
                <div class="form-group">
                <table style="text-align:center">
                    <tr>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="UFHLabel1" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="UFHImage1" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="UFHCandidate1" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="UFHLabel2" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="UFHImage2" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="UFHCandidate2" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="UFHLabel3" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="UFHImage3" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="UFHCandidate3" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="UFHLabel4" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="UFHImage4" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="UFHCandidate4" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                        <td style="width: 150px; padding-left:10px; padding-right:10px; padding-top:10px; padding-bottom:20px;">
                            <asp:Label ID="UFHLabel5" runat="server" Text="Unknown"></asp:Label>
                            <br />
                            <asp:Image ID="UFHImage5" runat="server" ImageUrl="Images/DefaultImage.png" Width="150" Height="150"/>
                            <br />
                            <br />
                            <asp:CheckBox ID="UFHCandidate5" AutoPostBack="true" runat="server" CssClass="form-control" />
                        </td>
                    </tr>
                </table>
                <a class="btn btn-primary btn-lg">View Candidate Profile</a>
            </div>
            </asp:Panel>
        </div>
    </div>
    <hr class="col-md-12" style="border-color:black;" />
    <div class="row">
        <div class="col-md-12">
            <p>Be sure to have completed the voting exercise before Clicking on the Finalize button</p>
            <asp:Button ID="Button17" runat="server" Text="Finalize Voting Exercise" CssClass="btn btn-default"  BackColor="White" ForeColor="#996600"/>
        </div>
    </div>
</asp:Content>
