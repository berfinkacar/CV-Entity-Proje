using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class YeniYetenek : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        dbCVEntityEntities db = new dbCVEntityEntities();
        protected void Button1_Click(object sender, EventArgs e)
        {
            tblYetenekler t = new tblYetenekler();
            t.yetenek = TextBox1.Text;
            db.tblYetenekler.Add(t);
            db.SaveChanges();
            Response.Redirect("Yeteneklerim.Aspx");

        }
    }
}