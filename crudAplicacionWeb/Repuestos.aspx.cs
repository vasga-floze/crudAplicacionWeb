using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudAplicacionWeb
{
    public partial class Repuestos : System.Web.UI.Page
    {
        Crud paso = new Crud();
        protected void Page_Load(object sender, EventArgs e)
        {
            /* Si el campo usuario no tiene ningún valor es nulo, 
             * por lo tanto se redireccionará a la página 
             * de WebLogin.aspx para que inicie un usuario y contraseña.*/
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("Login.aspx");
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtDescripcion.Text = "";
            txtCostoUnitario.Text = "";
            txtPrecioUnitario.Text = "";
            txtCodigo.Focus();
            lblMensajeNotificador.Text = "Registro nuevo";
            string javaScript = "alert('Se limpiarán los campos de entrada de datos');";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Session["guardar"].Equals("s"))
            {
                    string insertar = "INSERT INTO repuesto(nombre,descripcion,costoUnitario,precioUnitario) VALUES('" + txtNombre.Text + "','" + txtDescripcion.Text + "','" + txtCostoUnitario.Text + "','" + txtPrecioUnitario.Text + "')";
                //codMecanico,   *****  '" + txtCodigo.Text + "',
                //MessageBox.Show(insertar);
                if (paso.operacion(insertar))
                {
                    lblMensajeNotificador.Text = "Registro almacenado correctamente";
                    string javaScript = "alert('Registro almacenado correctamente');";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
                }
                else
                {
                    //lblMensajeNotificador.Text = "Error al almacenado el registro";
                }
            }
            else
            {
                lblMensajeNotificador.Text = "Para poder realizar estos cambios debe solicitar autorización";
            }
        }

        protected void btnModificar_Click(object sender, EventArgs e)
        {
            if (Session["modificar"].Equals("s"))
            {
                    string modificar = "Update repuesto set nombre='" + txtNombre.Text + "',descripcion='" + txtDescripcion.Text + "',costoUnitario='" + txtCostoUnitario.Text + "',precioUnitario='" + txtPrecioUnitario.Text + "' where codRepuestos ='" + txtCodigo.Text + "'";
                //codMecanico='" + txtCodigo.Text + "',
                if (paso.operacion(modificar))
                {
                    lblMensajeNotificador.Text = "Registro modificado correctamente";
                }
                else
                {
                    lblMensajeNotificador.Text = "Error al modificar el registro";
                }
                }
                else
            {
                lblMensajeNotificador.Text = "Para poder realizar estos cambios debe solicitar autorización";
            }
        }

        protected void btnConsultar_Click(object sender, EventArgs e)
        {
            if (Session["consultar"].Equals("s"))
            {
                    string sql = "select * from repuesto WHERE codRepuestos='" + txtCodigo.Text + "'";
                paso.ConsultarTexto(sql);
                if (paso.dr.Read())
                {
                    txtCodigo.Text = Convert.ToString(paso.dr[0]);
                    txtNombre.Text = Convert.ToString(paso.dr[1]);
                    txtDescripcion.Text = Convert.ToString(paso.dr[2]);
                    txtCostoUnitario.Text = Convert.ToString(paso.dr[3]);
                    txtPrecioUnitario.Text = Convert.ToString(paso.dr[4]);
                    paso.dr.Close();
                    paso.cerrarConn();
                }
            }
            else
            {
                lblMensajeNotificador.Text = "Para poder realizar estos cambios debe solicitar autorización";
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Session["eliminar"].Equals("s"))
            {
                    string borrar = "DELETE FROM repuesto WHERE codRepuestos = '" + txtCodigo.Text + "'";
                if (paso.operacion(borrar))
                {
                    lblMensajeNotificador.Text = "Registro eliminado correctamente";
                }
                else
                {
                    lblMensajeNotificador.Text = "Error al eliminar el registro";
                }
            }
            else
            {
                lblMensajeNotificador.Text = "Para poder realizar estos cambios debe solicitar autorización";
            }
        }
    }
}