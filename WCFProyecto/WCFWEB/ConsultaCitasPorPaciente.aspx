<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="ConsultaCitasPorPaciente.aspx.cs" Inherits="WCFWEB.ConsultaCitasPorPaciente" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <table>
        <tr><td colspan="5" style="height: 39px"></td></tr>
        <tr><td colspan="5" style="height: 39px;text-align:center;" >
                <asp:Label ID="Label2" runat="server" Text="Consulta Citas por Paciente" Font-Bold="True" Font-Size="14pt"></asp:Label>
            </td></tr>
        <tr>
            <td style="width: 469px"></td>
      
            <td style="width: 27px">
                <asp:Label ID="Label1" runat="server" Text="Dni" Font-Bold="True"></asp:Label>
            </td>
            <td style="width: 202px">
                <asp:TextBox ID="txtDni" runat="server" Width="198px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="bttBBuscar" runat="server" Text="Buscar" OnClick="bttBBuscar_Click" /></td>
            <td></td>
        </tr>
        <tr>
            <td colspan="5"></td>
        </tr>
        <tr>
            <td colspan="5">
                <asp:GridView ID="gdvConsulta" runat="server"></asp:GridView>
            </td>
        </tr>
        </table>

</asp:Content>
