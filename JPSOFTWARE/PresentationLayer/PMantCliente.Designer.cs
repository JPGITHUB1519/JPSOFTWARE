namespace PresentationLayer
{
    partial class PMantCliente
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
            this.label6 = new System.Windows.Forms.Label();
            this.chkestatus = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.txtcodigo = new PresentationLayer.jptextbox(this.components);
            this.txtnombre = new PresentationLayer.jptextbox(this.components);
            this.txtapellido = new PresentationLayer.jptextbox(this.components);
            this.txtdireccion = new PresentationLayer.jptextbox(this.components);
            this.txttelefono = new PresentationLayer.jptextbox(this.components);
            this.txtemail = new PresentationLayer.jptextbox(this.components);
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
            this.label8.Size = new System.Drawing.Size(324, 29);
            this.label8.Text = "Mantenimiento de Clientes";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dgvdata);
            this.tabplistado.Click += new System.EventHandler(this.tabPage2_Click);
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
            this.tabpmantenimiento.Click += new System.EventHandler(this.tabpmantenimiento_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Click += new System.EventHandler(this.button7_Click);
            // 
            // btncancelar
            // 
            this.btncancelar.Click += new System.EventHandler(this.button5_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtemail);
            this.groupBox1.Controls.Add(this.txttelefono);
            this.groupBox1.Controls.Add(this.txtdireccion);
            this.groupBox1.Controls.Add(this.txtapellido);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.chkestatus);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Text = "Clientes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(223, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 89;
            this.label6.Text = "Telefono";
            // 
            // chkestatus
            // 
            this.chkestatus.AutoSize = true;
            this.chkestatus.Location = new System.Drawing.Point(363, 339);
            this.chkestatus.Name = "chkestatus";
            this.chkestatus.Size = new System.Drawing.Size(61, 17);
            this.chkestatus.TabIndex = 83;
            this.chkestatus.Text = "Estatus";
            this.chkestatus.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(246, 291);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 88;
            this.label1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(219, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 87;
            this.label4.Text = "Direccion";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(229, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(229, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 85;
            this.label5.Text = "Apellido";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 84;
            this.label3.Text = "Codigo";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(45, 108);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(656, 374);
            this.dgvdata.TabIndex = 74;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(326, 30);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(191, 20);
            this.txtcodigo.TabIndex = 90;
            this.txtcodigo.validar = true;
            this.txtcodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcodigo_KeyPress);
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating_1);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(326, 79);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(191, 20);
            this.txtnombre.TabIndex = 91;
            this.txtnombre.validar = true;
            // 
            // txtapellido
            // 
            this.txtapellido.Location = new System.Drawing.Point(326, 132);
            this.txtapellido.Name = "txtapellido";
            this.txtapellido.Size = new System.Drawing.Size(191, 20);
            this.txtapellido.TabIndex = 92;
            this.txtapellido.validar = true;
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(326, 186);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(191, 20);
            this.txtdireccion.TabIndex = 93;
            this.txtdireccion.validar = true;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(326, 237);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(191, 20);
            this.txttelefono.TabIndex = 94;
            this.txttelefono.validar = true;
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(326, 293);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(191, 20);
            this.txtemail.TabIndex = 95;
            this.txtemail.validar = true;
            // 
            // PMantCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 656);
            this.Name = "PMantCliente";
            this.Text = "PMantCliente";
            this.Load += new System.EventHandler(this.PMantCliente_Load);
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

        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.CheckBox chkestatus;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvdata;
        private jptextbox txtemail;
        private jptextbox txttelefono;
        private jptextbox txtdireccion;
        private jptextbox txtapellido;
        private jptextbox txtnombre;
        private jptextbox txtcodigo;
    }
}