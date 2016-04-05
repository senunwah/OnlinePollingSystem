<%@ Page Title="Election Overview" MasterPageFile="~/Site.Master" Language="C#" AutoEventWireup="true" CodeBehind="ElectionOverview.aspx.cs" Inherits="Online_Polling_System_Administrator.ElectionOverview" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Election Overview</h1>
    <div class="row">
        <div class="col-md-6">
            <h2>Publish your Election</h2>
            <h4>Set the Date/ Time Duration</h4>
            <hr />

            <div class="form-group">
                <p style="color:#996600; font-weight:bold;">Select Election</p>
                <div>
                    <asp:DropDownList ID="electionDrp" runat="server" Width="300px" CssClass="form-control"></asp:DropDownList>
                </div>
                <br />
                <br />
            </div>
            <div class="form-group">
                <p style="color:#996600; font-weight:bold;">Set Date</p>
                <table>
                    <tr>
                        <td style="text-align:center; padding-left:10px; padding-right:10px;">
                            From
                            <asp:Calendar ID="startDatecalendar" runat="server" CssClass="form-control" Width="230px"></asp:Calendar>
                        </td>
                        <td style="text-align:center; padding-left:10px; padding-right:10px;">
                            To
                            <asp:Calendar ID="finishDatecalendar" runat="server" CssClass="form-control" Width="230px"></asp:Calendar>
                        </td>
                    </tr>
                </table>
                <br />
                <br />
            </div>
            <div class="form-group">
                <p style="color:#996600; font-weight:bold;">Set Time</p>
                <div class="form-group">
                    <table>
                        <tr>
                            <td style="text-align:center; padding-left:10px; padding-right:10px;">
                                Start Time
                                <br />
                                <asp:TextBox ID="TextBox1" TextMode="Time" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                            <td style="text-align:center; padding-left:10px; padding-right:10px;">
                                Finish Time
                                <br />
                                <asp:TextBox ID="TextBox2" TextMode="Time" CssClass="form-control" runat="server"></asp:TextBox>
                            </td>
                        </tr>
                    </table>
                </div> 
            </div>
           
            <hr />
            <p>Be sure to have cross-checked your settings before Finalizing</p>
            <asp:Button ID="finalizebutton" OnClick="finalizebutton_Click" runat="server" Text="Finalize Settings" CssClass="btn btn-default" ForeColor="#996600"/>
            <p style="color:red">*All changes made here will delete any previous settings and create a new one</p>
        </div>
        <div class="col-md-6">
            <h2>Manage Live Election</h2>
            <h4>View Election Status</h4>
            <hr />
            <div class="form-group" title="Miscelleanouses">
                <div class="form-group">
                    <p style="color:#996600; font-weight:bold;">Select Election</p>
                    <asp:DropDownList Enabled="false" runat="server" CssClass="form-control" Width="300px" ID="electiondrp2" ></asp:DropDownList>
                    <br />
                </div>
                <div class="form-group">
                    <p style="color:#996600; font-weight:bold;">Log Candidate out</p>
                    <div>
                        <asp:DropDownList runat="server" CssClass="form-control" Width="400px" ID="DropDownList1" ></asp:DropDownList>
                        <br />
                        <asp:Button ID="logoutbtn" Text="Log Out" ForeColor="#996600" CssClass="btn btn-default" runat="server"/>
                    </div>
                    <br />
                </div>
                <div class="form-group">
                    <p style="color:#996600; font-weight:bold;">Block Candidate</p>
                    <div>
                        <asp:DropDownList runat="server" CssClass="form-control" Width="400px" ID="DropDownList2" ></asp:DropDownList>
                        <br />
                        <asp:Button ID="Button2" Text="Block" ForeColor="#996600" CssClass="btn btn-default" runat="server"/>
                    </div>
                    <br />
                </div>
                <div class="form-group">
                    <p style="color:#996600; font-weight:bold;">Unblock Candidate</p>
                    <div>
                        <asp:DropDownList runat="server" CssClass="form-control" Width="400px" ID="DropDownList3" ></asp:DropDownList>
                        <br /> 
                        <asp:Button ID="Button3" Text="Block" ForeColor="#996600" CssClass="btn btn-default" runat="server"/>  
                    </div>
                    <br />
                </div>
                
                <div>
                    <p style="color:red;">*To check polling results, view current election results</p>
                    <li><a class="btn btn-primary btn-lg" href="ReportSheet.aspx">Generate Election Report</a></li>
                </div>
               
            </div>
            
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