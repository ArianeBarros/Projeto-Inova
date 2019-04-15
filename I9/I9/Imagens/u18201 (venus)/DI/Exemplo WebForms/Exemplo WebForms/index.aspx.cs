using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Exemplo_WebForms
{
    public partial class index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnProcessar_Click(object sender, EventArgs e)
        {
            lblNome.Text = txtMensagem.Text;
            pnlNome.Visible = true;
        }

        protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
                
            lblNome.Text = "Você escolheu " + ListBox1.SelectedValue;
            pnlNome.Visible = true;
                    
        }
    }
}