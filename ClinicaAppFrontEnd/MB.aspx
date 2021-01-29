<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MB.aspx.cs" Inherits="ClinicaAppFrontEnd.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            width: 249px;
        }
        .auto-style4 {
            height: 500px;
            width: 388px;
        }
        .auto-style5 {
            height: 95px;
            width: 249px;
        }
        .auto-style6 {
            width: 232px;
        }
        .auto-style7 {
            width: 212px;
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
                            <td align="right" class="auto-style7">

                                <asp:Label ID="Label4" runat="server" Height="33px" Width="106px" Text="Entidade" Font-Size="17pt" />

                            </td>
                            <td align="left" class="auto-style6">

                                <asp:TextBox ID="TextBox1" runat="server" Height="33px" Text="12255" Width="84px" Font-Size="17pt" ReadOnly="True"/>

                            </td>
                        </tr>
                        <tr>
                            <td align="center" class="auto-style7">

                                <asp:Label ID="Label3" runat="server" Height="33px" Width="74px" Text="Referência" Font-Size="17pt" />

                            </td>

                            <td align="left" class="auto-style6">

                                <asp:TextBox ID="TextBox2" runat="server" Height="31px" Width="166px" Text="858 565 252" Font-Size="17pt" ReadOnly="True" />

                            </td>
                        </tr>
                        <tr>
                            <td align="right" class="auto-style7">

                                <asp:Label ID="Label2" runat="server" Height="33px" Width="74px" Text="Valor" Font-Size="17pt" />

                            </td>

                            <td align="left" class="auto-style3">

                                <asp:TextBox ID="TextBox3" runat="server" Height="33px" Width="74px" Text="30.00" Font-Size="17pt" ReadOnly="True" />

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table> 
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Continuar" Width="394px" />
    </form>
</body>
</html>
