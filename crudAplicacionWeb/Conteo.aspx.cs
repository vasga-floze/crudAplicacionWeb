using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudAplicacionWeb
{
    public partial class Conteo : System.Web.UI.Page
    {
        private int conteo = 1;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                txConteo.Text = "0";
            }
            if (Session["click"] != null)
            {
                txConteo.Text = ((int)Session["click"]).ToString();
            }
        }

        protected void btIncremento_Click(object sender, EventArgs e)
        {
            // Si ya ha usado la varaible click
            if (Session["click"] != null)
            {
                // Leemos el valor, hacemos typecast, lo incrmentamos y lo colocamos en la
                // variable para poder trabajar con ese dato en nuestro codigo
                conteo = (int)Session["click"] + 1;
            }
            // Actualizamos el textbox
            txConteo.Text = conteo.ToString();
            // Asignamos el valor en la variable click
            Session["click"] = conteo;
        }
    }
}