namespace WindowsFormsApp1
{
    partial class FrmCalculoArea
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCalculo = new System.Windows.Forms.Button();
            this.lblX = new System.Windows.Forms.Label();
            this.gpbFigura = new System.Windows.Forms.GroupBox();
            this.rdbParalelepipedo = new System.Windows.Forms.RadioButton();
            this.rdbRetangulo = new System.Windows.Forms.RadioButton();
            this.rdbQuadrado = new System.Windows.Forms.RadioButton();
            this.lblY = new System.Windows.Forms.Label();
            this.lblZ = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtZ = new System.Windows.Forms.TextBox();
            this.lblAreaVolume = new System.Windows.Forms.Label();
            this.txtAreaVol = new System.Windows.Forms.TextBox();
            this.btnLimpa = new System.Windows.Forms.Button();
            this.gpbFigura.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCalculo
            // 
            this.btnCalculo.Location = new System.Drawing.Point(190, 165);
            this.btnCalculo.Name = "btnCalculo";
            this.btnCalculo.Size = new System.Drawing.Size(75, 23);
            this.btnCalculo.TabIndex = 0;
            this.btnCalculo.Text = "Cálculo";
            this.btnCalculo.UseVisualStyleBackColor = true;
            this.btnCalculo.Click += new System.EventHandler(this.btnCalculo_Click);
            // 
            // lblX
            // 
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(187, 44);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(14, 13);
            this.lblX.TabIndex = 1;
            this.lblX.Text = "X";
            // 
            // gpbFigura
            // 
            this.gpbFigura.Controls.Add(this.rdbParalelepipedo);
            this.gpbFigura.Controls.Add(this.rdbRetangulo);
            this.gpbFigura.Controls.Add(this.rdbQuadrado);
            this.gpbFigura.Location = new System.Drawing.Point(17, 24);
            this.gpbFigura.Name = "gpbFigura";
            this.gpbFigura.Size = new System.Drawing.Size(123, 134);
            this.gpbFigura.TabIndex = 2;
            this.gpbFigura.TabStop = false;
            this.gpbFigura.Text = "Figura";
            // 
            // rdbParalelepipedo
            // 
            this.rdbParalelepipedo.AutoSize = true;
            this.rdbParalelepipedo.Location = new System.Drawing.Point(15, 97);
            this.rdbParalelepipedo.Name = "rdbParalelepipedo";
            this.rdbParalelepipedo.Size = new System.Drawing.Size(97, 17);
            this.rdbParalelepipedo.TabIndex = 5;
            this.rdbParalelepipedo.TabStop = true;
            this.rdbParalelepipedo.Text = "Paralelepípedo";
            this.rdbParalelepipedo.UseVisualStyleBackColor = true;
            this.rdbParalelepipedo.CheckedChanged += new System.EventHandler(this.rdbParalelepipedo_CheckedChanged);
            // 
            // rdbRetangulo
            // 
            this.rdbRetangulo.AutoSize = true;
            this.rdbRetangulo.Location = new System.Drawing.Point(15, 62);
            this.rdbRetangulo.Name = "rdbRetangulo";
            this.rdbRetangulo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rdbRetangulo.Size = new System.Drawing.Size(74, 17);
            this.rdbRetangulo.TabIndex = 4;
            this.rdbRetangulo.TabStop = true;
            this.rdbRetangulo.Text = "Retângulo";
            this.rdbRetangulo.UseVisualStyleBackColor = true;
            this.rdbRetangulo.CheckedChanged += new System.EventHandler(this.rdbRetangulo_CheckedChanged);
            // 
            // rdbQuadrado
            // 
            this.rdbQuadrado.AutoSize = true;
            this.rdbQuadrado.Location = new System.Drawing.Point(15, 30);
            this.rdbQuadrado.Name = "rdbQuadrado";
            this.rdbQuadrado.Size = new System.Drawing.Size(72, 17);
            this.rdbQuadrado.TabIndex = 3;
            this.rdbQuadrado.TabStop = true;
            this.rdbQuadrado.Text = "Quadrado";
            this.rdbQuadrado.UseVisualStyleBackColor = true;
            this.rdbQuadrado.CheckedChanged += new System.EventHandler(this.rdbQuadrado_CheckedChanged);
            // 
            // lblY
            // 
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(290, 44);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(14, 13);
            this.lblY.TabIndex = 3;
            this.lblY.Text = "Y";
            // 
            // lblZ
            // 
            this.lblZ.AutoSize = true;
            this.lblZ.Location = new System.Drawing.Point(396, 44);
            this.lblZ.Name = "lblZ";
            this.lblZ.Size = new System.Drawing.Size(14, 13);
            this.lblZ.TabIndex = 4;
            this.lblZ.Text = "Z";
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(158, 70);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(96, 20);
            this.txtX.TabIndex = 5;
            this.txtX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtX_KeyPress);
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(260, 70);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(96, 20);
            this.txtY.TabIndex = 6;
            // 
            // txtZ
            // 
            this.txtZ.Location = new System.Drawing.Point(362, 70);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(96, 20);
            this.txtZ.TabIndex = 7;
            // 
            // lblAreaVolume
            // 
            this.lblAreaVolume.AutoSize = true;
            this.lblAreaVolume.Location = new System.Drawing.Point(187, 125);
            this.lblAreaVolume.Name = "lblAreaVolume";
            this.lblAreaVolume.Size = new System.Drawing.Size(69, 13);
            this.lblAreaVolume.TabIndex = 8;
            this.lblAreaVolume.Text = "Área/Volume";
            // 
            // txtAreaVol
            // 
            this.txtAreaVol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.txtAreaVol.Location = new System.Drawing.Point(262, 120);
            this.txtAreaVol.Name = "txtAreaVol";
            this.txtAreaVol.Size = new System.Drawing.Size(96, 20);
            this.txtAreaVol.TabIndex = 9;
            // 
            // btnLimpa
            // 
            this.btnLimpa.Location = new System.Drawing.Point(293, 165);
            this.btnLimpa.Name = "btnLimpa";
            this.btnLimpa.Size = new System.Drawing.Size(75, 23);
            this.btnLimpa.TabIndex = 10;
            this.btnLimpa.Text = "Limpa";
            this.btnLimpa.UseVisualStyleBackColor = true;
            this.btnLimpa.Click += new System.EventHandler(this.btnLimpa_Click);
            // 
            // FrmCalculoArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 244);
            this.Controls.Add(this.btnLimpa);
            this.Controls.Add(this.txtAreaVol);
            this.Controls.Add(this.lblAreaVolume);
            this.Controls.Add(this.txtZ);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblZ);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.lblX);
            this.Controls.Add(this.gpbFigura);
            this.Controls.Add(this.btnCalculo);
            this.Name = "FrmCalculoArea";
            this.Text = "Cálculo de Área/Volume";
            this.gpbFigura.ResumeLayout(false);
            this.gpbFigura.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCalculo;
        private System.Windows.Forms.Label lblX;
        private System.Windows.Forms.GroupBox gpbFigura;
        private System.Windows.Forms.RadioButton rdbParalelepipedo;
        private System.Windows.Forms.RadioButton rdbRetangulo;
        private System.Windows.Forms.RadioButton rdbQuadrado;
        private System.Windows.Forms.Label lblY;
        private System.Windows.Forms.Label lblZ;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtZ;
        private System.Windows.Forms.Label lblAreaVolume;
        private System.Windows.Forms.TextBox txtAreaVol;
        private System.Windows.Forms.Button btnLimpa;
    }
}

