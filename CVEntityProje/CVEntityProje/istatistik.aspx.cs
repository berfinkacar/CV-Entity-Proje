using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVEntityProje
{
    public partial class istatistik : System.Web.UI.Page
    {
        dbCVEntityEntities db = new dbCVEntityEntities();
        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Text = db.tblYetenekler.Count().ToString();
            Label2.Text = db.tblİletişim.Count().ToString();
            Label3.Text = db.tblYetenekler.Average(x => x.derece).ToString();
            Label4.Text = db.tblYetenekler.Max(x => x.derece).ToString();
        }
    }
}