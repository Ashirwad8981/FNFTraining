<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddToMyWords.aspx.cs" Inherits="SampleWebFormsApp.AddToMyWords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            margin-top: 0px;
        }
        .auto-style2 {
            margin-left: 64px;
            margin-top: 0px;
        }
        .auto-style3 {
            margin-left: 56px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Words&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Translation&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Action</h2>
        <asp:Label ID="lbl1" runat="server" CssClass="auto-style1" Height="187px" Width="104px"></asp:Label>
        <asp:Label ID="lbl2" runat="server" CssClass="auto-style2" Width="519px"></asp:Label>
        <asp:Button ID="txtButton2" runat="server" CssClass="auto-style3" Text="Action" Width="216px" />
    </form>
</body>
</html>
