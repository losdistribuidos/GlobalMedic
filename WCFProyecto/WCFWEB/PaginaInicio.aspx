<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="PaginaInicio.aspx.cs" Inherits="WCFWEB.PaginaInicio" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadContent" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="FeaturedContent" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TreeView ID="TreeView1" runat="server" Height="14px" ImageSet="Simple" Width="122px">
        <HoverNodeStyle Font-Underline="True" ForeColor="#5555DD" />
        <Nodes>
            <asp:TreeNode Text="Enfermedades" Value="Enfermedades">
                <asp:TreeNode Text="MedicamentoPorEnfermedad" Value="MedicamentoPorEnfermedad" NavigateUrl="~/WebMedicamento.aspx"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Pacientes" Value="Pacientes">
                <asp:TreeNode Text="ConsultaPorEnfermedad" Value="ConsultaPorEnfermedad" NavigateUrl="~/ConsultaPaciente.aspx"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Paises" Value="Paises">
                <asp:TreeNode Text="Listar Paises por enfermedad" Value="Listar Paises por enfermedad" NavigateUrl="~/ConsultarPorPais.aspx"></asp:TreeNode>
            </asp:TreeNode>
            <asp:TreeNode Text="Consultas Citas" Value="Citas">
                <asp:TreeNode NavigateUrl="~/ConsultaFechasDoctor/ConsultaCitasPorDoctorSexoyPais.aspx" Text="Por Sexo ,Pais y Doctor" Value="Por Sexo ,Pais y Doctor"></asp:TreeNode>
                <asp:TreeNode NavigateUrl="~/ConsultaFechasDoctor/ConsultarCitasDeDoctorPorespecialidadysex.aspx" Text="Por Especialidad y sexo" Value="Por Especialidad y sexo"></asp:TreeNode>
            </asp:TreeNode>
        </Nodes>
        <NodeStyle Font-Names="Tahoma" Font-Size="10pt" ForeColor="Black" HorizontalPadding="0px" NodeSpacing="0px" VerticalPadding="0px" />
        <ParentNodeStyle Font-Bold="False" />
        <SelectedNodeStyle Font-Underline="True" ForeColor="#5555DD" HorizontalPadding="0px" VerticalPadding="0px" />
    </asp:TreeView>
</asp:Content>
