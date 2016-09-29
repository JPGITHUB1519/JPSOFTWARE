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
    public partial class PMantProducto : PMantBase
    {
        public PMantProducto()
        {
            InitializeComponent();
        }

        private void PMantProducto_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }
        
        // obtener datos de usuario
        public EProducto get_data()
        {
            EProducto producto = new EProducto();
            // obteniendo datos de usuario
            producto.Idproducto = Convert.ToInt32(this.txtcodigo.Text.Trim());
            producto.Idproveedor = Convert.ToInt32(this.txtcodproveedor.Text.Trim());
            producto.Idcategoria = Convert.ToInt32(this.txtcodcategoria.Text.Trim());
            producto.Nombre = this.txtnombre.Text.Trim();
            producto.Precio = Convert.ToDecimal(this.txtprecio.Text.Trim());
            producto.Stock = Convert.ToInt32(this.txtstock.Text.Trim());
            producto.Punto_reorden = Convert.ToInt32(this.txtpuntreo.Text.Trim());
            producto.Impuesto = Convert.ToInt32(this.txtimpuesto.Text.Trim());
            return producto;
        }

        // metodo para vaciar campos
        public void limpiar_campos()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtcodcategoria.Text = string.Empty;
            this.txtcodproveedor.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtprecio.Text = string.Empty;
            this.txtstock.Text = string.Empty;
            this.txtpuntreo.Text = string.Empty;
            this.txtimpuesto.Text = string.Empty;
            this.txtcodigo.Focus();
        }

        public void emptyfields_less_codigo()
        {
            this.txtcodcategoria.Text = string.Empty;
            this.txtcodcategoria.Text = string.Empty;
            this.txtcodproveedor.Text = string.Empty;
            this.txtnombre.Text = string.Empty;
            this.txtprecio.Text = string.Empty;
            this.txtstock.Text = string.Empty;
            this.txtpuntreo.Text = string.Empty;
            this.txtimpuesto.Text = string.Empty; ;
        }

        public void fill_grid()
        {
            this.dgvdata.DataSource = bus_producto.Select_Producto().Tables[0];
        }
        
        private BProducto bus_producto = new BProducto();
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string rpta = "";
            EProducto producto = new EProducto();
            if (utilites_presentation.validar(this, this.errprov) == true)
            {
                return;
            }
            producto = get_data();
            rpta = bus_producto.Act_Producto(producto);
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

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            EProducto producto = new EProducto();
            producto.Nombre = this.txtbuscar.Text.Trim();
            // filling datagriview with filter data
            this.dgvdata.DataSource = bus_producto.FilterByName(producto).Tables[0];
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtcodigo.Text = dgvdata.Rows[e.RowIndex].Cells["idproducto"].Value.ToString();
            this.txtcodproveedor.Text = dgvdata.Rows[e.RowIndex].Cells["idproveedor"].Value.ToString();
            this.txtcodcategoria.Text = dgvdata.Rows[e.RowIndex].Cells["idcategoria"].Value.ToString();
            this.txtnombre.Text = dgvdata.Rows[e.RowIndex].Cells["nombre"].Value.ToString();
            this.txtprecio.Text = dgvdata.Rows[e.RowIndex].Cells["precio"].Value.ToString();
            this.txtstock.Text = dgvdata.Rows[e.RowIndex].Cells["stock"].Value.ToString();
            this.txtpuntreo.Text = dgvdata.Rows[e.RowIndex].Cells["punto_reorden"].Value.ToString();
            this.txtimpuesto.Text = dgvdata.Rows[e.RowIndex].Cells["impuesto"].Value.ToString();
            this.tabControl1.SelectedTab = this.tabpmantenimiento;
            this.txtcodigo.Focus();
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            EProducto producto = new EProducto();
            // if txt codigo is empty go out
            if (txtcodigo.Text != string.Empty)
                producto.Idproveedor = Convert.ToInt32(this.txtcodigo.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_producto.FilterbyID(producto);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtcodigo.Text = ds.Tables[0].Rows[0]["idproducto"].ToString();
                this.txtcodproveedor.Text = ds.Tables[0].Rows[0]["idproveedor"].ToString();
                this.txtcodcategoria.Text = ds.Tables[0].Rows[0]["idcategoria"].ToString();
                this.txtnombre.Text = ds.Tables[0].Rows[0]["nombre"].ToString();
                this.txtprecio.Text = ds.Tables[0].Rows[0]["precio"].ToString();
                this.txtstock.Text = ds.Tables[0].Rows[0]["stock"].ToString();
                this.txtpuntreo.Text = ds.Tables[0].Rows[0]["punto_reorden"].ToString();
                this.txtimpuesto.Text = ds.Tables[0].Rows[0]["impuesto"].ToString();
            }
            else
            {
                this.emptyfields_less_codigo();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.limpiar_campos();
            this.txtcodigo.Focus();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            EProducto producto = new EProducto();
            producto.Idproducto = Convert.ToInt32(this.txtcodigo.Text);
            string rpta = bus_producto.Delete_Producto(producto);
            utilites_presentation.mensaje_ok(rpta);
            this.fill_grid();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PConsCategoria doform = new PConsCategoria();

            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvdata.CurrentCell.RowIndex;

                txtcodcategoria.Text = doform.dgvdata.Rows[pos].Cells["idcategoria"].Value.ToString();
                txtcodcategoria.Focus();
            }
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PConsProveedor doform = new PConsProveedor();

            if (doform.ShowDialog() == DialogResult.OK)
            {
                int pos = doform.dgvdata.CurrentCell.RowIndex;

                txtcodproveedor.Text = doform.dgvdata.Rows[pos].Cells["idproveedor"].Value.ToString();
                txtcodproveedor.Focus();
            }
        }
    }
}
