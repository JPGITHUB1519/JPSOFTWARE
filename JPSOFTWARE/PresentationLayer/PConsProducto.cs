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
    public partial class PConsProducto : PConstBase
    {
        public PConsProducto()
        {
            InitializeComponent();
        }

        EProducto producto = new EProducto();
        BProducto bus_producto = new BProducto();

        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_producto.Select_Producto().Tables[0];
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

        private void PConsProducto_Load(object sender, EventArgs e)
        {
            this.fill_grid();
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
