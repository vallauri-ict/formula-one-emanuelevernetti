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
            <!--<asp:Button id = "btnInvia" runat = "server" Text = "Invia" /> <br />-->
            <asp:Label id = "lblMessaggio" runat = "server" Text = " "></asp:Label><br /><br />
            <asp:DropDownList ID="DropDownList" runat="server" OnSelectedIndexChanged ="DropDownList_SelectedIndexChanged" AutoPostBack="True">
            </asp:DropDownList><br /><br />
            <asp:GridView ID="gridViewData" runat="server"></asp:GridView>
            <asp:ListBox ID="lbxData" runat="server" Width="670px" Height="163px"></asp:ListBox>
        </div>
    </form>
    <div>
        
    </div>
</body>
</html>
