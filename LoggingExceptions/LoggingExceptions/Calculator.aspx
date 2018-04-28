<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="LoggingExceptions.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style4 {
            height: 33px;
        }
        .auto-style5 {
            width: 153px;
        }
        .auto-style6 {
            height: 33px;
            width: 153px;
        }
        .auto-style7 {
            width: 191px;
        }
        .auto-style8 {
            height: 33px;
            width: 191px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table class="auto-style1">
            <tr>
                <td class="auto-style7">
                    <asp:Label ID="Label1" runat="server" Text="Enter 1st Number"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:TextBox ID="txtFirst" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;<asp:Button ID="btnMultiply" runat="server" OnClick="btnMultiply_Click" Text="Multiply" Width="93px" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblMultiply" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    <asp:Label ID="Label2" runat="server" Text="Enter 2nd Number"></asp:Label>
                </td>
                <td class="auto-style6">
                    <asp:TextBox ID="txtSecond" runat="server"></asp:TextBox>
                </td>
                <td class="auto-style4">&nbsp;<asp:Button ID="btnDivide" runat="server" OnClick="btnDivide_Click" Text="Divide" Width="93px" />
                    &nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblDivide" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;&nbsp; &nbsp;<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="93px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblAdd" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Button ID="btnSubstract" runat="server" OnClick="btnSubstract_Click" Text="Substract" Width="93px" />
&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblSubstract" runat="server"></asp:Label>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; </td>
            </tr>
            <tr>
                <td class="auto-style4" colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="lblError" runat="server"></asp:Label>
                    &nbsp;</td>
                <td class="auto-style4"></td>
            </tr>
            <tr>
                <td class="auto-style7">&nbsp;</td>
                <td class="auto-style5">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
