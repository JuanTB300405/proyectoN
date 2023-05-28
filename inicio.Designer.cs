namespace PROYECTONINJA
{
    partial class inicio
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
            this.label1 = new System.Windows.Forms.Label();
            this.txt_nombrejugador = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_iniciarPP = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(126, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(566, 83);
            this.label1.TabIndex = 0;
            this.label1.Text = "¡NINJA WHITE!";
            // 
            // txt_nombrejugador
            // 
            this.txt_nombrejugador.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_nombrejugador.Depth = 0;
            this.txt_nombrejugador.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txt_nombrejugador.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txt_nombrejugador.Hint = "Jugador #1";
            this.txt_nombrejugador.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_nombrejugador.Location = new System.Drawing.Point(331, 271);
            this.txt_nombrejugador.MouseState = MaterialSkin.MouseState.HOVER;
            this.txt_nombrejugador.Name = "txt_nombrejugador";
            this.txt_nombrejugador.PasswordChar = '\0';
            this.txt_nombrejugador.SelectedText = "";
            this.txt_nombrejugador.SelectionLength = 0;
            this.txt_nombrejugador.SelectionStart = 0;
            this.txt_nombrejugador.Size = new System.Drawing.Size(133, 32);
            this.txt_nombrejugador.TabIndex = 1;
            this.txt_nombrejugador.UseSystemPasswordChar = false;
            // 
            // btn_iniciarPP
            // 
            this.btn_iniciarPP.BackColor = System.Drawing.Color.Transparent;
            this.btn_iniciarPP.Depth = 0;
            this.btn_iniciarPP.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_iniciarPP.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btn_iniciarPP.Location = new System.Drawing.Point(318, 328);
            this.btn_iniciarPP.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_iniciarPP.Name = "btn_iniciarPP";
            this.btn_iniciarPP.Primary = true;
            this.btn_iniciarPP.Size = new System.Drawing.Size(146, 47);
            this.btn_iniciarPP.TabIndex = 3;
            this.btn_iniciarPP.Text = "jugar";
            this.btn_iniciarPP.UseVisualStyleBackColor = false;
            this.btn_iniciarPP.Click += new System.EventHandler(this.btn_iniciarPP_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::PROYECTONINJA.Properties.Resources.fondo_pagprin;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_iniciarPP);
            this.Controls.Add(this.txt_nombrejugador);
            this.Controls.Add(this.label1);
            this.Name = "inicio";
            this.Text = "inicio";
            this.Load += new System.EventHandler(this.inicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private MaterialSkin.Controls.MaterialSingleLineTextField txt_nombrejugador;
        private MaterialSkin.Controls.MaterialRaisedButton btn_iniciarPP;
    }
}