namespace Lab4_BD
{
    partial class ListaEstudiante
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
            this.agregarEst = new MetroFramework.Controls.MetroLink();
            this.elimEst = new MetroFramework.Controls.MetroLink();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.filtro = new MetroFramework.Controls.MetroLabel();
            this.filtroNombre = new MetroFramework.Controls.MetroComboBox();
            this.buscar = new MetroFramework.Controls.MetroButton();
            this.listEst = new MetroFramework.Controls.MetroLabel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.textBox = new MetroFramework.Controls.MetroTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarEst
            // 
            this.agregarEst.Location = new System.Drawing.Point(622, 63);
            this.agregarEst.Name = "agregarEst";
            this.agregarEst.Size = new System.Drawing.Size(142, 23);
            this.agregarEst.TabIndex = 0;
            this.agregarEst.Text = "Ir a agregar estudiantes";
            this.agregarEst.UseSelectable = true;
            this.agregarEst.Click += new System.EventHandler(this.agregarEst_Click);
            // 
            // elimEst
            // 
            this.elimEst.Location = new System.Drawing.Point(622, 92);
            this.elimEst.Name = "elimEst";
            this.elimEst.Size = new System.Drawing.Size(142, 23);
            this.elimEst.TabIndex = 1;
            this.elimEst.Text = "Ir a eliminar estudiantes";
            this.elimEst.UseSelectable = true;
            this.elimEst.Click += new System.EventHandler(this.elimEst_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Lab4_BD.Properties.Resources.buscar;
            this.pictureBox1.Location = new System.Drawing.Point(352, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(98, 107);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(37, 167);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            // 
            // filtro
            // 
            this.filtro.AutoSize = true;
            this.filtro.Location = new System.Drawing.Point(375, 167);
            this.filtro.Name = "filtro";
            this.filtro.Size = new System.Drawing.Size(88, 19);
            this.filtro.TabIndex = 4;
            this.filtro.Text = "Filtro General";

            // 
            // filtroNombre
            // 
            this.filtroNombre.FormattingEnabled = true;
            this.filtroNombre.ItemHeight = 23;
            this.filtroNombre.Location = new System.Drawing.Point(102, 167);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(229, 29);
            this.filtroNombre.TabIndex = 5;
            this.filtroNombre.UseSelectable = true;
            this.filtroNombre.SelectedIndexChanged += new System.EventHandler(this.nombres_SelectedIndexChanged);
            // 
            // buscar
            // 
            this.buscar.Location = new System.Drawing.Point(364, 217);
            this.buscar.Name = "buscar";
            this.buscar.Size = new System.Drawing.Size(75, 23);
            this.buscar.TabIndex = 7;
            this.buscar.Text = "Buscar";
            this.buscar.UseSelectable = true;
            this.buscar.Click += new System.EventHandler(this.buscar_Click);
            // 
            // listEst
            // 
            this.listEst.AutoSize = true;
            this.listEst.Location = new System.Drawing.Point(37, 244);
            this.listEst.Name = "listEst";
            this.listEst.Size = new System.Drawing.Size(76, 19);
            this.listEst.TabIndex = 8;
            this.listEst.Text = "Estudiantes:";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(23, 266);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(754, 161);
            this.dataGridView.TabIndex = 9;
            // 
            // textBox
            // 
            // 
            // 
            // 
            this.textBox.CustomButton.Image = null;
            this.textBox.CustomButton.Location = new System.Drawing.Point(273, 1);
            this.textBox.CustomButton.Name = "";
            this.textBox.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.textBox.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.textBox.CustomButton.TabIndex = 1;
            this.textBox.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.textBox.CustomButton.UseSelectable = true;
            this.textBox.CustomButton.Visible = false;
            this.textBox.Lines = new string[0];
            this.textBox.Location = new System.Drawing.Point(469, 167);
            this.textBox.MaxLength = 32767;
            this.textBox.Name = "textBox";
            this.textBox.PasswordChar = '\0';
            this.textBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBox.SelectedText = "";
            this.textBox.SelectionLength = 0;
            this.textBox.SelectionStart = 0;
            this.textBox.ShortcutsEnabled = true;
            this.textBox.Size = new System.Drawing.Size(295, 23);
            this.textBox.TabIndex = 24;
            this.textBox.UseSelectable = true;
            this.textBox.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.textBox.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // ListaEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.listEst);
            this.Controls.Add(this.buscar);
            this.Controls.Add(this.filtroNombre);
            this.Controls.Add(this.filtro);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.elimEst);
            this.Controls.Add(this.agregarEst);
            this.Name = "ListaEstudiante";
            this.Text = "Lista Estudiantes";
            this.Load += new System.EventHandler(this.ListaEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink agregarEst;
        private MetroFramework.Controls.MetroLink elimEst;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroLabel filtro;
        private MetroFramework.Controls.MetroComboBox filtroNombre;
        private MetroFramework.Controls.MetroButton buscar;
        private MetroFramework.Controls.MetroLabel listEst;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroTextBox textBox;
    }
}