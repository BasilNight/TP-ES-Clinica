<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MetodoPagamento.aspx.cs" Inherits="ClinicaAppFrontEnd.MetodoPagamento" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 90px;
        }
        .auto-style2 {
            width: 171px;
        }
        .auto-style4 {
            height: 513px;
            width: 386px;
        }
        .auto-style5 {
            width: 227px;
        }
        .auto-style6 {
            width: 227px;
            height: 211px;
        }
        .auto-style7 {
            margin-left: 0px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
         <table cellpadding="4" cellspacing="0" style="border-collapse:collapse; " class="auto-style4">
                <td class="auto-style2">
                    <table cellpadding="0" class="auto-style4">
                        <tr>
                            <td align="center" colspan="2" bgcolor="#5D7B9D" class="auto-style1">

                                <asp:Label ID="Label1" runat="server" Text="Pagamento" Font-Bold="True" Font-Size="X-Large" Font-Names="Arial" ForeColor="White"></asp:Label>

                            </td>
                        </tr>

            
                        <tr>
                            <td align="center" class="auto-style6">

                                <asp:Button ID="Button1" runat="server" Height="210px" Width="379px" Text="Multibanco" Font-Size="17pt" OnClick="Button1_Click" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style5">

                                <asp:Button ID="Button2" runat="server" Height="210px" Width="379px" Text="Cartão de Crédito" Font-Size="17pt" align="center" OnClick="Button2_Click"/>

                                <br />
                                <asp:Button ID="Button3" runat="server" CssClass="auto-style7" OnClick="Button3_Click" Text="Cancelar" Width="379px" />

                            </td>
                        </tr>
                    </table>
                </td>
        </table> 
    </form>
</body>
</html>
