using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class MesajDetay : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            dbCVEntityEntities db = new dbCVEntityEntities();
            int x = int.Parse(Request.QueryString["ID"]);
            var mesaj = db.tblİletişim.Find(x);
            TextAdSoyad.Text = mesaj.adsoyad;
            TextMail.Text = mesaj.mail;
            TextKonu.Text = mesaj.konu;
            TextMesaj.Text = mesaj.mesaj;
        }
    }
}