<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Giris.aspx.cs" Inherits="Kullanici_Giris.Giris" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <span>Kullanıcı Adı : </span><asp:TextBox runat="server" ID="kullaniciadi"></asp:TextBox>
        <br /><br />
        <span>Şifre :</span><asp:TextBox runat="server" ID="sifre" TextMode="Password"></asp:TextBox>
        <br /><br />
        <asp:Button runat="server" ID="gonder" Text="Giris - C#" OnClick="gonder_Click" />
        <br /><br />
        <input type="button" value="Giris - JavaScript" onclick="Giriskontrol()" />
    </div>
        <script>
            function Giriskontrol()
            {
                var kullanici = document.getElementById("kullaniciadi").value;
                var sifre = document.getElementById("sifre").value;
                if(kullanici == "cenker" && sifre == "4321")
                {
                    location.href("BasariliGiris.aspx");

                }
                else
                {
                    location.href("Basarisizgiris.aspx");
                }
            }

        </script>
    </form>
</body>
</html>
