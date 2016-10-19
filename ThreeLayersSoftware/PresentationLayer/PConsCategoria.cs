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
    public partial class PConsCategoria : PConstBase
    {
        public PConsCategoria()
        {
            InitializeComponent();
        }
        ECategoria categoria = new ECategoria();
        BCategoria bus_categoria = new BCategoria();

        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_categoria.Select_categoria().Tables[0];
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
        private void PConsCategoria_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }
        private void consultar()
        {
            ECategoria categoria = new ECategoria();
            categoria.Categoria = this.txtbuscar.Text.Trim();
            this.dgvdata.DataSource = bus_categoria.FilterByName(categoria).Tables[0];
            this.txtbuscar.Focus();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
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

        private void txtbuscar_Validating(object sender, CancelEventArgs e)
        {
            this.consultar();
        }

        private void dgvdata_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            this.ok();
        }

        private void btnbuscar_Click_1(object sender, EventArgs e)
        {
            this.ok();
        }
 
    }
}
