<%@ Page Title="" Language="C#" MasterPageFile="~/AdminMaster.master" AutoEventWireup="true" CodeFile="EditarAlunos.aspx.cs" Inherits="EditarAlunos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <p>
    <asp:GridView ID="gvAlunos" runat="server" AllowPaging="True" AutoGenerateColumns="False" CellPadding="4" DataKeyNames="id" DataSourceID="ObjectDataSource1" ForeColor="#333333" GridLines="None" Height="398px" Width="946px">
        <AlternatingRowStyle BackColor="White" />
        <Columns>
            <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
            <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
            <asp:BoundField DataField="endereco" HeaderText="Endereco" SortExpression="endereco" />
            <asp:BoundField DataField="cidade" HeaderText="Cidade" SortExpression="cidade" />
            <asp:BoundField DataField="estado" HeaderText="UF" SortExpression="estado" />
            <asp:BoundField DataField="aniversario" HeaderText="Aniversário" SortExpression="aniversario" />
            <asp:CommandField ButtonType="Button" CancelText="Cancelar" DeleteText="Excluir" EditText="Editar" InsertText="Inserir" NewText="Novo" SelectText="Selecionar" ShowDeleteButton="True" ShowEditButton="True" UpdateText="Atualizar" ShowSelectButton="True" />
        </Columns>
        <EditRowStyle BackColor="#7C6F57" />
        <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
        <RowStyle BackColor="#E3EAEB" />
        <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
        <SortedAscendingCellStyle BackColor="#F8FAFA" />
        <SortedAscendingHeaderStyle BackColor="#246B61" />
        <SortedDescendingCellStyle BackColor="#D4DFE1" />
        <SortedDescendingHeaderStyle BackColor="#15524A" />
    </asp:GridView>
</p>
    <p>
        <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataKeyNames="id" DataSourceID="ObjectDataSource1" ForeColor="Black" GridLines="Horizontal" Height="57px" HorizontalAlign="Center" Width="236px">
            <EditRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
            <Fields>
                <asp:BoundField DataField="id" HeaderText="ID" SortExpression="id" />
                <asp:BoundField DataField="nome" HeaderText="Nome" SortExpression="nome" />
                <asp:BoundField DataField="endereco" HeaderText="Endereco" SortExpression="endereco" />
                <asp:BoundField DataField="cidade" HeaderText="Cidade" SortExpression="cidade" />
                <asp:BoundField DataField="estado" HeaderText="Estado" SortExpression="estado" />
                <asp:BoundField DataField="aniversario" HeaderText="Aniversário" SortExpression="aniversario" />
                <asp:CommandField ButtonType="Button" CancelText="Cancelar" DeleteText="Deletar" EditText="Editar" InsertText="Inserir" NewText="Novo" SelectText="Selecionar" ShowInsertButton="True" UpdateText="Atualizar" />
            </Fields>
            <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
            <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        </asp:DetailsView>
</p>
    <p>
        &nbsp;</p>
    <p>
    <br />
    <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" DataObjectTypeName="Escola.Camadas.MODEL.Alunos" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="Select" TypeName="Escola.Camadas.BLL.Alunos" UpdateMethod="Update"></asp:ObjectDataSource>
</p>
<p>
</p>
</asp:Content>

