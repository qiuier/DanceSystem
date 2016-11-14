<%@ Page Language="C#" AutoEventWireup="true" CodeFile="1025.aspx.cs" Inherits="_1025" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lable_upxls" runat="server" />
            <asp:FileUpload ID="FileUpload_xls" runat="server" />
            &nbsp;<asp:Button ID="Button1" runat="server" Text="上传" OnClick="Button1_Click" />

        &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>

        </div>
    </form>
</body>
</html>
