namespace PresentationLayer
{
    partial class PConsCategoria
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
            this.dgvdata = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btnimprimir
            // 
            this.btnimprimir.Location = new System.Drawing.Point(596, 65);
            // 
            // txtbuscar
            // 
            this.txtbuscar.Location = new System.Drawing.Point(145, 92);
            this.txtbuscar.Validating += new System.ComponentModel.CancelEventHandler(this.txtbuscar_Validating);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(55, 92);
            // 
            // btn_buscar2
            // 
            this.btn_buscar2.Location = new System.Drawing.Point(484, 65);
            this.btn_buscar2.Click += new System.EventHandler(this.btn_buscar2_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(239, 533);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // dgvdata
            // 
            this.dgvdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdata.Location = new System.Drawing.Point(52, 143);
            this.dgvdata.Name = "dgvdata";
            this.dgvdata.Size = new System.Drawing.Size(662, 375);
            this.dgvdata.TabIndex = 81;
            this.dgvdata.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdata_CellDoubleClick);
            // 
            // PConsCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(744, 667);
            this.Controls.Add(this.dgvdata);
            this.Name = "PConsCategoria";
            this.Text = "PConsCategoria";
            this.Load += new System.EventHandler(this.PConsCategoria_Load);
            this.Controls.SetChildIndex(this.btn_buscar2, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtbuscar, 0);
            this.Controls.SetChildIndex(this.btnimprimir, 0);
            this.Controls.SetChildIndex(this.label8, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.dgvdata, 0);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.DataGridView dgvdata;

    }
}