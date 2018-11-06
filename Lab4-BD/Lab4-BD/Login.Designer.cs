namespace Lab4_BD
{
    partial class Login
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
            this.usuario = new MetroFramework.Controls.MetroLink();
            this.aceptar = new MetroFramework.Controls.MetroButton();
            this.userbox = new MetroFramework.Controls.MetroTextBox();
            this.contra = new MetroFramework.Controls.MetroLink();
            this.passBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab4_BD.Properties.Resources.login;
            this.pictureBox1.Location = new System.Drawing.Point(301, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(154, 172);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(153, 263);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(75, 23);
            this.usuario.TabIndex = 1;
            this.usuario.Text = "Usuario";
            this.usuario.UseSelectable = true;
            // 
            // aceptar
            // 
            this.aceptar.Location = new System.Drawing.Point(301, 372);
            this.aceptar.Name = "aceptar";
            this.aceptar.Size = new System.Drawing.Size(75, 23);
            this.aceptar.TabIndex = 3;
            this.aceptar.Text = "Aceptar";
            this.aceptar.UseSelectable = true;
            this.aceptar.Click += new System.EventHandler(this.aceptar_Click);
            // 
            // userbox
            // 
            // 
            // 
            // 
            this.userbox.CustomButton.Image = null;
            this.userbox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.userbox.CustomButton.Name = "";
            this.userbox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.userbox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.userbox.CustomButton.TabIndex = 1;
            this.userbox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.userbox.CustomButton.UseSelectable = true;
            this.userbox.CustomButton.Visible = false;
            this.userbox.Lines = new string[0];
            this.userbox.Location = new System.Drawing.Point(301, 263);
            this.userbox.MaxLength = 32767;
            this.userbox.Name = "userbox";
            this.userbox.PasswordChar = '\0';
            this.userbox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.userbox.SelectedText = "";
            this.userbox.SelectionLength = 0;
            this.userbox.SelectionStart = 0;
            this.userbox.ShortcutsEnabled = true;
            this.userbox.Size = new System.Drawing.Size(204, 23);
            this.userbox.TabIndex = 4;
            this.userbox.UseSelectable = true;
            this.userbox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.userbox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.userbox.Click += new System.EventHandler(this.metroTextBox1_Click);
            // 
            // contra
            // 
            this.contra.Location = new System.Drawing.Point(153, 301);
            this.contra.Name = "contra";
            this.contra.Size = new System.Drawing.Size(75, 23);
            this.contra.TabIndex = 5;
            this.contra.Text = "Constraseña";
            this.contra.UseSelectable = true;
            this.contra.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // passBox
            // 
            // 
            // 
            // 
            this.passBox.CustomButton.Image = null;
            this.passBox.CustomButton.Location = new System.Drawing.Point(182, 1);
            this.passBox.CustomButton.Name = "";
            this.passBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.passBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.passBox.CustomButton.TabIndex = 1;
            this.passBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.passBox.CustomButton.UseSelectable = true;
            this.passBox.CustomButton.Visible = false;
            this.passBox.Lines = new string[0];
            this.passBox.Location = new System.Drawing.Point(301, 301);
            this.passBox.MaxLength = 32767;
            this.passBox.Name = "passBox";
            this.passBox.PasswordChar = '*';
            this.passBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.passBox.SelectedText = "";
            this.passBox.SelectionLength = 0;
            this.passBox.SelectionStart = 0;
            this.passBox.ShortcutsEnabled = true;
            this.passBox.Size = new System.Drawing.Size(204, 23);
            this.passBox.TabIndex = 6;
            this.passBox.UseSelectable = true;
            this.passBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.passBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.passBox);
            this.Controls.Add(this.contra);
            this.Controls.Add(this.userbox);
            this.Controls.Add(this.aceptar);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLink usuario;
        private MetroFramework.Controls.MetroButton aceptar;
        private MetroFramework.Controls.MetroTextBox userbox;
        private MetroFramework.Controls.MetroLink contra;
        private MetroFramework.Controls.MetroTextBox passBox;
    }
}