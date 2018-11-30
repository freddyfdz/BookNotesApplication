namespace BookNotes
{
    partial class _1interfazadmin
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Admaterias = new System.Windows.Forms.Button();
            this.AdUsuario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.AdUsuario);
            this.panel1.Controls.Add(this.Admaterias);
            this.panel1.Location = new System.Drawing.Point(18, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 286);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookNotes.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(18, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(511, 75);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Admaterias
            // 
            this.Admaterias.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Admaterias.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Admaterias.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Admaterias.Location = new System.Drawing.Point(165, 73);
            this.Admaterias.Name = "Admaterias";
            this.Admaterias.Size = new System.Drawing.Size(156, 54);
            this.Admaterias.TabIndex = 0;
            this.Admaterias.Text = "Administrar Materias";
            this.Admaterias.UseVisualStyleBackColor = false;
            this.Admaterias.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdUsuario
            // 
            this.AdUsuario.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.AdUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AdUsuario.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdUsuario.Location = new System.Drawing.Point(165, 176);
            this.AdUsuario.Name = "AdUsuario";
            this.AdUsuario.Size = new System.Drawing.Size(156, 54);
            this.AdUsuario.TabIndex = 1;
            this.AdUsuario.Text = "Administrar Usuarios";
            this.AdUsuario.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre Adm:";
            // 
            // _1interfazadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(559, 424);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "_1interfazadmin";
            this.Text = "_1interfazadmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button AdUsuario;
        private System.Windows.Forms.Button Admaterias;
        private System.Windows.Forms.Label label2;
    }
}