namespace Lab4_BD
{
    partial class EliminarEstudiante
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
            this.listaEst = new MetroFramework.Controls.MetroLink();
            this.iconBorrar = new System.Windows.Forms.PictureBox();
            this.nombre = new MetroFramework.Controls.MetroLabel();
            this.filtroNombre = new MetroFramework.Controls.MetroComboBox();
            this.eliminar = new MetroFramework.Controls.MetroButton();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.estudiantes = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.iconBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // agregarEst
            // 
            this.agregarEst.Location = new System.Drawing.Point(591, 64);
            this.agregarEst.Name = "agregarEst";
            this.agregarEst.Size = new System.Drawing.Size(169, 23);
            this.agregarEst.TabIndex = 0;
            this.agregarEst.Text = "Ir a agregar estudiante";
            this.agregarEst.UseSelectable = true;
            this.agregarEst.Click += new System.EventHandler(this.agregarEst_Click);
            // 
            // listaEst
            // 
            this.listaEst.Location = new System.Drawing.Point(591, 93);
            this.listaEst.Name = "listaEst";
            this.listaEst.Size = new System.Drawing.Size(169, 23);
            this.listaEst.TabIndex = 1;
            this.listaEst.Text = "Ir a lista de estudiantes";
            this.listaEst.UseSelectable = true;
            this.listaEst.Click += new System.EventHandler(this.metroLink2_Click);
            // 
            // iconBorrar
            // 
            this.iconBorrar.Image = global::Lab4_BD.Properties.Resources.borrar;
            this.iconBorrar.Location = new System.Drawing.Point(334, 50);
            this.iconBorrar.Name = "iconBorrar";
            this.iconBorrar.Size = new System.Drawing.Size(103, 99);
            this.iconBorrar.TabIndex = 2;
            this.iconBorrar.TabStop = false;
            // 
            // nombre
            // 
            this.nombre.AutoSize = true;
            this.nombre.Location = new System.Drawing.Point(24, 176);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(59, 19);
            this.nombre.TabIndex = 3;
            this.nombre.Text = "Nombre";
            // 
            // filtroNombre
            // 
            this.filtroNombre.FormattingEnabled = true;
            this.filtroNombre.ItemHeight = 23;
            this.filtroNombre.Location = new System.Drawing.Point(89, 176);
            this.filtroNombre.Name = "filtroNombre";
            this.filtroNombre.Size = new System.Drawing.Size(255, 29);
            this.filtroNombre.TabIndex = 4;
            this.filtroNombre.UseSelectable = true;
            this.filtroNombre.SelectedIndexChanged += new System.EventHandler(this.filtroNombre_SelectedIndexChanged);
            // 
            // eliminar
            // 
            this.eliminar.Location = new System.Drawing.Point(480, 182);
            this.eliminar.Name = "eliminar";
            this.eliminar.Size = new System.Drawing.Size(75, 23);
            this.eliminar.TabIndex = 5;
            this.eliminar.Text = "Eliminar";
            this.eliminar.UseSelectable = true;
            this.eliminar.Click += new System.EventHandler(this.eliminar_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(24, 253);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(736, 186);
            this.dataGridView.TabIndex = 6;
            // 
            // estudiantes
            // 
            this.estudiantes.AutoSize = true;
            this.estudiantes.Location = new System.Drawing.Point(24, 231);
            this.estudiantes.Name = "estudiantes";
            this.estudiantes.Size = new System.Drawing.Size(76, 19);
            this.estudiantes.TabIndex = 7;
            this.estudiantes.Text = "Estudiantes:";
            // 
            // EliminarEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.estudiantes);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.eliminar);
            this.Controls.Add(this.filtroNombre);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.iconBorrar);
            this.Controls.Add(this.listaEst);
            this.Controls.Add(this.agregarEst);
            this.Name = "EliminarEstudiante";
            this.Text = "Eliminar Estudiante";
            this.Load += new System.EventHandler(this.EliminarEstudiante_Load);
            ((System.ComponentModel.ISupportInitialize)(this.iconBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroLink agregarEst;
        private MetroFramework.Controls.MetroLink listaEst;
        private System.Windows.Forms.PictureBox iconBorrar;
        private MetroFramework.Controls.MetroLabel nombre;
        private MetroFramework.Controls.MetroComboBox filtroNombre;
        private MetroFramework.Controls.MetroButton eliminar;
        private System.Windows.Forms.DataGridView dataGridView;
        private MetroFramework.Controls.MetroLabel estudiantes;
    }
}