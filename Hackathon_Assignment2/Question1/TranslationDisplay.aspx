<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TranslationDisplay.aspx.cs" Inherits="SampleWebFormsApp.TranslationDisplay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #txtHead {
            text-align:center;
        }
        .auto-style1 {
            margin-left: 23px;
            margin-top: 10px;
        }
        .auto-style2 {
            margin-left: 97px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h2 id="txtHead">Search Word</h2>
            <p>English Word</p>
                <asp:TextBox ID="txtBox1" runat="server" CssClass="auto-style1" Width="296px"></asp:TextBox>
                <asp:Button ID="txtButton" runat="server" CssClass="auto-style2" OnClick="txtButton_Click" Text="Search" Width="122px" />
            
            
<br />
            <asp:Label ID="lblMessage" runat="server" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
