using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ZamanOlcer
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void guncelle_Click(object sender, EventArgs e)
        {
            zaman.Text = DateTime.Now.ToString();
        }
    }
}