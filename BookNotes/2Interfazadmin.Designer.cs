namespace BookNotes
{
    partial class _2Interfazadmin
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
            this.Nomadm = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.Nomateria = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Regismat = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.Nomateria);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.Nomadm);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(27, 175);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 268);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookNotes.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(27, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(488, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Nomadm
            // 
            this.Nomadm.AutoSize = true;
            this.Nomadm.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomadm.Location = new System.Drawing.Point(3, 10);
            this.Nomadm.Name = "Nomadm";
            this.Nomadm.Size = new System.Drawing.Size(124, 19);
            this.Nomadm.TabIndex = 0;
            this.Nomadm.Text = "Nombre Adm:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button2.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Black;
            this.button2.Location = new System.Drawing.Point(327, 194);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 49);
            this.button2.TabIndex = 2;
            this.button2.Text = "Registrar Materia";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Nomateria
            // 
            this.Nomateria.AutoSize = true;
            this.Nomateria.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomateria.Location = new System.Drawing.Point(36, 109);
            this.Nomateria.Name = "Nomateria";
            this.Nomateria.Size = new System.Drawing.Size(148, 19);
            this.Nomateria.TabIndex = 3;
            this.Nomateria.Text = "Nombre Materia:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(215, 110);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(204, 20);
            this.textBox1.TabIndex = 4;
            // 
            // Regismat
            // 
            this.Regismat.AutoSize = true;
            this.Regismat.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regismat.Location = new System.Drawing.Point(162, 129);
            this.Regismat.Name = "Regismat";
            this.Regismat.Size = new System.Drawing.Size(220, 25);
            this.Regismat.TabIndex = 1;
            this.Regismat.Text = "Registro De Materias";
            // 
            // _2Interfazadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 455);
            this.Controls.Add(this.Regismat);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "_2Interfazadmin";
            this.Text = "_2Interfazadmin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Nomadm;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label Nomateria;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label Regismat;
    }
}