<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Site_TESTE_V2.aspx.cs" 
    Inherits="CreatorOfDynamicControls.WebApplicationV2.Site_TESTE_V2" %>

<%@ Register Src="~/CustomForm.ascx" TagPrefix="uc1" TagName="CustomForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:CustomForm runat="server" id="CustomForm01" />
    </div>
    </form>
</body>
</html>
