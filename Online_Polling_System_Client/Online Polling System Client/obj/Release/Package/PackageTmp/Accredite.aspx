<%@ Page Title="Accredite Voter" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Accredite.aspx.cs" Inherits="Online_Polling_System_Client.Accredite" %>

<asp:Content ID="BodyCOntent" ContentPlaceHolderID="MainContent" runat="server">
    <div>
        <div class="form-group">
            <h2>Accreditation</h2>
            <h4>We just need to verify if you're a registered voter</h4>
            <br />
            <table style="width: 86%;">
                <tr>
                    <td style="width: 338px">&nbsp;</td>
                    <td style="width: 146px">
            <asp:Label ID="Label1" runat="server" Text="Insert Serial Code" CssClass="control-label" Font-Bold="true"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="serialcodeTbx" runat="server" CssClass="btn btn-default" Height="27px" Width="281px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td style="width: 338px">&nbsp;</td>
                    <td style="width: 146px">&nbsp;</td>
                    <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="serialcodeTbx" ErrorMessage="Insert Serial Code" CssClass="text-danger"></asp:RequiredFieldValidator>
                    <p><asp:Button ID="accreBtn" runat="server" Text="Accredite" CssClass="form-control" BackColor="#009933" ForeColor="White" Width="147px"/></p>
                    </td>
                </tr>
            </table>
            
        </div>

    </div>
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
    <br />
    <br />
    <br />
    <br />
</asp:Content>