<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CreateEventViewer.aspx.cs" Inherits="LoggingExceptions.CreateEventViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 222px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="EventLog Name"></asp:Label>
                </td>
                <td>&nbsp;<asp:TextBox ID="txtName" runat="server"></asp:TextBox>
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="EventLog Source"></asp:Label>
                </td>
                <td>&nbsp;<asp:TextBox ID="txtSource" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Create Event Viewer" Width="209px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblEventSuccess" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    <div>
    
    </div>
    </form>
</body>
</html>
