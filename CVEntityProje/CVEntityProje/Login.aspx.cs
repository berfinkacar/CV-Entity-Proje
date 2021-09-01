using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        dbCVEntityEntities db = new dbCVEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            var sorgu = from x in db.tblAdmin where x.kullaniciAdi == TextBox1.Text && x.sifre == TextBox2.Text select x;
            if (sorgu.Any())
            {
                Response.Redirect("Iletisim.Aspx");
            }
            else
            {
                Response.Write("Hatalı Kullanıcı Adı veya Şifre");
            }
        }
    }
}