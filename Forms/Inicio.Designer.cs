namespace OrganizadorJAEM
{
    partial class Inicio
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
            this.lbl_Nombre = new System.Windows.Forms.Label();
            this.lbl_Titulo = new System.Windows.Forms.Label();
            this.txb_Clave = new System.Windows.Forms.TextBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.btn_Aceptar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.mkTB_Carnet = new System.Windows.Forms.MaskedTextBox();
            this.cB_Recordar = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lbl_Nombre
            // 
            this.lbl_Nombre.AutoSize = true;
            this.lbl_Nombre.Location = new System.Drawing.Point(36, 52);
            this.lbl_Nombre.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbl_Nombre.Name = "lbl_Nombre";
            this.lbl_Nombre.Size = new System.Drawing.Size(82, 25);
            this.lbl_Nombre.TabIndex = 0;
            this.lbl_Nombre.Text = "Carnet:";
            // 
            // lbl_Titulo
            // 
            this.lbl_Titulo.AutoSize = true;
            this.lbl_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titulo.Location = new System.Drawing.Point(107, 9);
            this.lbl_Titulo.Name = "lbl_Titulo";
            this.lbl_Titulo.Size = new System.Drawing.Size(0, 29);
            this.lbl_Titulo.TabIndex = 5;
            // 
            // txb_Clave
            // 
            this.txb_Clave.Location = new System.Drawing.Point(203, 87);
            this.txb_Clave.Name = "txb_Clave";
            this.txb_Clave.PasswordChar = '*';
            this.txb_Clave.Size = new System.Drawing.Size(179, 31);
            this.txb_Clave.TabIndex = 6;
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Location = new System.Drawing.Point(29, 167);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(125, 34);
            this.btn_Cancelar.TabIndex = 11;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            this.btn_Cancelar.Click += new System.EventHandler(this.btn_Cancelar_Click);
            // 
            // btn_Aceptar
            // 
            this.btn_Aceptar.Location = new System.Drawing.Point(256, 167);
            this.btn_Aceptar.Name = "btn_Aceptar";
            this.btn_Aceptar.Size = new System.Drawing.Size(125, 34);
            this.btn_Aceptar.TabIndex = 12;
            this.btn_Aceptar.Text = "Aceptar";
            this.btn_Aceptar.UseVisualStyleBackColor = true;
            this.btn_Aceptar.Click += new System.EventHandler(this.btn_Aceptar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 93);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Contraseña:";
            // 
            // mkTB_Carnet
            // 
            this.mkTB_Carnet.Location = new System.Drawing.Point(203, 46);
            this.mkTB_Carnet.Mask = "0000000000";
            this.mkTB_Carnet.Name = "mkTB_Carnet";
            this.mkTB_Carnet.Size = new System.Drawing.Size(179, 31);
            this.mkTB_Carnet.TabIndex = 24;
            // 
            // cB_Recordar
            // 
            this.cB_Recordar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cB_Recordar.Location = new System.Drawing.Point(203, 127);
            this.cB_Recordar.Name = "cB_Recordar";
            this.cB_Recordar.Size = new System.Drawing.Size(95, 21);
            this.cB_Recordar.TabIndex = 25;
            this.cB_Recordar.Text = "Recordar";
            this.cB_Recordar.UseVisualStyleBackColor = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 220);
            this.Controls.Add(this.cB_Recordar);
            this.Controls.Add(this.mkTB_Carnet);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Aceptar);
            this.Controls.Add(this.btn_Cancelar);
            this.Controls.Add(this.txb_Clave);
            this.Controls.Add(this.lbl_Titulo);
            this.Controls.Add(this.lbl_Nombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Inicio";
            this.Text = "Iniciar Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Nombre;
        private System.Windows.Forms.Label lbl_Titulo;
        private System.Windows.Forms.TextBox txb_Clave;
        private System.Windows.Forms.Button btn_Cancelar;
        private System.Windows.Forms.Button btn_Aceptar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mkTB_Carnet;
        private System.Windows.Forms.CheckBox cB_Recordar;
    }
}