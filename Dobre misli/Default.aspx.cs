using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Dobre_misli
{
    public partial class Default : System.Web.UI.Page
    {
        static List<Label> labels = new List<Label>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
            {
                foreach (var label in labels)
                    misli.Controls.Add(label);
            }
        }

        protected void dodajMisel_Click(object sender, EventArgs e)
        {
            Label l = new Label();
            l.Text = '"' + misel.Text + '"';
            l.Style.Add("display", "block");
            labels.Add(l);
            misli.Controls.Add(l);
        }
    }
    
}