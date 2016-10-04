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
    public partial class PFacturacion : Form
    {
        public PFacturacion()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PConsCliente doform = new PConsCliente();

            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvdata.CurrentCell.RowIndex;
                txtcodcli.Text = doform.dgvdata.Rows[pos].Cells["idcliente"].Value.ToString();
                txtnomcli.Text = doform.dgvdata.Rows[pos].Cells["nombre"].Value.ToString();
                txtcodcli.Focus();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PConsProducto doform = new PConsProducto();

            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvdata.CurrentCell.RowIndex;
                txtcodpro.Text = doform.dgvdata.Rows[pos].Cells["idproducto"].Value.ToString();
                txtnompro.Text = doform.dgvdata.Rows[pos].Cells["nombre"].Value.ToString();
                txtprevent.Text = doform.dgvdata.Rows[pos].Cells["precio"].Value.ToString();
                txtcantvent.Focus();
            }
        }
    }
}
