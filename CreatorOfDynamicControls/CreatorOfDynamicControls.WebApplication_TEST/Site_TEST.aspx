<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Site_TEST.aspx.cs" Inherits="CreatorOfDynamicControls.WebApplication_TEST.Site_TEST" %>
<!DOCTYPE html> <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> <title>Página inicial</title> </head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="230px"></asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Ler XML" OnClick="Button1_Click" />
    </div><br />
    <div>
        <asp:Button ID="Button2" runat="server" Text="Gerar controles" OnClick="Button2_Click" />
            &nbsp
        <asp:Button ID="Button3" runat="server" Text="Teste POSTBACK" OnClick="Button3_Click" />
    </div><br />
    <div>
        <asp:TextBox ID="TextBox1" runat="server" Height="347px" TextMode="MultiLine" Width="299px"></asp:TextBox>
            &nbsp
        <asp:Panel ID="Panel1" runat="server"></asp:Panel>
    </div>
    </form>
</body>
</html>
