<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ZamanOlcer.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        #zaman{
            font-size:22px;
            color:red;
        }
        #guncelle{
            background-color:azure;
            
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label runat="server" ID="zaman" >
        </asp:Label>
        <br /><br />
        <asp:Button runat="server" ID="guncelle" Text="Tıkla ve guncelle" OnClick="guncelle_Click" />
    </div>
    </form>
</body>
</html>
