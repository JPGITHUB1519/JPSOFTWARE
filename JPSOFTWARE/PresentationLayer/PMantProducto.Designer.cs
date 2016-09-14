namespace PresentationLayer
{
    partial class PMantProducto
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtcodcategoria = new PresentationLayer.jptextbox(this.components);
            this.txtcodigo = new PresentationLayer.jptextbox(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcodproveedor = new PresentationLayer.jptextbox(this.components);
            this.txtnombre = new PresentationLayer.jptextbox(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.txtprecio = new PresentationLayer.jptextbox(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.txtstock = new PresentationLayer.jptextbox(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.txtpuntreo = new PresentationLayer.jptextbox(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.txtimpuesto = new PresentationLayer.jptextbox(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.tabplistado.SuspendLayout();
            this.tabpmantenimiento.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Size = new System.Drawing.Size(346, 29);
            this.label8.Text = "Mantenimiento de Productos";
            // 
            // tabplistado
            // 
            this.tabplistado.Controls.Add(this.dataGridView1);
            this.tabplistado.Controls.SetChildIndex(this.btn_buscar2, 0);
            this.tabplistado.Controls.SetChildIndex(this.label2, 0);
            this.tabplistado.Controls.SetChildIndex(this.txtbuscar, 0);
            this.tabplistado.Controls.SetChildIndex(this.btnimprimir, 0);
            this.tabplistado.Controls.SetChildIndex(this.dataGridView1, 0);
            // 
            // tabpmantenimiento
            // 
            this.tabpmantenimiento.Size = new System.Drawing.Size(847, 561);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtimpuesto);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtpuntreo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.txtstock);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtprecio);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtnombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtcodproveedor);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtcodcategoria);
            this.groupBox1.Controls.Add(this.txtcodigo);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Size = new System.Drawing.Size(835, 331);
            this.groupBox1.Text = "Impuesto";
            // 
            // tabControl1
            // 
            this.tabControl1.Size = new System.Drawing.Size(855, 587);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(45, 110);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(656, 428);
            this.dataGridView1.TabIndex = 74;
            // 
            // txtcodcategoria
            // 
            this.txtcodcategoria.Location = new System.Drawing.Point(200, 109);
            this.txtcodcategoria.Name = "txtcodcategoria";
            this.txtcodcategoria.Size = new System.Drawing.Size(191, 20);
            this.txtcodcategoria.TabIndex = 95;
            this.txtcodcategoria.validar = true;
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(200, 54);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(191, 20);
            this.txtcodigo.TabIndex = 94;
            this.txtcodigo.validar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(33, 107);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 20);
            this.label7.TabIndex = 93;
            this.label7.Text = "Cod.Categoria";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 92;
            this.label3.Text = "Codigo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 20);
            this.label1.TabIndex = 96;
            this.label1.Text = "Cod.Proveedor";
            // 
            // txtcodproveedor
            // 
            this.txtcodproveedor.Location = new System.Drawing.Point(200, 166);
            this.txtcodproveedor.Name = "txtcodproveedor";
            this.txtcodproveedor.Size = new System.Drawing.Size(191, 20);
            this.txtcodproveedor.TabIndex = 97;
            this.txtcodproveedor.validar = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(200, 218);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(191, 20);
            this.txtnombre.TabIndex = 99;
            this.txtnombre.validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 214);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 98;
            this.label4.Text = "Nombre";
            // 
            // txtprecio
            // 
            this.txtprecio.Location = new System.Drawing.Point(606, 54);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(191, 20);
            this.txtprecio.TabIndex = 101;
            this.txtprecio.validar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(439, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 100;
            this.label5.Text = "Precio";
            // 
            // txtstock
            // 
            this.txtstock.Location = new System.Drawing.Point(606, 109);
            this.txtstock.Name = "txtstock";
            this.txtstock.Size = new System.Drawing.Size(191, 20);
            this.txtstock.TabIndex = 103;
            this.txtstock.validar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(439, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 102;
            this.label6.Text = "Stock";
            // 
            // txtpuntreo
            // 
            this.txtpuntreo.Location = new System.Drawing.Point(606, 166);
            this.txtpuntreo.Name = "txtpuntreo";
            this.txtpuntreo.Size = new System.Drawing.Size(191, 20);
            this.txtpuntreo.TabIndex = 105;
            this.txtpuntreo.validar = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(439, 162);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(117, 20);
            this.label9.TabIndex = 104;
            this.label9.Text = "Punto Reorden";
            // 
            // txtimpuesto
            // 
            this.txtimpuesto.Location = new System.Drawing.Point(606, 218);
            this.txtimpuesto.Name = "txtimpuesto";
            this.txtimpuesto.Size = new System.Drawing.Size(191, 20);
            this.txtimpuesto.TabIndex = 107;
            this.txtimpuesto.validar = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(439, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 20);
            this.label10.TabIndex = 106;
            this.label10.Text = "Impuesto";
            // 
            // PMantProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 655);
            this.Name = "PMantProducto";
            this.Text = "PMantProducto";
            this.Load += new System.EventHandler(this.PMantProducto_Load);
            this.tabplistado.ResumeLayout(false);
            this.tabplistado.PerformLayout();
            this.tabpmantenimiento.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errprov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private jptextbox txtimpuesto;
        public System.Windows.Forms.Label label10;
        private jptextbox txtpuntreo;
        public System.Windows.Forms.Label label9;
        private jptextbox txtstock;
        public System.Windows.Forms.Label label6;
        private jptextbox txtprecio;
        public System.Windows.Forms.Label label5;
        private jptextbox txtnombre;
        public System.Windows.Forms.Label label4;
        private jptextbox txtcodproveedor;
        public System.Windows.Forms.Label label1;
        private jptextbox txtcodcategoria;
        private jptextbox txtcodigo;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label3;
    }
}