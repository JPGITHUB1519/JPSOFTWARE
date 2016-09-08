using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLogicLayer;
using EntitiesLayer;

namespace JPWEB
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }
        private BCliente bus = new BCliente();
        private ECliente cliente = new ECliente();
        // obtener datos de usuario
        public ECliente get_data()
        {
            // obteniendo datos de usuario
            cliente.Idcliente = Convert.ToInt32(this.txtcodigo.Text.Trim());
            cliente.Nombre = this.txtnombre.Text.Trim();
            cliente.Apellido = this.txtapellido.Text.Trim();
            cliente.Direccion = this.txtdireccion.Text.Trim();
            cliente.Telefono = this.txttelefono.Text.Trim();
            cliente.Email = this.txtemail.Text.Trim();
            cliente.Status = this.chkestatus.Checked;
            return cliente;
        }

        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.txtcodigo.Focus();
            this.chkestatus.Checked = false;
        }

        public void fill_grid()
        {
            this.dgvdata.DataSource = bus.Select_Cliente().Tables[0];
            dgvdata.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            cliente = get_data();
            
            bus.Act_Cliente(cliente);
            lblinfo.Text = "Exito";
        }

        protected void Button1_Click1(object sender, EventArgs e)
        {
            cliente = get_data();
            bus.Delete_Cliente(cliente);
            lblinfo.Text = "Exito";
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            limpiar_campos();
        }

        protected void dgvdata_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}