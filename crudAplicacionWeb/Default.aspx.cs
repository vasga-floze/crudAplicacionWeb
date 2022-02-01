using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudAplicacionWeb
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Es una variable de tipo bool para identificar si la página ha sido cargada por primera vez o es una recarga.
             */
            if (!IsPostBack)
            {
                if (Session["usuario"] != null)
                {
                    lblSesion.Text = Session["nombre"] + " ha iniciado sesion!";
                }
            }
        }
    }
}