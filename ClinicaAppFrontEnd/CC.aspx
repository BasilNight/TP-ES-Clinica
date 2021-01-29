<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CC.aspx.cs" Inherits="ClinicaAppFrontEnd.CC" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 211px;
        }
        .auto-style2 {
            width: 409px;
            height: 508px;
        }
        .auto-style3 {
            width: 888px;
        }
        .auto-style4 {
            width: 458px;
            height: 508px;
        }
        .auto-style5 {
            margin-bottom: 12px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
           <table cellpadding="4" cellspacing="0" style="border-collapse:collapse; height: 513px; width: 386px;">
            <tr>
                <td class="auto-style2">
                    <table cellpadding="0" class="auto-style4">
                        <tr>
                            <td align="center" colspan="2" bgcolor="#5D7B9D" class="auto-style5">

                                <asp:Label ID="Label1" runat="server" Text="Pagamento" Font-Bold="True" Font-Size="X-Large" Font-Names="Arial" ForeColor="White"></asp:Label>

                            </td>
                        </tr>

            
                        <tr>
                            <td align="center" class="auto-style3">

                                <asp:Label ID="Label4" runat="server" Height="33px" Width="213px" Text="Número do Cartão" Font-Size="17pt" />

                            </td>

                            <td align="left" class="auto-style1">

                                <asp:TextBox ID="TextBox1" runat="server" Height="31px" Width="209px" Font-Size="17pt" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style3">

                                <asp:Label ID="Label5" runat="server" Height="33px" Width="213px" Text="Nome do Titular" Font-Size="17pt" />

                            </td>

                            <td align="left" class="auto-style1">

                                <asp:TextBox ID="TextBox4" runat="server" Height="31px" Width="209px" Font-Size="17pt" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style3">

                                <asp:Label ID="Label3" runat="server" Height="33px" Width="74px" Text="CVV" Font-Size="17pt" />

                            </td>

                            <td align="center" class="auto-style1">

                                <asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="91px" Font-Size="17pt" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style3">

                                <asp:Label ID="Label2" runat="server" Height="33px" Width="74px" Text="Validade" Font-Size="17pt" />

                            </td>

                            <td align="center" class="auto-style1">

                                <asp:TextBox ID="TextBox3" runat="server" Height="33px" Width="74px" Font-Size="17pt" />

                            </td>
                        </tr>
                    </table>
                    <asp:Button ID="Button1" runat="server" CssClass="auto-style5" Height="40px" OnClick="Button1_Click" Text="Continuar" Width="461px" />
                </td>
            </tr>
        </table> 
           <p>
               &nbsp;</p>
    </form>
</body>
</html>
