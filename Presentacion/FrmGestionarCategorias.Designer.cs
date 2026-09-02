namespace Presentacion
{
    partial class FrmGestionarCategorias
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnProbarCategoria = new Button();
            dgvListaCategorias = new DataGridView();
            gbDatosCategoria = new GroupBox();
            btnCrearCategoría = new Button();
            txtDescripcion = new TextBox();
            txtNombre = new TextBox();
            label2 = new Label();
            label1 = new Label();
            btnLimpiar = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).BeginInit();
            gbDatosCategoria.SuspendLayout();
            SuspendLayout();
            // 
            // btnProbarCategoria
            // 
            btnProbarCategoria.Location = new Point(546, 26);
            btnProbarCategoria.Margin = new Padding(3, 2, 3, 2);
            btnProbarCategoria.Name = "btnProbarCategoria";
            btnProbarCategoria.Size = new Size(127, 25);
            btnProbarCategoria.TabIndex = 0;
            btnProbarCategoria.Text = "&Probar categoria";
            btnProbarCategoria.UseVisualStyleBackColor = true;
            btnProbarCategoria.Click += btnProbarCategoria_Click;
            // 
            // dgvListaCategorias
            // 
            dgvListaCategorias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvListaCategorias.Location = new Point(73, 178);
            dgvListaCategorias.Margin = new Padding(3, 2, 3, 2);
            dgvListaCategorias.Name = "dgvListaCategorias";
            dgvListaCategorias.RowHeadersWidth = 51;
            dgvListaCategorias.Size = new Size(435, 177);
            dgvListaCategorias.TabIndex = 1;
            // 
            // gbDatosCategoria
            // 
            gbDatosCategoria.Controls.Add(btnLimpiar);
            gbDatosCategoria.Controls.Add(btnCrearCategoría);
            gbDatosCategoria.Controls.Add(txtDescripcion);
            gbDatosCategoria.Controls.Add(txtNombre);
            gbDatosCategoria.Controls.Add(label2);
            gbDatosCategoria.Controls.Add(label1);
            gbDatosCategoria.Location = new Point(12, 2);
            gbDatosCategoria.Name = "gbDatosCategoria";
            gbDatosCategoria.Size = new Size(518, 142);
            gbDatosCategoria.TabIndex = 2;
            gbDatosCategoria.TabStop = false;
            gbDatosCategoria.Text = "Datos de la categoria";
            // 
            // btnCrearCategoría
            // 
            btnCrearCategoría.BackColor = Color.LawnGreen;
            btnCrearCategoría.Location = new Point(78, 115);
            btnCrearCategoría.Name = "btnCrearCategoría";
            btnCrearCategoría.Size = new Size(128, 27);
            btnCrearCategoría.TabIndex = 4;
            btnCrearCategoría.Text = "&Crear Categoria";
            btnCrearCategoría.UseVisualStyleBackColor = false;
            btnCrearCategoría.Click += btnCrearCategoría_Click;
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(84, 77);
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.Size = new Size(344, 23);
            txtDescripcion.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(84, 24);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(344, 23);
            txtNombre.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 80);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.TabIndex = 1;
            label2.Text = "Descripción:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 24);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Nombre:";
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.DeepSkyBlue;
            btnLimpiar.Location = new Point(284, 106);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(98, 30);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // FrmGestionarCategorias
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 366);
            Controls.Add(gbDatosCategoria);
            Controls.Add(dgvListaCategorias);
            Controls.Add(btnProbarCategoria);
            Margin = new Padding(3, 2, 3, 2);
            Name = "FrmGestionarCategorias";
            Text = "Form1";
            Load += FrmGestionarCategorias_Load;
            ((System.ComponentModel.ISupportInitialize)dgvListaCategorias).EndInit();
            gbDatosCategoria.ResumeLayout(false);
            gbDatosCategoria.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnProbarCategoria;
        private DataGridView dgvListaCategorias;
        private GroupBox gbDatosCategoria;
        private TextBox txtDescripcion;
        private TextBox txtNombre;
        private Label label2;
        private Label label1;
        private Button btnCrearCategoría;
        private Button btnLimpiar;
    }
}
