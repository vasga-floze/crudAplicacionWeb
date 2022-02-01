using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudAplicacionWeb
{
    public partial class Login : System.Web.UI.Page
    {
        // Aquí creamos la instancia de la clase 
        Crud paso = new Crud();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Este método es primero que se ejecuta al cargar la página.     
        }

        // Este método es el que oculta la contraseña
        // Al compararse con el contenido del campo de la tabla login
        // debe ser exactamente igual. 
        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            string cadena, oculto, usuario;
            usuario = txtUsuario.Text;
            cadena = txtContra.Text; //8cb2237d0679ca88db6464eac60da96345513964
            oculto = paso.generarClaveSHA1(cadena);
            //lbMensaje.Text = usuario +"  "+ oculto; 
            try
            {
                string buscar = "select * from login where usuario = '" + usuario + "' and contra = '" + oculto + "'";

                paso.ConsultarTexto(buscar);
                if (paso.dr.Read())
                {
                    // si la consulta es correcta creamos las variables de sesión con los datos de la consulta.
                    //Response.Write("<script>parent.alert('Has iniciado sesion');</script>");
                    Session["usuario"] = txtUsuario.Text;
                    Session["nivel"] = Convert.ToString(paso.dr[2]);
                    Session["guardar"] = Convert.ToString(paso.dr[3]);
                    Session["modificar"] = Convert.ToString(paso.dr[4]);
                    Session["eliminar"] = Convert.ToString(paso.dr[5]);
                    Session["consultar"] = Convert.ToString(paso.dr[6]);
                    Session["nombre"] = Convert.ToString(paso.dr[7]);

                    Response.Redirect("Default.aspx");
                }
                else
                {
                    throw new Exception("Usuario o contraseña incorrectos");
                }
            }
            catch (Exception ex)
            {
                //Response.Write("<script>parent.alert('"+ex.Message+"');</script>");
                Response.Write(lblMensaje.Text = "OBSERVACION: " + ex.Message);
            }
        }
    }
}