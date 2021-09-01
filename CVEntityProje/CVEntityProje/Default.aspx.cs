using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class Default : System.Web.UI.Page
    {
        dbCVEntityEntities db = new dbCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Repeater1.DataSource = db.tblHakkımda.ToList();
            Repeater1.DataBind();
            Repeater2.DataSource = db.tblHakkımda.ToList();
            Repeater2.DataBind();
            Repeater3.DataSource = db.tblHakkımda.ToList();
            Repeater3.DataBind();
            Repeater4.DataSource = db.tblYetenekler.ToList();
            Repeater4.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tblİletişim t = new tblİletişim();
            t.adsoyad = TextBox1.Text;
            t.mail = TextBox2.Text;
            t.konu = TextBox3.Text;
            t.mesaj = TextBox4.Text;
            db.tblİletişim.Add(t);
            db.SaveChanges();
        }
    }
}