<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="OQTPH.WebForm1" %>
<%@ Register TagPrefix="uc" TagName="Spinner" 
    Src="~/WebUserControl1.ascx" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc:Spinner id="d1" runat="server"></uc:Spinner>
        </div>
    </form>
</body>
</html>
