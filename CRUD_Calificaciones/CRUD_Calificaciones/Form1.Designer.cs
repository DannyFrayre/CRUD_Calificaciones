namespace CRUD_Calificaciones
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbCalificaciones = new System.Windows.Forms.Label();
            this.lbNC = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.lbCalculo = new System.Windows.Forms.Label();
            this.lbCalidad = new System.Windows.Forms.Label();
            this.lbIngles = new System.Windows.Forms.Label();
            this.lbAdmon = new System.Windows.Forms.Label();
            this.lbTopicos = new System.Windows.Forms.Label();
            this.lbxCal = new System.Windows.Forms.ListBox();
            this.tbNC = new System.Windows.Forms.TextBox();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbCalculo = new System.Windows.Forms.TextBox();
            this.tbCalidad = new System.Windows.Forms.TextBox();
            this.tbIngles = new System.Windows.Forms.TextBox();
            this.tbAdmon = new System.Windows.Forms.TextBox();
            this.tbTopicos = new System.Windows.Forms.TextBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbCalificaciones
            // 
            this.lbCalificaciones.AutoSize = true;
            this.lbCalificaciones.Font = new System.Drawing.Font("Kristen ITC", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalificaciones.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbCalificaciones.Location = new System.Drawing.Point(165, 20);
            this.lbCalificaciones.Name = "lbCalificaciones";
            this.lbCalificaciones.Size = new System.Drawing.Size(375, 66);
            this.lbCalificaciones.TabIndex = 0;
            this.lbCalificaciones.Text = "Calificaciones";
            // 
            // lbNC
            // 
            this.lbNC.AutoSize = true;
            this.lbNC.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbNC.Location = new System.Drawing.Point(8, 119);
            this.lbNC.Name = "lbNC";
            this.lbNC.Size = new System.Drawing.Size(206, 38);
            this.lbNC.TabIndex = 1;
            this.lbNC.Text = "Numero de control:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbNombre.Location = new System.Drawing.Point(111, 150);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(101, 38);
            this.lbNombre.TabIndex = 2;
            this.lbNombre.Text = "Nombre:\r\n";
            // 
            // lbCalculo
            // 
            this.lbCalculo.AutoSize = true;
            this.lbCalculo.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalculo.ForeColor = System.Drawing.Color.White;
            this.lbCalculo.Location = new System.Drawing.Point(111, 188);
            this.lbCalculo.Name = "lbCalculo";
            this.lbCalculo.Size = new System.Drawing.Size(97, 38);
            this.lbCalculo.TabIndex = 3;
            this.lbCalculo.Text = "Cálculo:";
            // 
            // lbCalidad
            // 
            this.lbCalidad.AutoSize = true;
            this.lbCalidad.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCalidad.ForeColor = System.Drawing.Color.White;
            this.lbCalidad.Location = new System.Drawing.Point(61, 226);
            this.lbCalidad.Name = "lbCalidad";
            this.lbCalidad.Size = new System.Drawing.Size(151, 38);
            this.lbCalidad.TabIndex = 4;
            this.lbCalidad.Text = "Calidad de SI:";
            // 
            // lbIngles
            // 
            this.lbIngles.AutoSize = true;
            this.lbIngles.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbIngles.ForeColor = System.Drawing.Color.White;
            this.lbIngles.Location = new System.Drawing.Point(128, 264);
            this.lbIngles.Name = "lbIngles";
            this.lbIngles.Size = new System.Drawing.Size(80, 38);
            this.lbIngles.TabIndex = 5;
            this.lbIngles.Text = "Inglés:";
            // 
            // lbAdmon
            // 
            this.lbAdmon.AutoSize = true;
            this.lbAdmon.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAdmon.ForeColor = System.Drawing.Color.White;
            this.lbAdmon.Location = new System.Drawing.Point(57, 302);
            this.lbAdmon.Name = "lbAdmon";
            this.lbAdmon.Size = new System.Drawing.Size(155, 38);
            this.lbAdmon.TabIndex = 6;
            this.lbAdmon.Text = "Admon de ser:";
            // 
            // lbTopicos
            // 
            this.lbTopicos.AutoSize = true;
            this.lbTopicos.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTopicos.ForeColor = System.Drawing.Color.White;
            this.lbTopicos.Location = new System.Drawing.Point(49, 340);
            this.lbTopicos.Name = "lbTopicos";
            this.lbTopicos.Size = new System.Drawing.Size(163, 38);
            this.lbTopicos.TabIndex = 7;
            this.lbTopicos.Text = "Tópicos de BD:";
            // 
            // lbxCal
            // 
            this.lbxCal.FormattingEnabled = true;
            this.lbxCal.Location = new System.Drawing.Point(453, 176);
            this.lbxCal.Name = "lbxCal";
            this.lbxCal.Size = new System.Drawing.Size(322, 186);
            this.lbxCal.TabIndex = 8;
            // 
            // tbNC
            // 
            this.tbNC.Location = new System.Drawing.Point(211, 127);
            this.tbNC.Name = "tbNC";
            this.tbNC.Size = new System.Drawing.Size(171, 20);
            this.tbNC.TabIndex = 9;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(211, 161);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(171, 20);
            this.tbNombre.TabIndex = 10;
            // 
            // tbCalculo
            // 
            this.tbCalculo.Location = new System.Drawing.Point(211, 199);
            this.tbCalculo.Name = "tbCalculo";
            this.tbCalculo.Size = new System.Drawing.Size(100, 20);
            this.tbCalculo.TabIndex = 11;
            // 
            // tbCalidad
            // 
            this.tbCalidad.Location = new System.Drawing.Point(211, 237);
            this.tbCalidad.Name = "tbCalidad";
            this.tbCalidad.Size = new System.Drawing.Size(100, 20);
            this.tbCalidad.TabIndex = 12;
            // 
            // tbIngles
            // 
            this.tbIngles.Location = new System.Drawing.Point(211, 275);
            this.tbIngles.Name = "tbIngles";
            this.tbIngles.Size = new System.Drawing.Size(100, 20);
            this.tbIngles.TabIndex = 13;
            // 
            // tbAdmon
            // 
            this.tbAdmon.Location = new System.Drawing.Point(211, 313);
            this.tbAdmon.Name = "tbAdmon";
            this.tbAdmon.Size = new System.Drawing.Size(100, 20);
            this.tbAdmon.TabIndex = 14;
            // 
            // tbTopicos
            // 
            this.tbTopicos.Location = new System.Drawing.Point(211, 351);
            this.tbTopicos.Name = "tbTopicos";
            this.tbTopicos.Size = new System.Drawing.Size(100, 20);
            this.tbTopicos.TabIndex = 15;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCreate.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.Location = new System.Drawing.Point(166, 406);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(145, 54);
            this.btnCreate.TabIndex = 16;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(619, 406);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(145, 54);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnUpdate.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(468, 406);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(145, 54);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnRead
            // 
            this.btnRead.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRead.Font = new System.Drawing.Font("Papyrus", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRead.Location = new System.Drawing.Point(317, 406);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(145, 54);
            this.btnRead.TabIndex = 19;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = false;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Uighur", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(532, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 38);
            this.label1.TabIndex = 20;
            this.label1.Text = "Base de Datos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(388, 119);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(96, 33);
            this.btnBuscar.TabIndex = 21;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(816, 487);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnCreate);
            this.Controls.Add(this.tbTopicos);
            this.Controls.Add(this.tbAdmon);
            this.Controls.Add(this.tbIngles);
            this.Controls.Add(this.tbCalidad);
            this.Controls.Add(this.tbCalculo);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.tbNC);
            this.Controls.Add(this.lbxCal);
            this.Controls.Add(this.lbTopicos);
            this.Controls.Add(this.lbAdmon);
            this.Controls.Add(this.lbIngles);
            this.Controls.Add(this.lbCalidad);
            this.Controls.Add(this.lbCalculo);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbNC);
            this.Controls.Add(this.lbCalificaciones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCalificaciones;
        private System.Windows.Forms.Label lbNC;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.Label lbCalculo;
        private System.Windows.Forms.Label lbCalidad;
        private System.Windows.Forms.Label lbIngles;
        private System.Windows.Forms.Label lbAdmon;
        private System.Windows.Forms.Label lbTopicos;
        private System.Windows.Forms.ListBox lbxCal;
        private System.Windows.Forms.TextBox tbNC;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbCalculo;
        private System.Windows.Forms.TextBox tbCalidad;
        private System.Windows.Forms.TextBox tbIngles;
        private System.Windows.Forms.TextBox tbAdmon;
        private System.Windows.Forms.TextBox tbTopicos;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
    }
}

