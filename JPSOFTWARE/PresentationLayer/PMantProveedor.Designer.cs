namespace PresentationLayer
{
    partial class PMantProveedor
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
            this.txttelefono = new PresentationLayer.jptextbox(this.components);
            this.txtdireccion = new PresentationLayer.jptextbox(this.components);
            this.txtnombre = new PresentationLayer.jptextbox(this.components);
            this.txtcodigo = new PresentationLayer.jptextbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkestatus = new System.Windows.Forms.CheckBox();
            this.dgvdata = new System.Windows.Forms.DataGridView();
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
            this.label8.Size = new System.Drawing.Size(350, 29);
            this.label8.Text = "Mantenimiento de Proveedor";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dgvdata);
            this.tabplistado.Size = new System.Drawing.Size(764, 451);
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
            this.tabpmantenimiento.Size = new System.Drawing.Size(764, 451);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(102, 312);
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
            this.groupBox1.Controls.Add(this.chkestatus);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(737, 261);
            this.groupBox1.Text = "Proveedor";
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(772, 477);
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(358, 178);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(191, 20);
            this.txttelefono.TabIndex = 104;
            this.txttelefono.validar = true;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(358, 127);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(191, 20);
            this.txtdireccion.TabIndex = 103;
            this.txtdireccion.validar = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(358, 75);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(191, 20);
            this.txtnombre.TabIndex = 101;
            this.txtnombre.validar = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(358, 26);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(191, 20);
            this.txtcodigo.TabIndex = 100;
            this.txtcodigo.validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(255, 176);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 99;
            this.label6.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(251, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 75);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 97;
            this.label7.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(267, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 95;
            this.label3.Text = "Codigo";
            // 
            // chkestatus
            // 
            this.chkestatus.AutoSize = true;
            this.chkestatus.Location = new System.Drawing.Point(358, 222);
            this.chkestatus.Name = "chkestatus";
            this.chkestatus.Size = new System.Drawing.Size(61, 17);
            this.chkestatus.TabIndex = 105;
            this.chkestatus.Text = "Estatus";
            this.chkestatus.UseVisualStyleBackColor = true;
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(45, 99);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(656, 328);
            this.dgvdata.TabIndex = 74;
            this.dgvdata.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentClick);
            this.dgvdata.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellContentDoubleClick);
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // PMantProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 562);
            this.Name = "PMantProveedor";
            this.Text = "PProveedor";
            this.Load += new System.EventHandler(this.PProveedor_Load);
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

        private jptextbox txttelefono;
        private jptextbox txtdireccion;
        private jptextbox txtnombre;
        private jptextbox txtcodigo;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdata;
        public System.Windows.Forms.CheckBox chkestatus;
    }
}