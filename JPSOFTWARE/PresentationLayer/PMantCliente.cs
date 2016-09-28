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

        // obtener datos de usuario
        public ECliente get_data()
        {
            ECliente cliente = new ECliente();
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
        
        // metodo para vaciar campos
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

        public void emptyfields_less_codigo()
        {
            this.txtnombre.Text = string.Empty;
            this.txtapellido.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtemail.Text = string.Empty;
            this.chkestatus.Checked = false;
        }

        // metodo para llenar grid
        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_cliente.Select_Cliente().Tables[0];
        }
        private void PMantCliente_Load(object sender, EventArgs e)
        {
           this.fill_grid();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string rpta = "";
            ECliente cliente = new ECliente();
            if (utilites_presentation.validar(this, this.errprov) == true)
            {
                return;
            }
            cliente = get_data();
            rpta = bus_cliente.Act_Cliente(cliente);
            // si el registro fue correcto
            if (string.Compare(rpta, "REGISTRO REGISTRADO/ACTUALIZADO EXITOSAMENTE") == 0)
            {
                utilites_presentation.mensaje_ok(rpta);
                // llenar grilla despues de actualizar
                this.fill_grid();
            }
            else
            {
                utilites_presentation.mensaje_error(rpta);
            }
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.limpiar_campos();
            this.txtcodigo.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ECliente cliente = new ECliente();
            cliente.Idcliente = Convert.ToInt32(this.txtcodigo.Text.Trim());
            string rpta = bus_cliente.Delete_Cliente(cliente);
            utilites_presentation.mensaje_ok(rpta);
            this.fill_grid();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            // si existe el id ingresado completar automaticamente con los datos del registro
            ECliente cliente = this.get_data();
            DataSet ds = new DataSet();
            ds = bus_cliente.FilterbyID(cliente);
            if (utilites_presentation.isdataset_empty(ds) == false)
            {
                // llenando textbox desde los datos del dataset
                this.txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                this.txtapellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                this.txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                this.txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                this.txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                string aux = ds.Tables[0].Rows[0]["estatus"].ToString();
                this.chkestatus.Checked = aux.Equals("") ? false : true;

                
            }
            else
            {
               // limpiamos las cajas menos la de id para nuevo registro
                this.emptyfields_less_codigo();
            }
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            ECliente cliente = new ECliente();
            cliente.Nombre = this.txtbuscar.Text.Trim();
            // filling datagriview with filter data
            this.dgvdata.DataSource = bus_cliente.FilterByName(cliente).Tables[0];
            
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtcodigo.Text = dgvdata.Rows[e.RowIndex].Cells["idcliente"].Value.ToString();
            this.txtnombre.Text = dgvdata.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            this.txtapellido.Text = dgvdata.Rows[e.RowIndex].Cells["apellido"].Value.ToString();
            this.txtdireccion.Text = dgvdata.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            this.txttelefono.Text = dgvdata.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            this.txtemail.Text = dgvdata.Rows[e.RowIndex].Cells["email"].Value.ToString();
            this.chkestatus.Checked = Convert.ToBoolean(dgvdata.Rows[e.RowIndex].Cells["estatus"].Value);
            this.tabControl1.SelectedTab = this.tabpmantenimiento;
            this.txtcodigo.Focus();
        }

        private void tabpmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void txtcodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                MessageBox.Show("Solo se permiten numeros", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtcodigo_Validating_1(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            ECliente cliente = new ECliente();
            // if txt codigo is empty go out
            if (txtcodigo.Text != string.Empty)
                cliente.Idcliente = Convert.ToInt32(this.txtcodigo.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_cliente.FilterbyID(cliente);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                this.txtapellido.Text = ds.Tables[0].Rows[0]["apellido"].ToString();
                this.txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString();
                this.txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                this.txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString();
                this.chkestatus.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estatus"].ToString());
            }
            else
            {
                this.emptyfields_less_codigo();
            }
            
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = tabControl1.SelectedTab;
            this.txtbuscar.Focus();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
