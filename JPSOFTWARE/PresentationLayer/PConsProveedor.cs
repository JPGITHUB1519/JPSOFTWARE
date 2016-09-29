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
    public partial class PConsProveedor : PConstBase
    {
        public PConsProveedor()
        {
            InitializeComponent();
        }

        BProveedor bus_proveedor = new BProveedor();
        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_proveedor.Select_proveedor().Tables[0];
        }

        public void ok()
        {
            // ok
            
            if (dgvdata.Rows.Count == 0 || dgvdata.Rows[0].Cells[0].Value == null)
            {
                return;
            }
            DialogResult = DialogResult.OK;
            Close();
             
        }
        private void consultar()
        {
            EProveedor proveedor = new EProveedor();
            proveedor.Nombre = this.txtbuscar.Text.Trim();
            this.dgvdata.DataSource = bus_proveedor.FilterByName(proveedor).Tables[0];
            this.txtbuscar.Focus();
        }
        private void PConsProveedor_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            consultar();
        }

        private void dgvdata_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtbuscar_Validating(object sender, CancelEventArgs e)
        {
            this.consultar();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.ok();
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.ok();
        }
    }
}
