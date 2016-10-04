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
    public partial class PConsCliente : PConstBase
    {
        public PConsCliente()
        {
            InitializeComponent();
        }
        BCliente bus_cliente = new BCliente();
        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_cliente.Select_Cliente().Tables[0];
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
            ECliente cliente = new ECliente();
            cliente.Nombre = this.txtbuscar.Text.Trim();
            this.dgvdata.DataSource = bus_cliente.FilterByName(cliente).Tables[0];
            this.txtbuscar.Focus();
        }

        private void PConsCliente_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            ok();
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ok();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            consultar();
        }
    }
}
