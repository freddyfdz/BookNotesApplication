namespace BookNotes
{
    partial class _3Interfazadm
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Regismat = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salir = new System.Windows.Forms.Button();
            this.Nomadm = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.crear = new System.Windows.Forms.Button();
            this.modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BookNotes.Properties.Resources.logo1;
            this.pictureBox1.Location = new System.Drawing.Point(41, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(749, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Regismat
            // 
            this.Regismat.AutoSize = true;
            this.Regismat.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regismat.Location = new System.Drawing.Point(294, 133);
            this.Regismat.Name = "Regismat";
            this.Regismat.Size = new System.Drawing.Size(278, 25);
            this.Regismat.TabIndex = 2;
            this.Regismat.Text = "Administracion de Usuario\r\n";
            this.Regismat.Click += new System.EventHandler(this.Regismat_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.modificar);
            this.panel1.Controls.Add(this.crear);
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.salir);
            this.panel1.Controls.Add(this.Nomadm);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel1.Location = new System.Drawing.Point(41, 173);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(766, 358);
            this.panel1.TabIndex = 3;
            // 
            // salir
            // 
            this.salir.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.salir.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salir.ForeColor = System.Drawing.Color.Black;
            this.salir.Location = new System.Drawing.Point(616, 290);
            this.salir.Name = "salir";
            this.salir.Size = new System.Drawing.Size(132, 49);
            this.salir.TabIndex = 2;
            this.salir.Text = "Salir";
            this.salir.UseVisualStyleBackColor = false;
            // 
            // Nomadm
            // 
            this.Nomadm.AutoSize = true;
            this.Nomadm.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nomadm.Location = new System.Drawing.Point(19, 13);
            this.Nomadm.Name = "Nomadm";
            this.Nomadm.Size = new System.Drawing.Size(124, 19);
            this.Nomadm.TabIndex = 0;
            this.Nomadm.Text = "Nombre Adm:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.38216F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.61783F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 47);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.59459F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.40541F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(730, 193);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // crear
            // 
            this.crear.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.crear.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.crear.ForeColor = System.Drawing.Color.Black;
            this.crear.Location = new System.Drawing.Point(17, 290);
            this.crear.Name = "crear";
            this.crear.Size = new System.Drawing.Size(132, 49);
            this.crear.TabIndex = 4;
            this.crear.Text = "Crear Usuario";
            this.crear.UseVisualStyleBackColor = false;
            // 
            // modificar
            // 
            this.modificar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.modificar.Font = new System.Drawing.Font("Maiandra GD", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificar.ForeColor = System.Drawing.Color.Black;
            this.modificar.Location = new System.Drawing.Point(316, 290);
            this.modificar.Name = "modificar";
            this.modificar.Size = new System.Drawing.Size(132, 49);
            this.modificar.TabIndex = 5;
            this.modificar.Text = "Modificar Usuario";
            this.modificar.UseVisualStyleBackColor = false;
            // 
            // _3Interfazadm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 559);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Regismat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "_3Interfazadm";
            this.Text = "_3Interfazadm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Regismat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button modificar;
        private System.Windows.Forms.Button crear;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button salir;
        private System.Windows.Forms.Label Nomadm;
    }
}