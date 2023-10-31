
namespace applicacion
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
            this.textususario2 = new System.Windows.Forms.TextBox();
            this.textcontraseña2 = new System.Windows.Forms.TextBox();
            this.cuenta = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // textususario2
            // 
            this.textususario2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textususario2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textususario2.Font = new System.Drawing.Font("Tahoma", 12F);
            this.textususario2.Location = new System.Drawing.Point(121, 121);
            this.textususario2.Name = "textususario2";
            this.textususario2.Size = new System.Drawing.Size(129, 20);
            this.textususario2.TabIndex = 1;
            this.textususario2.TextChanged += new System.EventHandler(this.ususario_TextChanged);
            // 
            // textcontraseña2
            // 
            this.textcontraseña2.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.textcontraseña2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textcontraseña2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textcontraseña2.Location = new System.Drawing.Point(121, 194);
            this.textcontraseña2.Name = "textcontraseña2";
            this.textcontraseña2.PasswordChar = '*';
            this.textcontraseña2.Size = new System.Drawing.Size(129, 20);
            this.textcontraseña2.TabIndex = 2;
            // 
            // cuenta
            // 
            this.cuenta.AutoSize = true;
            this.cuenta.BackColor = System.Drawing.Color.Transparent;
            this.cuenta.Font = new System.Drawing.Font("Tahoma", 9F);
            this.cuenta.ForeColor = System.Drawing.Color.White;
            this.cuenta.Location = new System.Drawing.Point(118, 248);
            this.cuenta.Name = "cuenta";
            this.cuenta.Size = new System.Drawing.Size(77, 14);
            this.cuenta.TabIndex = 7;
            this.cuenta.Text = "Crear cuenta";
            this.cuenta.Click += new System.EventHandler(this.cuenta_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = global::applicacion.Properties.Resources._3592828_general_key_key_lock_lock_office_password_security_107759;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Tahoma", 12F);
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(121, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(60, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::applicacion.Properties.Resources._4afc3a3f79a92036da267471bb37a20f;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(85, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(165, 35);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImage = global::applicacion.Properties.Resources._3592827_access_general_house_key_key_lock_key_login_office_107758;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(47, 181);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(55, 33);
            this.pictureBox3.TabIndex = 4;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::applicacion.Properties.Resources._3592855_business_man_employee_general_human_member_office_tie_107745;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(38, 109);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 32);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::applicacion.Properties.Resources.a3dd66eee23adcf2fe0012785f0af287;
            this.ClientSize = new System.Drawing.Size(329, 399);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuenta);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.textcontraseña2);
            this.Controls.Add(this.textususario2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textususario2;
        private System.Windows.Forms.TextBox textcontraseña2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label cuenta;
        private System.Windows.Forms.Button button1;
    }
}

