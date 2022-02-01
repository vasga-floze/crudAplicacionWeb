using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crudAplicacionWeb
{
    public partial class Mecanicos : System.Web.UI.Page
    {
        Crud paso = new Crud();
        protected void Page_Load(object sender, EventArgs e)
        {
            // Si el campo usuario no tiene ningún valor es nulo, por lo tanto se
            // redireccionará a la página de WebLogin.aspx para que inicie con usuario y contraseña.
            if (!IsPostBack)
            {
                if (Session["usuario"] == null)
                    Response.Redirect("Login.aspx");
            }
        }

        protected void btnNuevo_Click(object sender, EventArgs e)
        {
            //lbMensajes.Text = txNombre.Text;
            //txtCodigo.Text = "";
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
            txtCostoHora.Text = "";
            txtCodigo.Focus();
            lblMensajeNotificador.Text = "Registro nuevo";
            string javaScript = "alert('Se limpiarán los campos de entrada de datos');";
            ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            if (Session["guardar"].Equals("s"))
            {
                    string insertar = "INSERT INTO mecanico(nombre,direccion,telefono,costoHora) VALUES('" + txtNombre.Text + "','" + txtDireccion.Text + "','" + txtTelefono.Text + "','" + txtCostoHora.Text + "')";
                //codMecanico,   *****  '" + txtCodigo.Text + "',
                //MessageBox.Show(insertar);
                    paso.operacion(insertar);

                    lblMensajeNotificador.Text = "Registro almacenado correctamente";
                    string javaScript = "alert('Registro almacenado correctamente');";
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "script", javaScript, true);

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
                    string modificar = "Update mecanico set nombre='" + txtNombre.Text + "',direccion='" + txtDireccion.Text + "',telefono='" + txtTelefono.Text + "',costoHora='" + txtCostoHora.Text + "' where codMecanico ='" + txtCodigo.Text + "'";
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
                    string sql = "select * from mecanico WHERE codMecanico='" + txtCodigo.Text + "'";
                paso.ConsultarTexto(sql);
                if (paso.dr.Read())
                {
                    txtCodigo.Text = Convert.ToString(paso.dr[0]);
                    txtNombre.Text = Convert.ToString(paso.dr[1]);
                    txtDireccion.Text = Convert.ToString(paso.dr[2]);
                    txtTelefono.Text = Convert.ToString(paso.dr[3]);
                    txtCostoHora.Text = Convert.ToString(paso.dr[4]);
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
                    string borrar = "DELETE FROM mecanico WHERE codMecanico = '" + txtCodigo.Text + "'";
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