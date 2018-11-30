namespace BookNotes
{
    partial class Registro
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cancelar = new System.Windows.Forms.Button();
            this.guardar = new System.Windows.Forms.Button();
            this.checkBoxmaterias = new System.Windows.Forms.CheckedListBox();
            this.comboBoxcurso = new System.Windows.Forms.ComboBox();
            this.comboBoxrol = new System.Windows.Forms.ComboBox();
            this.materias = new System.Windows.Forms.Label();
            this.rol = new System.Windows.Forms.Label();
            this.curso = new System.Windows.Forms.Label();
            this.textBoxapellidos = new System.Windows.Forms.TextBox();
            this.textBoxid = new System.Windows.Forms.TextBox();
            this.textBoxnombres = new System.Windows.Forms.TextBox();
            this.apellidos = new System.Windows.Forms.Label();
            this.id = new System.Windows.Forms.Label();
            this.nombres = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NomUsuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.NomUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cancelar);
            this.panel1.Controls.Add(this.guardar);
            this.panel1.Controls.Add(this.checkBoxmaterias);
            this.panel1.Controls.Add(this.comboBoxcurso);
            this.panel1.Controls.Add(this.comboBoxrol);
            this.panel1.Controls.Add(this.materias);
            this.panel1.Controls.Add(this.rol);
            this.panel1.Controls.Add(this.curso);
            this.panel1.Controls.Add(this.textBoxapellidos);
            this.panel1.Controls.Add(this.textBoxid);
            this.panel1.Controls.Add(this.textBoxnombres);
            this.panel1.Controls.Add(this.apellidos);
            this.panel1.Controls.Add(this.id);
            this.panel1.Controls.Add(this.nombres);
            this.panel1.Location = new System.Drawing.Point(26, 26);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(583, 468);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // cancelar
            // 
            this.cancelar.BackColor = System.Drawing.Color.SkyBlue;
            this.cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelar.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelar.Location = new System.Drawing.Point(338, 404);
            this.cancelar.Name = "cancelar";
            this.cancelar.Size = new System.Drawing.Size(146, 36);
            this.cancelar.TabIndex = 13;
            this.cancelar.Text = "Cancelar";
            this.cancelar.UseVisualStyleBackColor = false;
            // 
            // guardar
            // 
            this.guardar.BackColor = System.Drawing.Color.SkyBlue;
            this.guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.guardar.Font = new System.Drawing.Font("Maiandra GD", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guardar.Location = new System.Drawing.Point(46, 404);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(146, 36);
            this.guardar.TabIndex = 12;
            this.guardar.Text = "Guardar";
            this.guardar.UseVisualStyleBackColor = false;
            // 
            // checkBoxmaterias
            // 
            this.checkBoxmaterias.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxmaterias.FormattingEnabled = true;
            this.checkBoxmaterias.Location = new System.Drawing.Point(244, 318);
            this.checkBoxmaterias.Name = "checkBoxmaterias";
            this.checkBoxmaterias.Size = new System.Drawing.Size(271, 64);
            this.checkBoxmaterias.TabIndex = 11;
            // 
            // comboBoxcurso
            // 
            this.comboBoxcurso.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxcurso.FormattingEnabled = true;
            this.comboBoxcurso.Items.AddRange(new object[] {
            "Alumno",
            "Profesor"});
            this.comboBoxcurso.Location = new System.Drawing.Point(245, 268);
            this.comboBoxcurso.Name = "comboBoxcurso";
            this.comboBoxcurso.Size = new System.Drawing.Size(272, 26);
            this.comboBoxcurso.TabIndex = 10;
            this.comboBoxcurso.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // comboBoxrol
            // 
            this.comboBoxrol.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxrol.FormattingEnabled = true;
            this.comboBoxrol.Items.AddRange(new object[] {
            "Alumno",
            "Profesor"});
            this.comboBoxrol.Location = new System.Drawing.Point(245, 227);
            this.comboBoxrol.Name = "comboBoxrol";
            this.comboBoxrol.Size = new System.Drawing.Size(272, 26);
            this.comboBoxrol.TabIndex = 9;
            this.comboBoxrol.SelectedIndexChanged += new System.EventHandler(this.comboBoxrol_SelectedIndexChanged);
            // 
            // materias
            // 
            this.materias.AutoSize = true;
            this.materias.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materias.Location = new System.Drawing.Point(20, 318);
            this.materias.Name = "materias";
            this.materias.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.materias.Size = new System.Drawing.Size(82, 19);
            this.materias.TabIndex = 8;
            this.materias.Text = "Materias:";
            // 
            // rol
            // 
            this.rol.AutoSize = true;
            this.rol.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rol.Location = new System.Drawing.Point(20, 229);
            this.rol.Name = "rol";
            this.rol.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rol.Size = new System.Drawing.Size(42, 19);
            this.rol.TabIndex = 7;
            this.rol.Text = "Rol:";
            this.rol.Click += new System.EventHandler(this.label2_Click);
            // 
            // curso
            // 
            this.curso.AutoSize = true;
            this.curso.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curso.Location = new System.Drawing.Point(20, 267);
            this.curso.Name = "curso";
            this.curso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.curso.Size = new System.Drawing.Size(61, 19);
            this.curso.TabIndex = 6;
            this.curso.Text = "Curso:";
            // 
            // textBoxapellidos
            // 
            this.textBoxapellidos.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxapellidos.Location = new System.Drawing.Point(244, 75);
            this.textBoxapellidos.Name = "textBoxapellidos";
            this.textBoxapellidos.Size = new System.Drawing.Size(272, 25);
            this.textBoxapellidos.TabIndex = 5;
            this.textBoxapellidos.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBoxid
            // 
            this.textBoxid.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxid.HideSelection = false;
            this.textBoxid.Location = new System.Drawing.Point(245, 121);
            this.textBoxid.Name = "textBoxid";
            this.textBoxid.Size = new System.Drawing.Size(272, 25);
            this.textBoxid.TabIndex = 4;
            this.textBoxid.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxnombres
            // 
            this.textBoxnombres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxnombres.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxnombres.Location = new System.Drawing.Point(245, 32);
            this.textBoxnombres.Name = "textBoxnombres";
            this.textBoxnombres.Size = new System.Drawing.Size(272, 25);
            this.textBoxnombres.TabIndex = 3;
            // 
            // apellidos
            // 
            this.apellidos.AutoSize = true;
            this.apellidos.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidos.Location = new System.Drawing.Point(19, 76);
            this.apellidos.Name = "apellidos";
            this.apellidos.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.apellidos.Size = new System.Drawing.Size(88, 19);
            this.apellidos.TabIndex = 2;
            this.apellidos.Text = "Apellidos:";
            // 
            // id
            // 
            this.id.AutoSize = true;
            this.id.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.id.Location = new System.Drawing.Point(20, 122);
            this.id.Name = "id";
            this.id.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.id.Size = new System.Drawing.Size(123, 19);
            this.id.TabIndex = 1;
            this.id.Text = "Identificacion:";
            // 
            // nombres
            // 
            this.nombres.AutoSize = true;
            this.nombres.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombres.Location = new System.Drawing.Point(20, 33);
            this.nombres.Name = "nombres";
            this.nombres.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.nombres.Size = new System.Drawing.Size(87, 19);
            this.nombres.TabIndex = 0;
            this.nombres.Text = "Nombres:";
            this.nombres.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 175);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(170, 19);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre de usuario:";
            // 
            // NomUsuario
            // 
            this.NomUsuario.Font = new System.Drawing.Font("Maiandra GD", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NomUsuario.HideSelection = false;
            this.NomUsuario.Location = new System.Drawing.Point(244, 187);
            this.NomUsuario.Name = "NomUsuario";
            this.NomUsuario.Size = new System.Drawing.Size(272, 25);
            this.NomUsuario.TabIndex = 15;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "El nombre del usuario esta determinado por la \r\nprimera letra del primer nombre y" +
    " el primer apellido.";
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(630, 511);
            this.Controls.Add(this.panel1);
            this.Name = "Registro";
            this.Text = "Registro";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label nombres;
        private System.Windows.Forms.Label apellidos;
        private System.Windows.Forms.Label id;
        private System.Windows.Forms.TextBox textBoxapellidos;
        private System.Windows.Forms.TextBox textBoxid;
        private System.Windows.Forms.TextBox textBoxnombres;
        private System.Windows.Forms.Label materias;
        private System.Windows.Forms.Label rol;
        private System.Windows.Forms.Label curso;
        private System.Windows.Forms.ComboBox comboBoxrol;
        private System.Windows.Forms.ComboBox comboBoxcurso;
        private System.Windows.Forms.CheckedListBox checkBoxmaterias;
        private System.Windows.Forms.Button guardar;
        private System.Windows.Forms.Button cancelar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NomUsuario;
        private System.Windows.Forms.Label label1;
    }
}