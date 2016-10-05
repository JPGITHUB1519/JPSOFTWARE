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
        BCliente bus_cliente = new BCliente();
        BProducto bus_producto = new BProducto();

        void add_dgv()
        {
            double total;
            double importe = Convert.ToDouble(this.txtprevent.Text) * Convert.ToInt32(this.txtcantvent.Text.Trim());
            this.dgvdata.Rows.Add(this.txtcodpro.Text.Trim(), this.txtnompro.Text.Trim(), this.txtprevent.Text.Trim(), this.txtcantvent.Text.Trim(), importe);
            if (string.IsNullOrEmpty(this.txttotal.Text.Trim()))
            {
                total = 0;
            }
            else
            {
                total = Convert.ToDouble(this.txttotal.Text.Trim());
            }
            total += importe;
            this.txttotal.Text = Convert.ToString(total);
        }

        public void empty_dgv()
        {
            this.dgvdata.Rows.Clear();
            this.txtcodpro.Focus();
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

        private void txtcodcli_Validating(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            ECliente cliente = new ECliente();
            // if txt codigo is empty go out
            if (txtcodcli.Text != string.Empty)
                cliente.Idcliente = Convert.ToInt32(this.txtcodcli.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_cliente.FilterbyID(cliente);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtcodcli.Text = ds.Tables[0].Rows[0]["idcliente"].ToString();
                this.txtnomcli.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                
            }
            else
            {
                txtcodcli.Text = string.Empty;
                txtcodcli.Text = string.Empty;
            }
        }

        private void txtcodcli_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel2_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtcodpro_Validating(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            EProducto producto = new EProducto();
            // if txt codigo is empty go out
            if (txtcodpro.Text != string.Empty)
                producto.Idproveedor = Convert.ToInt32(this.txtcodpro.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_producto.FilterbyID(producto);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtcodpro.Text = ds.Tables[0].Rows[0]["idproducto"].ToString();
                this.txtnompro.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                this.txtprevent.Text = ds.Tables[0].Rows[0]["precio"].ToString();
            }
            else
            {
                this.txtnompro.Text = string.Empty;
                this.txtprevent.Text = string.Empty;
                this.txtcantvent.Text = string.Empty;

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.add_dgv();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            // eliminar elemento y restar del total
            if (utilites_presentation.isdgvempty(this.dgvdata))
            {
                return;
            }
            else
            {
                double new_total;
                double importe_seleccionado;
                int row = this.dgvdata.CurrentRow.Index;
                importe_seleccionado = Convert.ToDouble(this.dgvdata.Rows[row].Cells[4].Value);
                new_total = Convert.ToDouble(this.txttotal.Text.Trim()) - importe_seleccionado;
                this.txttotal.Text = new_total.ToString();
                dgvdata.Rows.Remove(dgvdata.CurrentRow);
                
            }
            this.txtcodpro.Focus();
            
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.empty_dgv();
        }
    }
}
