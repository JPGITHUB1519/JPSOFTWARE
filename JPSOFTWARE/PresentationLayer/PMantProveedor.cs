using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BusinessLogicLayer;
using EntitiesLayer;

namespace PresentationLayer
{
    public partial class PMantProveedor : PMantBase
    {
        public PMantProveedor()
        {
            InitializeComponent();
        }

        public BProveedor bus_proveedor = new BProveedor();
        public EProveedor get_data()
        {
            EProveedor proveedor = new EProveedor();
            proveedor.Idproveedor = Convert.ToInt32(this.txtcodigo.Text.Trim());
            proveedor.Nombre = this.txtnombre.Text.Trim();
            proveedor.Telefono = this.txttelefono.Text.Trim();
            proveedor.Direccion = this.txtdireccion.Text.Trim();
            proveedor.Estatus = Convert.ToBoolean(this.chkestatus.Checked);
            return proveedor;
        }

        public void empty_fields()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.chkestatus.Checked = false;
        }

        public void empty_fields_less_codigo()
        {
            this.txtnombre.Text = string.Empty;
            this.txttelefono.Text = string.Empty;
            this.txtdireccion.Text = string.Empty;
            this.chkestatus.Checked = false;
        }

        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_proveedor.Select_proveedor().Tables[0];
        }
        private void PProveedor_Load(object sender, EventArgs e)
        {
            this.fill_grid();  
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string rpta = "";
            EProveedor proveedor = new EProveedor();
            if (utilites_presentation.validar(this, this.errprov) == true)
            {
                return;
            }
            proveedor = get_data();
            rpta = bus_proveedor.Act_proveedor(proveedor);
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

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EProveedor proveedor = new EProveedor();
            proveedor.Idproveedor = Convert.ToInt32(this.txtcodigo.Text.Trim());
            string rpta = bus_proveedor.Delete_proveedor(proveedor);
            utilites_presentation.mensaje_ok(rpta);
            this.fill_grid();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.empty_fields();
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            EProveedor proveedor = new EProveedor();
            proveedor.Nombre = this.txtbuscar.Text.Trim();
            // filling datagriview with filter data
            this.dgvdata.DataSource = bus_proveedor.FilterByName(proveedor).Tables[0];
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtcodigo.Text = dgvdata.Rows[e.RowIndex].Cells["idproveedor"].Value.ToString();
            this.txtnombre.Text = dgvdata.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            this.txtdireccion.Text = dgvdata.Rows[e.RowIndex].Cells["direccion"].Value.ToString();
            this.txttelefono.Text = dgvdata.Rows[e.RowIndex].Cells["telefono"].Value.ToString();
            this.tabControl1.SelectedTab = this.tabpmantenimiento;
            this.txtcodigo.Focus();
        }

        private void dgvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            EProveedor proveedor = new EProveedor();
            // if txt codigo is empty go out
            if (txtcodigo.Text != string.Empty)
                proveedor.Idproveedor = Convert.ToInt32(this.txtcodigo.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_proveedor.FilterbyID(proveedor);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtcodigo.Text = ds.Tables[0].Rows[0]["idproveedor"].ToString();
                this.txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                this.txtdireccion.Text =  ds.Tables[0].Rows[0]["direccion"].ToString();
                this.txttelefono.Text = ds.Tables[0].Rows[0]["telefono"].ToString();
                this.chkestatus.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["estatus"]);

            }
            else
            {
                this.empty_fields_less_codigo();
            }
        }
    }
}
