namespace Lab4_BD
{
    partial class AgregarEstudiante
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
            this.IrAlistaEst = new MetroFramework.Controls.MetroLink();
            this.elimEst = new MetroFramework.Controls.MetroLink();
            this.circulo = new System.Windows.Forms.PictureBox();
            this.datos = new System.Windows.Forms.GroupBox();
            this.estad = new MetroFramework.Controls.MetroTextBox();
            this.estado = new MetroFramework.Controls.MetroLabel();
            this.carnebox = new MetroFramework.Controls.MetroTextBox();
            this.carne = new MetroFramework.Controls.MetroLabel();
            this.guardar = new MetroFramework.Controls.MetroButton();
            this.tel = new MetroFramework.Controls.MetroTextBox();
            this.em = new MetroFramework.Controls.MetroTextBox();
            this.contra = new MetroFramework.Controls.MetroTextBox();
            this.username = new MetroFramework.Controls.MetroTextBox();
            this.pass = new MetroFramework.Controls.MetroLabel();
            this.usuario = new MetroFramework.Controls.MetroLabel();
            this.otroSexo = new MetroFramework.Controls.MetroRadioButton();
            this.masc = new MetroFramework.Controls.MetroRadioButton();
            this.fem = new MetroFramework.Controls.MetroRadioButton();
            this.genero = new MetroFramework.Controls.MetroLabel();
            this.email = new MetroFramework.Controls.MetroLabel();
            this.telef = new MetroFramework.Controls.MetroLabel();
            this.fecha = new MetroFramework.Controls.MetroDateTime();
            this.dir = new MetroFramework.Controls.MetroTextBox();
            this.ap2 = new MetroFramework.Controls.MetroTextBox();
            this.ap1 = new MetroFramework.Controls.MetroTextBox();
            this.nom = new MetroFramework.Controls.MetroTextBox();
            this.direccion = new MetroFramework.Controls.MetroLabel();
            this.fechaNac = new MetroFramework.Controls.MetroLabel();
            this.apellido2 = new MetroFramework.Controls.MetroLabel();
            this.apellido1 = new MetroFramework.Controls.MetroLabel();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.idField = new MetroFramework.Controls.MetroTextBox();
            this.cedula = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.circulo)).BeginInit();
            this.datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // IrAlistaEst
            // 
            this.IrAlistaEst.Location = new System.Drawing.Point(607, 31);
            this.IrAlistaEst.Name = "IrAlistaEst";
            this.IrAlistaEst.Size = new System.Drawing.Size(157, 13);
            this.IrAlistaEst.TabIndex = 0;
            this.IrAlistaEst.Text = "Ir a lista de estudiantes";
            this.IrAlistaEst.UseSelectable = true;
            this.IrAlistaEst.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // elimEst
            // 
            this.elimEst.Location = new System.Drawing.Point(637, 63);
            this.elimEst.Name = "elimEst";
            this.elimEst.Size = new System.Drawing.Size(112, 23);
            this.elimEst.TabIndex = 1;
            this.elimEst.Text = "Eliminar Estudiante";
            this.elimEst.UseSelectable = true;
            this.elimEst.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // circulo
            // 
            this.circulo.Image = global::Lab4_BD.Properties.Resources.circulo;
            this.circulo.Location = new System.Drawing.Point(309, 11);
            this.circulo.Name = "circulo";
            this.circulo.Size = new System.Drawing.Size(125, 117);
            this.circulo.TabIndex = 2;
            this.circulo.TabStop = false;
            // 
            // datos
            // 
            this.datos.Controls.Add(this.estad);
            this.datos.Controls.Add(this.estado);
            this.datos.Controls.Add(this.carnebox);
            this.datos.Controls.Add(this.carne);
            this.datos.Controls.Add(this.guardar);
            this.datos.Controls.Add(this.tel);
            this.datos.Controls.Add(this.em);
            this.datos.Controls.Add(this.contra);
            this.datos.Controls.Add(this.username);
            this.datos.Controls.Add(this.pass);
            this.datos.Controls.Add(this.usuario);
            this.datos.Controls.Add(this.otroSexo);
            this.datos.Controls.Add(this.masc);
            this.datos.Controls.Add(this.fem);
            this.datos.Controls.Add(this.genero);
            this.datos.Controls.Add(this.email);
            this.datos.Controls.Add(this.telef);
            this.datos.Controls.Add(this.fecha);
            this.datos.Controls.Add(this.dir);
            this.datos.Controls.Add(this.ap2);
            this.datos.Controls.Add(this.ap1);
            this.datos.Controls.Add(this.nom);
            this.datos.Controls.Add(this.direccion);
            this.datos.Controls.Add(this.fechaNac);
            this.datos.Controls.Add(this.apellido2);
            this.datos.Controls.Add(this.apellido1);
            this.datos.Controls.Add(this.nombre);
            this.datos.Controls.Add(this.idField);
            this.datos.Controls.Add(this.cedula);
            this.datos.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.datos.Location = new System.Drawing.Point(13, 142);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(774, 297);
            this.datos.TabIndex = 3;
            this.datos.TabStop = false;
            this.datos.Text = "Datos del estudiante";
            this.datos.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // estad
            // 
            // 
            // 
            // 
            this.estad.CustomButton.Image = null;
            this.estad.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.estad.CustomButton.Name = "";
            this.estad.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.estad.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.estad.CustomButton.TabIndex = 1;
            this.estad.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.estad.CustomButton.UseSelectable = true;
            this.estad.CustomButton.Visible = false;
            this.estad.Lines = new string[0];
            this.estad.Location = new System.Drawing.Point(505, 140);
            this.estad.MaxLength = 32767;
            this.estad.Name = "estad";
            this.estad.PasswordChar = '\0';
            this.estad.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.estad.SelectedText = "";
            this.estad.SelectionLength = 0;
            this.estad.SelectionStart = 0;
            this.estad.ShortcutsEnabled = true;
            this.estad.Size = new System.Drawing.Size(155, 23);
            this.estad.TabIndex = 28;
            this.estad.UseSelectable = true;
            this.estad.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.estad.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // estado
            // 
            this.estado.AutoSize = true;
            this.estado.Location = new System.Drawing.Point(425, 144);
            this.estado.Name = "estado";
            this.estado.Size = new System.Drawing.Size(48, 19);
            this.estado.TabIndex = 27;
            this.estado.Text = "Estado";
            // 
            // carnebox
            // 
            // 
            // 
            // 
            this.carnebox.CustomButton.Image = null;
            this.carnebox.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.carnebox.CustomButton.Name = "";
            this.carnebox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.carnebox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.carnebox.CustomButton.TabIndex = 1;
            this.carnebox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.carnebox.CustomButton.UseSelectable = true;
            this.carnebox.CustomButton.Visible = false;
            this.carnebox.Lines = new string[0];
            this.carnebox.Location = new System.Drawing.Point(505, 58);
            this.carnebox.MaxLength = 32767;
            this.carnebox.Name = "carnebox";
            this.carnebox.PasswordChar = '\0';
            this.carnebox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.carnebox.SelectedText = "";
            this.carnebox.SelectionLength = 0;
            this.carnebox.SelectionStart = 0;
            this.carnebox.ShortcutsEnabled = true;
            this.carnebox.Size = new System.Drawing.Size(155, 23);
            this.carnebox.TabIndex = 26;
            this.carnebox.UseSelectable = true;
            this.carnebox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.carnebox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // carne
            // 
            this.carne.AutoSize = true;
            this.carne.Location = new System.Drawing.Point(425, 58);
            this.carne.Name = "carne";
            this.carne.Size = new System.Drawing.Size(44, 19);
            this.carne.TabIndex = 25;
            this.carne.Text = "Carné";
            // 
            // guardar
            // 
            this.guardar.Location = new System.Drawing.Point(313, 262);
            this.guardar.Name = "guardar";
            this.guardar.Size = new System.Drawing.Size(108, 23);
            this.guardar.TabIndex = 24;
            this.guardar.Text = "Guardar";
            this.guardar.UseSelectable = true;
            this.guardar.Click += new System.EventHandler(this.guardar_Click);
            // 
            // tel
            // 
            // 
            // 
            // 
            this.tel.CustomButton.Image = null;
            this.tel.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.tel.CustomButton.Name = "";
            this.tel.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tel.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tel.CustomButton.TabIndex = 1;
            this.tel.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tel.CustomButton.UseSelectable = true;
            this.tel.CustomButton.Visible = false;
            this.tel.Lines = new string[0];
            this.tel.Location = new System.Drawing.Point(505, 22);
            this.tel.MaxLength = 32767;
            this.tel.Name = "tel";
            this.tel.PasswordChar = '\0';
            this.tel.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tel.SelectedText = "";
            this.tel.SelectionLength = 0;
            this.tel.SelectionStart = 0;
            this.tel.ShortcutsEnabled = true;
            this.tel.Size = new System.Drawing.Size(155, 23);
            this.tel.TabIndex = 23;
            this.tel.UseSelectable = true;
            this.tel.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tel.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // em
            // 
            // 
            // 
            // 
            this.em.CustomButton.Image = null;
            this.em.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.em.CustomButton.Name = "";
            this.em.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.em.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.em.CustomButton.TabIndex = 1;
            this.em.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.em.CustomButton.UseSelectable = true;
            this.em.CustomButton.Visible = false;
            this.em.Lines = new string[0];
            this.em.Location = new System.Drawing.Point(505, 88);
            this.em.MaxLength = 32767;
            this.em.Name = "em";
            this.em.PasswordChar = '\0';
            this.em.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.em.SelectedText = "";
            this.em.SelectionLength = 0;
            this.em.SelectionStart = 0;
            this.em.ShortcutsEnabled = true;
            this.em.Size = new System.Drawing.Size(155, 23);
            this.em.TabIndex = 22;
            this.em.UseSelectable = true;
            this.em.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.em.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // contra
            // 
            // 
            // 
            // 
            this.contra.CustomButton.Image = null;
            this.contra.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.contra.CustomButton.Name = "";
            this.contra.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.contra.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.contra.CustomButton.TabIndex = 1;
            this.contra.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.contra.CustomButton.UseSelectable = true;
            this.contra.CustomButton.Visible = false;
            this.contra.Lines = new string[0];
            this.contra.Location = new System.Drawing.Point(505, 217);
            this.contra.MaxLength = 32767;
            this.contra.Name = "contra";
            this.contra.PasswordChar = '*';
            this.contra.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.contra.SelectedText = "";
            this.contra.SelectionLength = 0;
            this.contra.SelectionStart = 0;
            this.contra.ShortcutsEnabled = true;
            this.contra.Size = new System.Drawing.Size(155, 23);
            this.contra.TabIndex = 21;
            this.contra.UseSelectable = true;
            this.contra.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.contra.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // username
            // 
            // 
            // 
            // 
            this.username.CustomButton.Image = null;
            this.username.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.username.CustomButton.Name = "";
            this.username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.username.CustomButton.TabIndex = 1;
            this.username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.username.CustomButton.UseSelectable = true;
            this.username.CustomButton.Visible = false;
            this.username.Lines = new string[0];
            this.username.Location = new System.Drawing.Point(505, 176);
            this.username.MaxLength = 32767;
            this.username.Name = "username";
            this.username.PasswordChar = '\0';
            this.username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.username.SelectedText = "";
            this.username.SelectionLength = 0;
            this.username.SelectionStart = 0;
            this.username.ShortcutsEnabled = true;
            this.username.Size = new System.Drawing.Size(155, 23);
            this.username.TabIndex = 20;
            this.username.UseSelectable = true;
            this.username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.username.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // pass
            // 
            this.pass.AutoSize = true;
            this.pass.Location = new System.Drawing.Point(425, 221);
            this.pass.Name = "pass";
            this.pass.Size = new System.Drawing.Size(75, 19);
            this.pass.TabIndex = 15;
            this.pass.Text = "Contraseña";
            // 
            // usuario
            // 
            this.usuario.AutoSize = true;
            this.usuario.Location = new System.Drawing.Point(425, 180);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(53, 19);
            this.usuario.TabIndex = 19;
            this.usuario.Text = "Usuario";
            // 
            // otroSexo
            // 
            this.otroSexo.AutoSize = true;
            this.otroSexo.Location = new System.Drawing.Point(671, 121);
            this.otroSexo.Name = "otroSexo";
            this.otroSexo.Size = new System.Drawing.Size(47, 15);
            this.otroSexo.TabIndex = 18;
            this.otroSexo.Text = "Otro";
            this.otroSexo.UseSelectable = true;
            // 
            // masc
            // 
            this.masc.AutoSize = true;
            this.masc.Location = new System.Drawing.Point(587, 121);
            this.masc.Name = "masc";
            this.masc.Size = new System.Drawing.Size(78, 15);
            this.masc.TabIndex = 17;
            this.masc.Text = "Masculino";
            this.masc.UseSelectable = true;
            this.masc.CheckedChanged += new System.EventHandler(this.masc_CheckedChanged);
            // 
            // fem
            // 
            this.fem.AutoSize = true;
            this.fem.Location = new System.Drawing.Point(505, 121);
            this.fem.Name = "fem";
            this.fem.Size = new System.Drawing.Size(76, 15);
            this.fem.TabIndex = 16;
            this.fem.Text = "Femenino";
            this.fem.UseSelectable = true;
            this.fem.CheckedChanged += new System.EventHandler(this.fem_CheckedChanged);
            // 
            // genero
            // 
            this.genero.AutoSize = true;
            this.genero.Location = new System.Drawing.Point(425, 117);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(52, 19);
            this.genero.TabIndex = 15;
            this.genero.Text = "Género";
            this.genero.Click += new System.EventHandler(this.metroLabel1_Click_2);
            // 
            // email
            // 
            this.email.AutoSize = true;
            this.email.Location = new System.Drawing.Point(425, 88);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(47, 19);
            this.email.TabIndex = 14;
            this.email.Text = "E-mail";
            // 
            // telef
            // 
            this.telef.AutoSize = true;
            this.telef.Location = new System.Drawing.Point(425, 26);
            this.telef.Name = "telef";
            this.telef.Size = new System.Drawing.Size(58, 19);
            this.telef.TabIndex = 13;
            this.telef.Text = "Teléfono";
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(160, 180);
            this.fecha.MinimumSize = new System.Drawing.Size(0, 29);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(155, 29);
            this.fecha.TabIndex = 12;
            this.fecha.Value = new System.DateTime(2018, 10, 7, 20, 42, 17, 0);
            // 
            // dir
            // 
            // 
            // 
            // 
            this.dir.CustomButton.Image = null;
            this.dir.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.dir.CustomButton.Name = "";
            this.dir.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.dir.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.dir.CustomButton.TabIndex = 1;
            this.dir.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.dir.CustomButton.UseSelectable = true;
            this.dir.CustomButton.Visible = false;
            this.dir.Lines = new string[0];
            this.dir.Location = new System.Drawing.Point(160, 217);
            this.dir.MaxLength = 32767;
            this.dir.Name = "dir";
            this.dir.PasswordChar = '\0';
            this.dir.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.dir.SelectedText = "";
            this.dir.SelectionLength = 0;
            this.dir.SelectionStart = 0;
            this.dir.ShortcutsEnabled = true;
            this.dir.Size = new System.Drawing.Size(155, 23);
            this.dir.TabIndex = 11;
            this.dir.UseSelectable = true;
            this.dir.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.dir.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ap2
            // 
            // 
            // 
            // 
            this.ap2.CustomButton.Image = null;
            this.ap2.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.ap2.CustomButton.Name = "";
            this.ap2.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ap2.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ap2.CustomButton.TabIndex = 1;
            this.ap2.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ap2.CustomButton.UseSelectable = true;
            this.ap2.CustomButton.Visible = false;
            this.ap2.Lines = new string[0];
            this.ap2.Location = new System.Drawing.Point(160, 144);
            this.ap2.MaxLength = 32767;
            this.ap2.Name = "ap2";
            this.ap2.PasswordChar = '\0';
            this.ap2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ap2.SelectedText = "";
            this.ap2.SelectionLength = 0;
            this.ap2.SelectionStart = 0;
            this.ap2.ShortcutsEnabled = true;
            this.ap2.Size = new System.Drawing.Size(155, 23);
            this.ap2.TabIndex = 9;
            this.ap2.UseSelectable = true;
            this.ap2.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ap2.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ap1
            // 
            // 
            // 
            // 
            this.ap1.CustomButton.Image = null;
            this.ap1.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.ap1.CustomButton.Name = "";
            this.ap1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.ap1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.ap1.CustomButton.TabIndex = 1;
            this.ap1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.ap1.CustomButton.UseSelectable = true;
            this.ap1.CustomButton.Visible = false;
            this.ap1.Lines = new string[0];
            this.ap1.Location = new System.Drawing.Point(160, 110);
            this.ap1.MaxLength = 32767;
            this.ap1.Name = "ap1";
            this.ap1.PasswordChar = '\0';
            this.ap1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ap1.SelectedText = "";
            this.ap1.SelectionLength = 0;
            this.ap1.SelectionStart = 0;
            this.ap1.ShortcutsEnabled = true;
            this.ap1.Size = new System.Drawing.Size(155, 23);
            this.ap1.TabIndex = 8;
            this.ap1.UseSelectable = true;
            this.ap1.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ap1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // nom
            // 
            // 
            // 
            // 
            this.nom.CustomButton.Image = null;
            this.nom.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.nom.CustomButton.Name = "";
            this.nom.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.nom.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.nom.CustomButton.TabIndex = 1;
            this.nom.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.nom.CustomButton.UseSelectable = true;
            this.nom.CustomButton.Visible = false;
            this.nom.Lines = new string[0];
            this.nom.Location = new System.Drawing.Point(160, 67);
            this.nom.MaxLength = 32767;
            this.nom.Name = "nom";
            this.nom.PasswordChar = '\0';
            this.nom.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.nom.SelectedText = "";
            this.nom.SelectionLength = 0;
            this.nom.SelectionStart = 0;
            this.nom.ShortcutsEnabled = true;
            this.nom.Size = new System.Drawing.Size(155, 23);
            this.nom.TabIndex = 7;
            this.nom.UseSelectable = true;
            this.nom.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.nom.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // direccion
            // 
            this.direccion.AutoSize = true;
            this.direccion.Location = new System.Drawing.Point(33, 221);
            this.direccion.Name = "direccion";
            this.direccion.Size = new System.Drawing.Size(63, 19);
            this.direccion.TabIndex = 6;
            this.direccion.Text = "Dirección";
            // 
            // fechaNac
            // 
            this.fechaNac.AutoSize = true;
            this.fechaNac.Location = new System.Drawing.Point(33, 180);
            this.fechaNac.Name = "fechaNac";
            this.fechaNac.Size = new System.Drawing.Size(114, 19);
            this.fechaNac.TabIndex = 5;
            this.fechaNac.Text = "Fecha Nacimiento";
            this.fechaNac.Click += new System.EventHandler(this.metroLabel1_Click_1);
            // 
            // apellido2
            // 
            this.apellido2.AutoSize = true;
            this.apellido2.Location = new System.Drawing.Point(33, 144);
            this.apellido2.Name = "apellido2";
            this.apellido2.Size = new System.Drawing.Size(114, 19);
            this.apellido2.TabIndex = 4;
            this.apellido2.Text = "Segundo Apellido";
            this.apellido2.Click += new System.EventHandler(this.metroLabel1_Click);
            // 
            // apellido1
            // 
            this.apellido1.AutoSize = true;
            this.apellido1.Location = new System.Drawing.Point(33, 110);
            this.apellido1.Name = "apellido1";
            this.apellido1.Size = new System.Drawing.Size(102, 19);
            this.apellido1.TabIndex = 3;
            this.apellido1.Text = "Primer Apellido";
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(33, 71);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 2;
            this.nombre.Text = "Nombre";
            // 
            // idField
            // 
            // 
            // 
            // 
            this.idField.CustomButton.Image = null;
            this.idField.CustomButton.Location = new System.Drawing.Point(133, 1);
            this.idField.CustomButton.Name = "";
            this.idField.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.idField.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.idField.CustomButton.TabIndex = 1;
            this.idField.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.idField.CustomButton.UseSelectable = true;
            this.idField.CustomButton.Visible = false;
            this.idField.Lines = new string[0];
            this.idField.Location = new System.Drawing.Point(160, 26);
            this.idField.MaxLength = 32767;
            this.idField.Name = "idField";
            this.idField.PasswordChar = '\0';
            this.idField.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.idField.SelectedText = "";
            this.idField.SelectionLength = 0;
            this.idField.SelectionStart = 0;
            this.idField.ShortcutsEnabled = true;
            this.idField.Size = new System.Drawing.Size(155, 23);
            this.idField.TabIndex = 1;
            this.idField.UseSelectable = true;
            this.idField.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.idField.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cedula
            // 
            this.cedula.AutoSize = true;
            this.cedula.Location = new System.Drawing.Point(33, 26);
            this.cedula.Name = "cedula";
            this.cedula.Size = new System.Drawing.Size(50, 19);
            this.cedula.TabIndex = 0;
            this.cedula.Text = "Cédula";
            // 
            // AgregarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.datos);
            this.Controls.Add(this.circulo);
            this.Controls.Add(this.elimEst);
            this.Controls.Add(this.IrAlistaEst);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "AgregarEstudiante";
            this.Text = "Agregar Estudiante";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.circulo)).EndInit();
            this.datos.ResumeLayout(false);
            this.datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink IrAlistaEst;
        private MetroFramework.Controls.MetroLink elimEst;
        private System.Windows.Forms.PictureBox circulo;
        private System.Windows.Forms.GroupBox datos;
        private MetroFramework.Controls.MetroLabel apellido2;
        private MetroFramework.Controls.MetroLabel apellido1;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroTextBox idField;
        private MetroFramework.Controls.MetroLabel cedula;
        private MetroFramework.Controls.MetroLabel fechaNac;
        private MetroFramework.Controls.MetroDateTime fecha;
        private MetroFramework.Controls.MetroTextBox dir;
        private MetroFramework.Controls.MetroTextBox ap2;
        private MetroFramework.Controls.MetroTextBox ap1;
        private MetroFramework.Controls.MetroTextBox nom;
        private MetroFramework.Controls.MetroLabel direccion;
        private MetroFramework.Controls.MetroLabel genero;
        private MetroFramework.Controls.MetroLabel email;
        private MetroFramework.Controls.MetroLabel telef;
        private MetroFramework.Controls.MetroRadioButton otroSexo;
        private MetroFramework.Controls.MetroRadioButton masc;
        private MetroFramework.Controls.MetroRadioButton fem;
        private MetroFramework.Controls.MetroButton guardar;
        private MetroFramework.Controls.MetroTextBox tel;
        private MetroFramework.Controls.MetroTextBox em;
        private MetroFramework.Controls.MetroTextBox contra;
        private MetroFramework.Controls.MetroTextBox username;
        private MetroFramework.Controls.MetroLabel pass;
        private MetroFramework.Controls.MetroLabel usuario;
        private MetroFramework.Controls.MetroLabel carne;
        private MetroFramework.Controls.MetroTextBox carnebox;
        private MetroFramework.Controls.MetroTextBox estad;
        private MetroFramework.Controls.MetroLabel estado;
    }
}

