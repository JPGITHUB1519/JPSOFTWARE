namespace PresentationLayer
{
    partial class PMantCategoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtdescripcion = new PresentationLayer.jptextbox(this.components);
            this.txtcategoria = new PresentationLayer.jptextbox(this.components);
            this.txtcodigo = new PresentationLayer.jptextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabplistado.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(355, 29);
            this.label8.Text = "Mantenimiento de Categorias";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dgvdata);
            this.tabplistado.Size = new System.Drawing.Size(764, 376);
            this.tabplistado.Controls.SetChildIndex(this.btn_buscar2, 0);
            this.tabplistado.Controls.SetChildIndex(this.label2, 0);
            this.tabplistado.Controls.SetChildIndex(this.txtbuscar, 0);
            this.tabplistado.Controls.SetChildIndex(this.btnimprimir, 0);
            this.tabplistado.Controls.SetChildIndex(this.dgvdata, 0);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Size = new System.Drawing.Size(764, 376);
            this.tabpmantenimiento.Click += new System.EventHandler(this.tabpmantenimiento_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(113, 232);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Click += new System.EventHandler(this.btnsalir_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Click += new System.EventHandler(this.btncancelar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtdescripcion);
            this.groupBox1.Controls.Add(this.txtcategoria);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(737, 178);
            this.groupBox1.Text = "Categorias";
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(772, 402);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(45, 100);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(656, 455);
            this.dgvdata.TabIndex = 74;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // txtdescripcion
            // 
            this.txtdescripcion.Location = new System.Drawing.Point(351, 129);
            this.txtdescripcion.Name = "txtdescripcion";
            this.txtdescripcion.Size = new System.Drawing.Size(191, 20);
            this.txtdescripcion.TabIndex = 98;
            this.txtdescripcion.validar = true;
            // 
            // txtcategoria
            // 
            this.txtcategoria.Location = new System.Drawing.Point(351, 76);
            this.txtcategoria.Name = "txtcategoria";
            this.txtcategoria.Size = new System.Drawing.Size(191, 20);
            this.txtcategoria.TabIndex = 97;
            this.txtcategoria.validar = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(351, 27);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(191, 20);
            this.txtcodigo.TabIndex = 96;
            this.txtcodigo.validar = true;
            this.txtcodigo.TextChanged += new System.EventHandler(this.txtcodigo_TextChanged);
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(254, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(78, 20);
            this.label7.TabIndex = 95;
            this.label7.Text = "Categoria";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(254, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 20);
            this.label5.TabIndex = 94;
            this.label5.Text = "Descripcion";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(260, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 93;
            this.label3.Text = "Codigo";
            // 
            // PMantCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 487);
            this.Name = "PMantCategoria";
            this.Text = "PCategoria";
            this.Load += new System.EventHandler(this.PCategoria_Load);
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvdata;
        private jptextbox txtdescripcion;
        private jptextbox txtcategoria;
        private jptextbox txtcodigo;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
    }
}