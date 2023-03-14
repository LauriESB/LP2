namespace Calculadora
{
    partial class Form1
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
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnMpy = new System.Windows.Forms.Button();
            this.btnDiv = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN1.Location = new System.Drawing.Point(353, 178);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(94, 24);
            this.lblN1.TabIndex = 0;
            this.lblN1.Text = "Número 1";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblN2.Location = new System.Drawing.Point(353, 223);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(94, 24);
            this.lblN2.TabIndex = 1;
            this.lblN2.Text = "Número 2";
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResult.Location = new System.Drawing.Point(357, 274);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(94, 24);
            this.lblResult.TabIndex = 2;
            this.lblResult.Text = "Resultado";
            // 
            // txtN1
            // 
            this.txtN1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN1.Location = new System.Drawing.Point(465, 172);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(100, 29);
            this.txtN1.TabIndex = 3;
            this.txtN1.TextChanged += new System.EventHandler(this.TxtN1_TextChanged);
            this.txtN1.Validated += new System.EventHandler(this.TxtN1_Validated);
            // 
            // txtN2
            // 
            this.txtN2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN2.Location = new System.Drawing.Point(465, 223);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(100, 29);
            this.txtN2.TabIndex = 4;
            this.txtN2.Validated += new System.EventHandler(this.TxtN2_Validated);
            // 
            // txtN3
            // 
            this.txtN3.Enabled = false;
            this.txtN3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtN3.Location = new System.Drawing.Point(465, 273);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(100, 29);
            this.txtN3.TabIndex = 5;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(664, 174);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(99, 51);
            this.btnLimpar.TabIndex = 6;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(664, 250);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 51);
            this.btnSair.TabIndex = 7;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(308, 373);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(101, 53);
            this.btnSoma.TabIndex = 8;
            this.btnSoma.Text = "Somar";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.BtnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(424, 373);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(101, 53);
            this.btnSub.TabIndex = 9;
            this.btnSub.Text = "Subtrair";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.BtnSub_Click);
            // 
            // btnMpy
            // 
            this.btnMpy.Location = new System.Drawing.Point(543, 373);
            this.btnMpy.Name = "btnMpy";
            this.btnMpy.Size = new System.Drawing.Size(101, 54);
            this.btnMpy.TabIndex = 10;
            this.btnMpy.Text = "Multiplicar";
            this.btnMpy.UseVisualStyleBackColor = true;
            this.btnMpy.Click += new System.EventHandler(this.BtnMpy_Click);
            // 
            // btnDiv
            // 
            this.btnDiv.Location = new System.Drawing.Point(662, 373);
            this.btnDiv.Name = "btnDiv";
            this.btnDiv.Size = new System.Drawing.Size(101, 54);
            this.btnDiv.TabIndex = 11;
            this.btnDiv.Text = "Dividir";
            this.btnDiv.UseVisualStyleBackColor = true;
            this.btnDiv.Click += new System.EventHandler(this.BtnDiv_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(458, 61);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(218, 42);
            this.lblTitulo.TabIndex = 12;
            this.lblTitulo.Text = "Calculadora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnDiv);
            this.Controls.Add(this.btnMpy);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtN3);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtN1);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblN2);
            this.Controls.Add(this.lblN1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnMpy;
        private System.Windows.Forms.Button btnDiv;
        private System.Windows.Forms.Label lblTitulo;
    }
}

