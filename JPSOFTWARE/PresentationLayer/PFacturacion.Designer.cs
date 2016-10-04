namespace PresentationLayer
{
    partial class PFacturacion
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
            this.label8 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncancelar = new System.Windows.Forms.Button();
            this.btnprocesar = new System.Windows.Forms.Button();
            this.txtotal = new PresentationLayer.jptextbox(this.components);
            this.txtcantvent = new PresentationLayer.jptextbox(this.components);
            this.txtprevent = new PresentationLayer.jptextbox(this.components);
            this.txtnompro = new PresentationLayer.jptextbox(this.components);
            this.txtcodpro = new PresentationLayer.jptextbox(this.components);
            this.txtnomcli = new PresentationLayer.jptextbox(this.components);
            this.txtcodcli = new PresentationLayer.jptextbox(this.components);
            this.jptextbox1 = new PresentationLayer.jptextbox(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Maroon;
            this.label8.Location = new System.Drawing.Point(421, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 29);
            this.label8.TabIndex = 79;
            this.label8.Text = "Facturacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.TabIndex = 106;
            this.label1.Text = "Usuario";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.txtnomcli);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtcodcli);
            this.groupBox1.Location = new System.Drawing.Point(25, 109);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(957, 92);
            this.groupBox1.TabIndex = 108;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de Cliente";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel1.Location = new System.Drawing.Point(7, 38);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(91, 20);
            this.linkLabel1.TabIndex = 110;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cod.Cliente";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(333, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 20);
            this.label5.TabIndex = 108;
            this.label5.Text = "Nombre";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.linkLabel2);
            this.groupBox2.Controls.Add(this.txtcantvent);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtprevent);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtnompro);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.txtcodpro);
            this.groupBox2.Location = new System.Drawing.Point(25, 221);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1236, 77);
            this.groupBox2.TabIndex = 109;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos de Productos";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.linkLabel2.Location = new System.Drawing.Point(7, 30);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(66, 20);
            this.linkLabel2.TabIndex = 114;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Cod.Pro";
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(913, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 112;
            this.label7.Text = "Cant.Vent";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 110;
            this.label6.Text = "PreVent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(328, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 20);
            this.label2.TabIndex = 108;
            this.label2.Text = "Nombre Pro.";
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(25, 342);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(1236, 413);
            this.dgvdata.TabIndex = 110;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(938, 772);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 20);
            this.label9.TabIndex = 111;
            this.label9.Text = "Total";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnbuscar);
            this.groupBox3.Controls.Add(this.btneliminar);
            this.groupBox3.Controls.Add(this.btnsalir);
            this.groupBox3.Controls.Add(this.btncancelar);
            this.groupBox3.Controls.Add(this.btnprocesar);
            this.groupBox3.Location = new System.Drawing.Point(257, 827);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(584, 122);
            this.groupBox3.TabIndex = 113;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Acciones";
            // 
            // btnbuscar
            // 
            this.btnbuscar.Image = global::PresentationLayer.Properties.Resources.search;
            this.btnbuscar.Location = new System.Drawing.Point(351, 19);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(106, 72);
            this.btnbuscar.TabIndex = 9;
            this.btnbuscar.UseVisualStyleBackColor = true;
            // 
            // btneliminar
            // 
            this.btneliminar.Image = global::PresentationLayer.Properties.Resources.listquit;
            this.btneliminar.Location = new System.Drawing.Point(127, 19);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(106, 72);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.UseVisualStyleBackColor = true;
            // 
            // btnsalir
            // 
            this.btnsalir.Image = global::PresentationLayer.Properties.Resources.User_Interface_Login_icon;
            this.btnsalir.Location = new System.Drawing.Point(463, 19);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(106, 72);
            this.btnsalir.TabIndex = 11;
            this.btnsalir.UseVisualStyleBackColor = true;
            // 
            // btncancelar
            // 
            this.btncancelar.Image = global::PresentationLayer.Properties.Resources.Undo_icon;
            this.btncancelar.Location = new System.Drawing.Point(239, 19);
            this.btncancelar.Name = "btncancelar";
            this.btncancelar.Size = new System.Drawing.Size(106, 72);
            this.btncancelar.TabIndex = 10;
            this.btncancelar.UseVisualStyleBackColor = true;
            // 
            // btnprocesar
            // 
            this.btnprocesar.Image = global::PresentationLayer.Properties.Resources.facturation;
            this.btnprocesar.Location = new System.Drawing.Point(15, 19);
            this.btnprocesar.Name = "btnprocesar";
            this.btnprocesar.Size = new System.Drawing.Size(106, 72);
            this.btnprocesar.TabIndex = 7;
            this.btnprocesar.UseVisualStyleBackColor = true;
            // 
            // txtotal
            // 
            this.txtotal.Location = new System.Drawing.Point(1003, 772);
            this.txtotal.Name = "txtotal";
            this.txtotal.Size = new System.Drawing.Size(191, 20);
            this.txtotal.TabIndex = 112;
            this.txtotal.validar = true;
            // 
            // txtcantvent
            // 
            this.txtcantvent.Location = new System.Drawing.Point(1012, 30);
            this.txtcantvent.Name = "txtcantvent";
            this.txtcantvent.Size = new System.Drawing.Size(191, 20);
            this.txtcantvent.TabIndex = 113;
            this.txtcantvent.validar = true;
            // 
            // txtprevent
            // 
            this.txtprevent.Location = new System.Drawing.Point(704, 30);
            this.txtprevent.Name = "txtprevent";
            this.txtprevent.Size = new System.Drawing.Size(191, 20);
            this.txtprevent.TabIndex = 111;
            this.txtprevent.validar = true;
            // 
            // txtnompro
            // 
            this.txtnompro.Location = new System.Drawing.Point(426, 30);
            this.txtnompro.Name = "txtnompro";
            this.txtnompro.Size = new System.Drawing.Size(191, 20);
            this.txtnompro.TabIndex = 109;
            this.txtnompro.validar = true;
            // 
            // txtcodpro
            // 
            this.txtcodpro.Location = new System.Drawing.Point(104, 28);
            this.txtcodpro.Name = "txtcodpro";
            this.txtcodpro.Size = new System.Drawing.Size(191, 20);
            this.txtcodpro.TabIndex = 107;
            this.txtcodpro.validar = true;
            // 
            // txtnomcli
            // 
            this.txtnomcli.Location = new System.Drawing.Point(426, 38);
            this.txtnomcli.Name = "txtnomcli";
            this.txtnomcli.Size = new System.Drawing.Size(191, 20);
            this.txtnomcli.TabIndex = 109;
            this.txtnomcli.validar = true;
            // 
            // txtcodcli
            // 
            this.txtcodcli.Location = new System.Drawing.Point(104, 38);
            this.txtcodcli.Name = "txtcodcli";
            this.txtcodcli.Size = new System.Drawing.Size(191, 20);
            this.txtcodcli.TabIndex = 107;
            this.txtcodcli.validar = true;
            // 
            // jptextbox1
            // 
            this.jptextbox1.Location = new System.Drawing.Point(113, 58);
            this.jptextbox1.Name = "jptextbox1";
            this.jptextbox1.Size = new System.Drawing.Size(191, 20);
            this.jptextbox1.TabIndex = 107;
            this.jptextbox1.validar = true;
            // 
            // PFacturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1273, 1006);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.txtotal);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvdata);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.jptextbox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label8);
            this.Name = "PFacturacion";
            this.Text = "Facturacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label8;
        private jptextbox jptextbox1;
        public System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private jptextbox txtnomcli;
        public System.Windows.Forms.Label label5;
        private jptextbox txtcodcli;
        private System.Windows.Forms.GroupBox groupBox2;
        private jptextbox txtcantvent;
        public System.Windows.Forms.Label label7;
        private jptextbox txtprevent;
        public System.Windows.Forms.Label label6;
        private jptextbox txtnompro;
        public System.Windows.Forms.Label label2;
        private jptextbox txtcodpro;
        private System.Windows.Forms.DataGridView dgvdata;
        private jptextbox txtotal;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.GroupBox groupBox3;
        public System.Windows.Forms.Button btnbuscar;
        public System.Windows.Forms.Button btneliminar;
        public System.Windows.Forms.Button btnsalir;
        public System.Windows.Forms.Button btncancelar;
        public System.Windows.Forms.Button btnprocesar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.LinkLabel linkLabel2;
    }
}