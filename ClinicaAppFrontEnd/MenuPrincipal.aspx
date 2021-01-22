<%@ Page Language="C#"  AutoEventWireup="true" CodeBehind="MenuPrincipal.aspx.cs" Inherits="ClinicaAppFrontEnd.MenuPrincipal" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>
    </title>
    <style type="text/css">
        .auto-style1 {
            height: 42px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
            <tr>
                <td>
                    <table cellpadding="0" style="height:206px; width:201px;">
                        <tr>
                            <td colspan="2" class="auto-style1">

                                <asp:Label ID="Label1" runat="server" Text="Menu Principal"></asp:Label>

                            </td>
                        </tr>

                        <tr>
                            <td style="color:black;font-weight:bold;font-size:1.2em;">

                                <asp:Label ID="Label2" runat="server" Text="Bem Vindo"></asp:Label>

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
                    </table>
                </td>
            </tr>
        </table> 
        <div>
        </div>
    </form>
</body>
</html>
    
