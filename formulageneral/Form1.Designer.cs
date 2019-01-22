namespace formulageneral
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txta = new System.Windows.Forms.TextBox();
            this.txtb = new System.Windows.Forms.TextBox();
            this.txtc = new System.Windows.Forms.TextBox();
            this.btnresolver = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.lblx2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txta
            // 
            this.txta.Location = new System.Drawing.Point(31, 27);
            this.txta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txta.Name = "txta";
            this.txta.Size = new System.Drawing.Size(68, 20);
            this.txta.TabIndex = 0;
            this.txta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txta_KeyPress);
            // 
            // txtb
            // 
            this.txtb.Location = new System.Drawing.Point(31, 55);
            this.txtb.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtb.Name = "txtb";
            this.txtb.Size = new System.Drawing.Size(68, 20);
            this.txtb.TabIndex = 1;
            this.txtb.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtb_KeyPress);
            // 
            // txtc
            // 
            this.txtc.Location = new System.Drawing.Point(31, 79);
            this.txtc.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtc.Name = "txtc";
            this.txtc.Size = new System.Drawing.Size(68, 20);
            this.txtc.TabIndex = 2;
            this.txtc.TextChanged += new System.EventHandler(this.txtc_TextChanged);
            this.txtc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtc_KeyPress);
            // 
            // btnresolver
            // 
            this.btnresolver.Location = new System.Drawing.Point(31, 113);
            this.btnresolver.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnresolver.Name = "btnresolver";
            this.btnresolver.Size = new System.Drawing.Size(77, 51);
            this.btnresolver.TabIndex = 3;
            this.btnresolver.Text = "Resolver";
            this.btnresolver.UseVisualStyleBackColor = true;
            this.btnresolver.Click += new System.EventHandler(this.btnresolver_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(147, 12);
            this.lblresultado.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(0, 13);
            this.lblresultado.TabIndex = 4;
            this.lblresultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // lblx2
            // 
            this.lblx2.AutoSize = true;
            this.lblx2.Location = new System.Drawing.Point(147, 36);
            this.lblx2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblx2.Name = "lblx2";
            this.lblx2.Size = new System.Drawing.Size(0, 13);
            this.lblx2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "A";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 57);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "B";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "C";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(139, 57);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 128);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 192);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblx2);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.btnresolver);
            this.Controls.Add(this.txtc);
            this.Controls.Add(this.txtb);
            this.Controls.Add(this.txta);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Formula general";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txta;
        private System.Windows.Forms.TextBox txtb;
        private System.Windows.Forms.TextBox txtc;
        private System.Windows.Forms.Button btnresolver;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.Label lblx2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

