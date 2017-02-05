using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Kullanici_Giris
{
    public partial class Giris : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gonder_Click(object sender, EventArgs e)
        {
            string kullanici = kullaniciadi.Text;
            string pass = sifre.Text;
            if(kullanici == "batuhan" && pass == "1234")
            {
                Response.Redirect("BasariliGiris.aspx");
            }
            else
            {
                Response.Redirect("BasarisizGiris.aspx");
            }
        }
        
    }
}