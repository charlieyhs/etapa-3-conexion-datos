namespace etapa3conexiondatos
{
    partial class FormDatos
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
            this.listadodatos = new System.Windows.Forms.DataGridView();
            this.btnnuevo = new System.Windows.Forms.Button();
            this.btnbuscar = new System.Windows.Forms.Button();
            this.inputbuscar = new System.Windows.Forms.TextBox();
            this.btnLimpiarFiltro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listadodatos)).BeginInit();
            this.SuspendLayout();
            // 
            // listadodatos
            // 
            this.listadodatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.listadodatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listadodatos.Location = new System.Drawing.Point(1, 73);
            this.listadodatos.Name = "listadodatos";
            this.listadodatos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.listadodatos.Size = new System.Drawing.Size(817, 424);
            this.listadodatos.TabIndex = 0;
            this.listadodatos.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.listadodatos_RowHeaderMouseDoubleClick);
            // 
            // btnnuevo
            // 
            this.btnnuevo.Location = new System.Drawing.Point(743, 3);
            this.btnnuevo.Name = "btnnuevo";
            this.btnnuevo.Size = new System.Drawing.Size(75, 23);
            this.btnnuevo.TabIndex = 6;
            this.btnnuevo.Text = "Nuevo";
            this.btnnuevo.UseVisualStyleBackColor = true;
            this.btnnuevo.Click += new System.EventHandler(this.btnnuevo_Click);
            // 
            // btnbuscar
            // 
            this.btnbuscar.Location = new System.Drawing.Point(327, 3);
            this.btnbuscar.Name = "btnbuscar";
            this.btnbuscar.Size = new System.Drawing.Size(75, 23);
            this.btnbuscar.TabIndex = 5;
            this.btnbuscar.Text = "Buscar";
            this.btnbuscar.UseVisualStyleBackColor = true;
            this.btnbuscar.Click += new System.EventHandler(this.btnbuscar_Click);
            // 
            // inputbuscar
            // 
            this.inputbuscar.Location = new System.Drawing.Point(1, 6);
            this.inputbuscar.Name = "inputbuscar";
            this.inputbuscar.Size = new System.Drawing.Size(320, 20);
            this.inputbuscar.TabIndex = 4;
            // 
            // btnLimpiarFiltro
            // 
            this.btnLimpiarFiltro.Location = new System.Drawing.Point(409, 3);
            this.btnLimpiarFiltro.Name = "btnLimpiarFiltro";
            this.btnLimpiarFiltro.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiarFiltro.TabIndex = 7;
            this.btnLimpiarFiltro.Text = "Limpiar Filtro";
            this.btnLimpiarFiltro.UseVisualStyleBackColor = true;
            this.btnLimpiarFiltro.Click += new System.EventHandler(this.btnLimpiarFiltro_Click);
            // 
            // FormDatos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 541);
            this.Controls.Add(this.btnLimpiarFiltro);
            this.Controls.Add(this.btnnuevo);
            this.Controls.Add(this.btnbuscar);
            this.Controls.Add(this.inputbuscar);
            this.Controls.Add(this.listadodatos);
            this.Name = "FormDatos";
            this.Text = "FormDatos";
            ((System.ComponentModel.ISupportInitialize)(this.listadodatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView listadodatos;
        private System.Windows.Forms.Button btnnuevo;
        private System.Windows.Forms.Button btnbuscar;
        private System.Windows.Forms.TextBox inputbuscar;
        private System.Windows.Forms.Button btnLimpiarFiltro;
    }
}