<%@ Page Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="RegisterForm.aspx.cs" Inherits="ClinicaAppFrontEnd.RegisterForm" %>



<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    
    <table cellpadding="4" cellspacing="0" style="border-collapse:collapse;">
       <tr>
           <td>
               <table cellpadding="0" style="height:513px;width:611px;">
                   <tr>
                                <td align="center" colspan="2" style="color:White;background-color:#5D7B9D;font-size:2em;font-weight:bold; height: 81px;">Registar Nova Conta</td>
                   </tr>

                   <tr >
                       <td align="right" style="width: 264px">
                           <asp:Label ID="Label1" runat="server" Text="Username:"></asp:Label>
                           
                       </td>
                       <td>
                           <asp:TextBox ID="TextBox2" runat="server" Width="171px"></asp:TextBox>
                       </td>
                   </tr>
                   <tr>
                       <td align="right" style="width: 264px">
                           <asp:Label ID="Label2" runat="server" Text="Senha:"></asp:Label>
                       </td>
                       <td>

                           <asp:TextBox ID="TextBox3" runat="server" Width="170px"></asp:TextBox>

                       </td>
                   </tr>
                   <tr>
                       <td align="right" style="width: 264px">
                           <asp:Label ID="Label3" runat="server" Text="Email:"></asp:Label>
                       </td>
                       <td>

                           <asp:TextBox ID="TextBox5" runat="server" Width="173px"></asp:TextBox>

                       </td>
                   </tr>
                   <tr>
                       <td align="right" style="width: 264px">
                           <asp:Label ID="Label4" runat="server" Text="Data de Nascimento:"></asp:Label>
                       </td>
                       <td>
                           <asp:TextBox ID="date" TextMode="Date" runat="server" CssClass="highlight" Height="24px" Width="175px"></asp:TextBox>

                           <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="date"
                            ErrorMessage="Please enter your birthday">*</asp:RequiredFieldValidator>
                    
                            <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="date"
                            ErrorMessage="Please enter a valid date" Operator="DataTypeCheck" Type="Date">*</asp:CompareValidator>
                       </td>
                   </tr>
                   <tr>
                       <td align="right" style="width: 264px">
                           <asp:Label ID="Label5" runat="server" Text="NIF:"></asp:Label>
                       </td>
                       <td>

                           <asp:TextBox ID="TextBox4" runat="server" Width="174px"></asp:TextBox>

                       </td>
                   </tr>
                   <tr>
                       <td align="right" style="width: 264px">

                           <asp:Label ID="Label6" runat="server" Text="Perfil:"></asp:Label>

                       </td>
                       <td>

                           <asp:DropDownList ID="DropDownList1" runat="server" Width="123px" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                           </asp:DropDownList>

                       </td>
                   </tr>
                   <tr>
                        <td align="center" style="width: 264px">

                            <asp:Button ID="Button1" runat="server" Text="Voltar para Menu" OnClick="Button1_Click1" />

                        </td>
                       <td align="center">

                           <asp:Button ID="Button2" runat="server" Text="Confirmar" Width="138px" OnClick="Button2_Click" />

                       </td>
                   </tr>
               </table>

           </td>
       </tr>
                    

    </table>
</asp:Content>
