<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Site_TEST.aspx.cs" 
    Inherits="CreatorOfDynamicControls.WebApplication_TEST.Site_TEST" validateRequest="false"%>

<!DOCTYPE html> <html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server"> <title>Página inicial</title> </head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:DropDownList ID="DropDownList1" runat="server" Width="230px"></asp:DropDownList>
        &nbsp;
        <asp:Button ID="Button1" runat="server" Text="Ler XML" OnClick="Button1_Click"/>
    </div><br />
    <div>
        <asp:Button ID="Button2" runat="server" Text="Gerar controles" OnClick="Button2_Click" />
            &nbsp
        <asp:Button ID="Button3" runat="server" Text="Teste POSTBACK" OnClick="Button3_Click" />
    </div><br />
        <asp:Table ID="Table1" runat="server">
            <asp:TableRow  ID="TableRow1" runat="server">
                <asp:TableCell>
                    <asp:TextBox ID="TextBox1" runat="server" Height="347px" TextMode="MultiLine" Width="299px"></asp:TextBox>
                </asp:TableCell>
                <asp:TableCell VerticalAlign="Top">
                    <asp:Panel ID="Panel1" runat="server"></asp:Panel>
                </asp:TableCell>
            </asp:TableRow>
        </asp:Table>
        <asp:HiddenField ID="HiddenField1" runat="server" Value=""/>
    </form>
</body>
</html>
