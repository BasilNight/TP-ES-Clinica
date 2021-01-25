<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegistoConsulta.aspx.cs" Inherits="ClinicaAppFrontEnd.RegistoConsulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style4 {
            width: 656px;
            height: 254px;
        }
        .auto-style6 {
            width: 371px;
            height: 254px;
        }
        .auto-style7 {
            width: 545px;
            height: 46px;
        }
        .auto-style8 {
            margin-left: 17px;
        }
        .auto-style9 {
            margin-left: 5px;
        }
        .auto-style10 {
            width: 545px;
            height: 45px;
        }
        .auto-style11 {
            height: 46px;
        }
        .auto-style13 {
            height: 79px;
        }
        .auto-style14 {
            margin-left: 0px;
        }
        .auto-style15 {
            margin-left: 107px;
        }
        .auto-style16 {
            height: 44px;
        }
        .auto-style17 {
            margin-left: 39px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div align="center">
            <asp:Label ID="Label1" runat="server" Text="Agendar uma Consulta" Font-Bold="True" Font-Names="Arial" Font-Overline="True" Font-Size="Large" Font-Underline="True"></asp:Label>
        </div>
        <table align="center">
            <tr>
                <td align="center" class="auto-style6">
                <asp:Calendar ID="Calendar1" runat="server" BackColor="White" BorderColor="Black" BorderStyle="Solid" CellSpacing="1" Font-Names="Verdana" Font-Size="9pt" ForeColor="Black" Height="250px" NextPrevFormat="ShortMonth" Width="330px" OnSelectionChanged="Calendar1_SelectionChanged">
                <DayHeaderStyle Font-Bold="True" Font-Size="8pt" ForeColor="#333333" Height="8pt" />
                <DayStyle BackColor="#CCCCCC" />
                <NextPrevStyle Font-Bold="True" Font-Size="8pt" ForeColor="White" />
                <OtherMonthDayStyle ForeColor="#999999" />
                <SelectedDayStyle BackColor="#333399" ForeColor="White" />
                <TitleStyle BackColor="#333399" BorderStyle="Solid" Font-Bold="True" Font-Size="12pt" ForeColor="White" Height="12pt" />
                <TodayDayStyle BackColor="#999999" ForeColor="White" />
                </asp:Calendar>
                    
                    <br />
                    <asp:Label ID="Label6" runat="server" ForeColor="Red" Text="Data Selecionada Não é Válida" Font-Bold="True" Font-Names="Arial" Font-Underline="True"></asp:Label>
                    
                </td>

                <td class="auto-style4">
                    <table>
                        <tr>
                            <td class="auto-style7">

                                <asp:Label ID="Label3" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Escolha o Local Disponivel Desejado: "></asp:Label>
                                <asp:DropDownList ID="DropDownList2" runat="server" AutoPostBack="true" EnableViewState="true" AppendDataBoundItems="true" Width="169px" OnSelectedIndexChanged="DropDownList2_SelectedIndexChanged" style="height: 22px">
                                </asp:DropDownList>
                                

                            </td>
                        </tr>

                        <tr>
                            <td class="auto-style16">
                                

                                <asp:Label ID="Label2" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Escolha o Fisioterapeuta desejado: "></asp:Label>
                                <asp:DropDownList ID="DropDownList1" runat="server" CssClass="auto-style8" Width="169px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                                </asp:DropDownList>

                            </td>
                        </tr>
                        
                        <tr>
                            <td class="auto-style10">
                                <asp:Label ID="Label7" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Escolha a Hora Disponivel Desejada: "></asp:Label>
                                <asp:DropDownList ID="DropDownList5" runat="server" Width="169px" CssClass="auto-style9" OnSelectedIndexChanged="DropDownList5_SelectedIndexChanged">
                                </asp:DropDownList>
                                

                            </td>
                        </tr>
                        <tr>
                            <td class="auto-style11">

                                <asp:Label ID="Label5" runat="server" Font-Names="Arial" Font-Size="Medium" Text="Escolha o Tratamento desejado: "></asp:Label>
                                <asp:DropDownList ID="DropDownList4" runat="server" CssClass="auto-style17" Width="169px">
                                </asp:DropDownList>

                            </td>
                        </tr>
                    </table>
                </td>
                </tr>
        </table>
        <div align="center">

                    <asp:Label ID="Label8" runat="server" ForeColor="#33CC33" Text="Consulta Marcada com Sucesso" Font-Bold="True" Font-Names="Arial" Font-Underline="True"></asp:Label>
                    
        </div>
        <div align="center">

                    <asp:Label ID="Label9" runat="server" ForeColor="Red" Text="Consulta não foi Marcada" Font-Bold="True" Font-Names="Arial" Font-Underline="True"></asp:Label>
                    
        </div>

        <div align="center" class="auto-style13">

            <br />
            <asp:Button ID="Button1" runat="server" CssClass="auto-style14" Height="34px" Text="Voltar para Menu Principal" Width="168px" />
            <asp:Button ID="Button2" runat="server" CssClass="auto-style15" Height="34px" Text="Confirmar" Width="168px" OnClick="Button2_Click" />

        </div>
    </form>
</body>
</html>
