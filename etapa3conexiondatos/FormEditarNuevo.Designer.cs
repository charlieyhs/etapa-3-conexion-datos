namespace etapa3conexiondatos
{
    partial class FormEditarNuevo
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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnVolver = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.inputNroIdentidad = new System.Windows.Forms.TextBox();
            this.inputNombres = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.inputApellidos = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputTelefono = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.inputCargo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.inputOficina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnfoto = new System.Windows.Forms.Button();
            this.pictureImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(12, 415);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(84, 31);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(102, 415);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(84, 31);
            this.btnEliminar.TabIndex = 1;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(12, 2);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(84, 31);
            this.btnVolver.TabIndex = 2;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(77, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Numero Identidad";
            // 
            // inputNroIdentidad
            // 
            this.inputNroIdentidad.Location = new System.Drawing.Point(213, 88);
            this.inputNroIdentidad.Name = "inputNroIdentidad";
            this.inputNroIdentidad.Size = new System.Drawing.Size(280, 20);
            this.inputNroIdentidad.TabIndex = 4;
            this.inputNroIdentidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputNroIdentidad_KeyPress);
            // 
            // inputNombres
            // 
            this.inputNombres.Location = new System.Drawing.Point(213, 122);
            this.inputNombres.Name = "inputNombres";
            this.inputNombres.Size = new System.Drawing.Size(280, 20);
            this.inputNombres.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(77, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Nombres";
            // 
            // inputApellidos
            // 
            this.inputApellidos.Location = new System.Drawing.Point(213, 157);
            this.inputApellidos.Name = "inputApellidos";
            this.inputApellidos.Size = new System.Drawing.Size(280, 20);
            this.inputApellidos.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(77, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Apellidos";
            // 
            // inputTelefono
            // 
            this.inputTelefono.Location = new System.Drawing.Point(213, 191);
            this.inputTelefono.Name = "inputTelefono";
            this.inputTelefono.Size = new System.Drawing.Size(280, 20);
            this.inputTelefono.TabIndex = 10;
            this.inputTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inputTelefono_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(77, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Telefono";
            // 
            // inputCargo
            // 
            this.inputCargo.Location = new System.Drawing.Point(213, 225);
            this.inputCargo.Name = "inputCargo";
            this.inputCargo.Size = new System.Drawing.Size(280, 20);
            this.inputCargo.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.Location = new System.Drawing.Point(77, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Cargo";
            // 
            // inputOficina
            // 
            this.inputOficina.Location = new System.Drawing.Point(213, 259);
            this.inputOficina.Name = "inputOficina";
            this.inputOficina.Size = new System.Drawing.Size(280, 20);
            this.inputOficina.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label6.Location = new System.Drawing.Point(77, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Oficina";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label7.Location = new System.Drawing.Point(77, 307);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Foto";
            // 
            // btnfoto
            // 
            this.btnfoto.Location = new System.Drawing.Point(213, 307);
            this.btnfoto.Name = "btnfoto";
            this.btnfoto.Size = new System.Drawing.Size(85, 23);
            this.btnfoto.TabIndex = 16;
            this.btnfoto.Text = "Cargar";
            this.btnfoto.UseVisualStyleBackColor = true;
            this.btnfoto.Click += new System.EventHandler(this.btnfoto_Click);
            // 
            // pictureImg
            // 
            this.pictureImg.Location = new System.Drawing.Point(333, 307);
            this.pictureImg.Name = "pictureImg";
            this.pictureImg.Size = new System.Drawing.Size(100, 100);
            this.pictureImg.TabIndex = 17;
            this.pictureImg.TabStop = false;
            // 
            // FormEditarNuevo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 458);
            this.Controls.Add(this.pictureImg);
            this.Controls.Add(this.btnfoto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.inputOficina);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.inputCargo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.inputTelefono);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputApellidos);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputNombres);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inputNroIdentidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnGuardar);
            this.Name = "FormEditarNuevo";
            this.Text = "FormEditarNuevo";
            ((System.ComponentModel.ISupportInitialize)(this.pictureImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputNroIdentidad;
        private System.Windows.Forms.TextBox inputNombres;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputApellidos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputTelefono;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inputCargo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox inputOficina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnfoto;
        private System.Windows.Forms.PictureBox pictureImg;
    }
}