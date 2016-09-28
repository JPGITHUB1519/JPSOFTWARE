using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using EntitiesLayer;
using System.Data.SqlClient;
using BusinessLogicLayer;

namespace PresentationLayer
{
    public partial class PMantCategoria : PMantBase
    {
        public PMantCategoria()
        {
            InitializeComponent();
        }

        public BCategoria bus_categoria = new BCategoria();
        public ECategoria get_data()
        {
            ECategoria categoria = new ECategoria();
            categoria.Idcategoria = Convert.ToInt32(this.txtcodigo.Text.Trim());
            categoria.Categoria = this.txtcategoria.Text.Trim();
            categoria.Descripcion = this.txtcategoria.Text.Trim();
            return categoria;
        }

        public void empty_fields()
        {
            this.txtcodigo.Text = string.Empty;
            this.txtcategoria.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
        }

        public void emptyfields_less_codigo()
        {
            this.txtcategoria.Text = string.Empty;
            this.txtdescripcion.Text = string.Empty;
        }

        public void fill_grid()
        {
            this.dgvdata.DataSource = this.bus_categoria.Select_categoria().Tables[0];
        }

        private void PCategoria_Load(object sender, EventArgs e)
        {
            this.fill_grid();
        }

        private void tabpmantenimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            string rpta = "";
            ECategoria categoria = new ECategoria();
            if (utilites_presentation.validar(this, this.errprov) == true)
            {
                return;
            }
            categoria = get_data();
            rpta = bus_categoria.Act_categoria(categoria);
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

        private void btnNuevo_Click()
        {

        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.empty_fields();
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            this.tabControl1.SelectedTab = this.tabplistado;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            ECategoria categoria = new ECategoria();
            categoria.Idcategoria = Convert.ToInt32(this.txtcodigo.Text.Trim());
            string rpta = bus_categoria.Delete_categoria(categoria);
            utilites_presentation.mensaje_ok(rpta);
            this.fill_grid();
        }

        private void btn_buscar2_Click(object sender, EventArgs e)
        {
            ECategoria categoria = new ECategoria();
            categoria.Categoria  = this.txtbuscar.Text.Trim();
            // filling datagriview with filter data
            this.dgvdata.DataSource = bus_categoria.FilterByName(categoria).Tables[0];
        }

        private void dgvdata_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtcodigo.Text = dgvdata.Rows[e.RowIndex].Cells["idcategoria"].Value.ToString();
            this.txtcategoria.Text = dgvdata.Rows[e.RowIndex].Cells["categoria"].Value.ToString();
            this.txtdescripcion.Text = dgvdata.Rows[e.RowIndex].Cells["descripcion"].Value.ToString();
            this.tabControl1.SelectedTab = this.tabpmantenimiento;
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            // fill customer data in validate method
            ECategoria categoria = new ECategoria();
            // if txt codigo is empty go out
            if (txtcodigo.Text != string.Empty)
                categoria.Idcategoria = Convert.ToInt32(this.txtcodigo.Text.Trim());
            else
                return;
            DataSet ds = new DataSet();
            ds = bus_categoria.FilterbyID(categoria);
            // if the dataset is filled, it means that there are data and we have to fill the fields
            // if not empty the fields
            if (utilites_presentation.isdataset_empty(ds) != true)
            {
                this.txtcodigo.Text = ds.Tables[0].Rows[0]["idproducto"].ToString();
                this.txtcategoria.Text = ds.Tables[0].Rows[0]["categoria"].ToString();
                this.txtdescripcion.Text = ds.Tables[0].Rows[0]["descripcion"].ToString();

            }
            else
            {
                this.emptyfields_less_codigo();
            }
        }
    }
}
