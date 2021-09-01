using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
namespace CVEntityProje
{
    public partial class YetenekGuncelle : System.Web.UI.Page
    {
        dbCVEntityEntities db = new dbCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            if(Page.IsPostBack== false)
            {
                var deger = db.tblYetenekler.Find(x);
                TextBox1.Text = deger.yetenek;

            }
        }
protected void Button1_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Request.QueryString["ID"]);
            var deger = db.tblYetenekler.Find(x);
            deger.yetenek = TextBox1.Text;
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");
        }
    }
}