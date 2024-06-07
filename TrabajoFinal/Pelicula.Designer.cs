namespace TrabajoFinal
{
    partial class Pelicula
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
            lblEjemplarP = new Label();
            cbEPeli = new ComboBox();
            lblTP = new Label();
            cbNac = new ComboBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblClaveD = new Label();
            label5 = new Label();
            cbProductor = new ComboBox();
            cbConservacion = new ComboBox();
            txtTitulo = new TextBox();
            txtclave = new TextBox();
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            BtnNuevo = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // lblEjemplarP
            // 
            lblEjemplarP.AutoSize = true;
            lblEjemplarP.BackColor = Color.Transparent;
            lblEjemplarP.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEjemplarP.ForeColor = Color.AliceBlue;
            lblEjemplarP.Location = new Point(12, 31);
            lblEjemplarP.Name = "lblEjemplarP";
            lblEjemplarP.Size = new Size(170, 20);
            lblEjemplarP.TabIndex = 10;
            lblEjemplarP.Text = "Numero ejemplar de pelicula";
            // 
            // cbEPeli
            // 
            cbEPeli.BackColor = Color.AliceBlue;
            cbEPeli.Font = new Font("SimSun-ExtB", 9F);
            cbEPeli.FormattingEnabled = true;
            cbEPeli.Location = new Point(188, 31);
            cbEPeli.Margin = new Padding(3, 2, 3, 2);
            cbEPeli.Name = "cbEPeli";
            cbEPeli.Size = new Size(133, 20);
            cbEPeli.TabIndex = 13;
            // 
            // lblTP
            // 
            lblTP.AutoSize = true;
            lblTP.BackColor = Color.Transparent;
            lblTP.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTP.ForeColor = Color.AliceBlue;
            lblTP.Location = new Point(22, 67);
            lblTP.Name = "lblTP";
            lblTP.Size = new Size(89, 20);
            lblTP.TabIndex = 12;
            lblTP.Text = "Titulo Pelicula";
            // 
            // cbNac
            // 
            cbNac.BackColor = Color.AliceBlue;
            cbNac.Font = new Font("SimSun-ExtB", 9F);
            cbNac.FormattingEnabled = true;
            cbNac.Location = new Point(188, 116);
            cbNac.Margin = new Padding(3, 2, 3, 2);
            cbNac.Name = "cbNac";
            cbNac.Size = new Size(133, 20);
            cbNac.TabIndex = 14;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(337, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(357, 162);
            dataGridView1.TabIndex = 15;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.AliceBlue;
            label1.Location = new Point(22, 113);
            label1.Name = "label1";
            label1.Size = new Size(83, 20);
            label1.TabIndex = 16;
            label1.Text = "Nacionalidad";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.AliceBlue;
            label2.Location = new Point(22, 154);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 17;
            label2.Text = "Productor";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.AliceBlue;
            label3.Location = new Point(23, 288);
            label3.Name = "label3";
            label3.Size = new Size(0, 20);
            label3.TabIndex = 18;
            // 
            // lblClaveD
            // 
            lblClaveD.AutoSize = true;
            lblClaveD.BackColor = Color.Transparent;
            lblClaveD.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblClaveD.ForeColor = Color.AliceBlue;
            lblClaveD.Location = new Point(23, 245);
            lblClaveD.Name = "lblClaveD";
            lblClaveD.Size = new Size(105, 20);
            lblClaveD.TabIndex = 19;
            lblClaveD.Text = "Clave del director";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Arial Narrow", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.AliceBlue;
            label5.Location = new Point(23, 198);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 20;
            label5.Text = "Conservacion";
            // 
            // cbProductor
            // 
            cbProductor.BackColor = Color.AliceBlue;
            cbProductor.Font = new Font("SimSun-ExtB", 9F);
            cbProductor.FormattingEnabled = true;
            cbProductor.Location = new Point(188, 157);
            cbProductor.Margin = new Padding(3, 2, 3, 2);
            cbProductor.Name = "cbProductor";
            cbProductor.Size = new Size(133, 20);
            cbProductor.TabIndex = 21;
            // 
            // cbConservacion
            // 
            cbConservacion.BackColor = Color.AliceBlue;
            cbConservacion.Font = new Font("SimSun-ExtB", 9F);
            cbConservacion.FormattingEnabled = true;
            cbConservacion.Location = new Point(188, 198);
            cbConservacion.Margin = new Padding(3, 2, 3, 2);
            cbConservacion.Name = "cbConservacion";
            cbConservacion.Size = new Size(133, 20);
            cbConservacion.TabIndex = 22;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(203, 68);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(100, 23);
            txtTitulo.TabIndex = 23;
            // 
            // txtclave
            // 
            txtclave.Location = new Point(203, 242);
            txtclave.Name = "txtclave";
            txtclave.Size = new Size(100, 23);
            txtclave.TabIndex = 24;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(0, 0);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 0;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(493, 245);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 26;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(493, 216);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 25;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // BtnNuevo
            // 
            BtnNuevo.Location = new Point(493, 274);
            BtnNuevo.Name = "BtnNuevo";
            BtnNuevo.Size = new Size(75, 23);
            BtnNuevo.TabIndex = 27;
            BtnNuevo.Text = "Nuevo";
            BtnNuevo.UseVisualStyleBackColor = true;
            BtnNuevo.Click += BtnNuevo_Click;
            // 
            // Pelicula
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.desktop_wallpaper_dark_space_black_space;
            ClientSize = new Size(706, 375);
            Controls.Add(BtnNuevo);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnGuardar);
            Controls.Add(txtclave);
            Controls.Add(txtTitulo);
            Controls.Add(cbConservacion);
            Controls.Add(cbProductor);
            Controls.Add(label5);
            Controls.Add(lblClaveD);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(cbNac);
            Controls.Add(cbEPeli);
            Controls.Add(lblTP);
            Controls.Add(lblEjemplarP);
            Name = "Pelicula";
            Text = "Pelicula";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblEjemplarP;
        private ComboBox cbEPeli;
        private Label lblTP;
        private ComboBox cbNac;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblClaveD;
        private Label label5;
        private ComboBox cbProductor;
        private ComboBox cbConservacion;
        private TextBox txtTitulo;
        private TextBox txtclave;
        private Button BtnActualizar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Button BtnNuevo;
    }
}