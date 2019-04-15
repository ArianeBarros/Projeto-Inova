<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="Exemplo_WebForms.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" type="text/css" href="Content/estilo.css" />
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        Digite seu nome:<asp:TextBox ID="txtMensagem" runat="server" Height="16px"></asp:TextBox>
        <br />
        <asp:Button ID="btnProcessar" runat="server" OnClick="btnProcessar_Click" Text="Processar" />
        <asp:Panel ID="pnlNome" runat="server" Visible="False" Height="19px" Width="459px">
            <asp:Label ID="lblNome" runat="server" Text="Label"></asp:Label>
        </asp:Panel>
        <asp:ListBox ID="ListBox1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged">
            <asp:ListItem>Alimentos </asp:ListItem>
            <asp:ListItem>Desenvolvimento de Sistemas</asp:ListItem>
            <asp:ListItem>Eletroeletrônica</asp:ListItem>
            <asp:ListItem>Enfermagem</asp:ListItem>
            <asp:ListItem>Informática</asp:ListItem>
            <asp:ListItem>Mecatrônica</asp:ListItem>
            <asp:ListItem>Meio Ambiente</asp:ListItem>
            <asp:ListItem>Plásticos</asp:ListItem>
            <asp:ListItem>Segurança no Trabalho</asp:ListItem>
            <asp:ListItem>Telecomunicações</asp:ListItem>
        </asp:ListBox>
    </form>
</body>
</html>
