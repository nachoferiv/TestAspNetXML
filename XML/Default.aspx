<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="XML._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <formview id="form1" runat="server">
            <div>
                <br />
                <br />
                Seleccione una cuenta
                <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
                <br />
                <br />
                Saldo Actual
                <asp:TextBox ID="textbox1" runat="server"></asp:TextBox>
                <br />
                <br />
                Titular
                <asp:DropDownList ID="DropDownList2" runat="server"></asp:DropDownList>
                <br />
                <br />
                Activo
                <asp:TextBox ID="textbox2" runat="server"></asp:TextBox>
                <asp:Button ID="button1" runat="server" Text="Pedir datos" OnClick="button1_Click" UseSubmitBehavior="False" />
 
            </div>
        </formview>
    </main>

</asp:Content>
