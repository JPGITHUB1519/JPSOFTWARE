using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntitiesLayer;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class PMantCliente : PMantBase
    {
        public PMantCliente()
        {
            InitializeComponent();
        }
        private BCliente bus_cliente = new BCliente();
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
            this.dgvdata.DataSource = bus_cliente.Select_Cliente();
 
        }
        private void PMantCliente_Load(object sender, EventArgs e)
        {
            fill_grid();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            ECliente cliente = new ECliente();
            // obteniendo datos de usuario
            cliente.Idcliente = Convert.ToInt32(this.txtcodigo.Text.Trim());
            cliente.Nombre = this.txtnombre.Text.Trim();
            cliente.Apellido = this.txtapellido.Text.Trim();
            cliente.Direccion = this.txtdireccion.Text.Trim();
            cliente.Telefono = this.txttelefono.Text.Trim();
            cliente.Email = this.txtemail.Text.Trim();
            MessageBox.Show(bus_cliente.Act_Cliente(cliente));
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.limpiar_campos();
        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
