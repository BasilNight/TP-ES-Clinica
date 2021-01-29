<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="ClinicaAppFrontEnd.MenuPrincipal" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>
    </title>
    <style type="text/css">
        .auto-style1 {
            height: 57px;
        }
        .auto-style2 {
            width: 209px;
        }
        .auto-style3 {
            height: 48px;
        }
        .auto-style4 {
            height: 350px;
            width: 254px;
            margin-right: 14px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
            <tr>
                <td class="auto-style2">
                    <table cellpadding="0" class="auto-style4">
                        <tr>
                            <td align="center" colspan="2" bgcolor="#5D7B9D" class="auto-style1">

                                <asp:Label ID="Label1" runat="server" Text="Menu Principal" Font-Bold="True" Font-Size="X-Large" Font-Names="Arial" ForeColor="White"></asp:Label>

                            </td>
                        </tr>

                        <tr>
                            <td style="color:black;font-weight:bold;font-size:1.2em;" class="auto-style3">

                                <asp:Label ID="Label2" runat="server" Text="Bem Vindo" Font-Names="Arial"></asp:Label>

                            </td>
                        </tr>

                        <tr>
                            <td align="center">

                                <asp:Button ID="Button1" runat="server" Height="46px" Text="Agendar uma Consulta" Width="164px" OnClick="Button1_Click" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center">

                                <asp:Button ID="Button2" runat="server" Height="46px" Width="164px" Text="Histórico de Consultas" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center">

                                <asp:Button ID="Button3" runat="server" Height="46px" Width="164px" Text="Outra Função" />

                            </td>
                        </tr>
                        <tr>
                            <td align="center">

                                <asp:Button ID="Button4" runat="server" Height="46px" Width="164px" Text="Log Out" OnClick="Button4_Click" />

                            </td>
                        </tr>
                    </table>
                </td>
            </tr>
        </table> 
        <div>
        </div>
    </form>
</body>
</html>
    
