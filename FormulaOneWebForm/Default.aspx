<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="FormulaOneWebForm.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title>FormulaOne - WebForm</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <%--Username <asp:TextBox id="txtUserName" runat="server" /> <br />
            Password <input type = "text" id = "txtPassword" /> <br />--%>
            <asp:Button id = "btnInvia" runat = "server" Text = "Invia" /> <br />
            <asp:Label id = "lblMessaggio" runat = "server" Text = " "></asp:Label><br /><br />
            <asp:ListBox ID="lbxNazioni" runat="server" Width="500px"></asp:ListBox>
            <asp:DropDownList ID="DropDownList1" runat="server"></asp:DropDownList>
        </div>
    </form>
    <div>
        
    </div>
</body>
</html>
