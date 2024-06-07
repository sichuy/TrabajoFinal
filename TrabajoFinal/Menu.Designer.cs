namespace TrabajoFinal
{
    partial class Menu
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
            CineTec = new Label();
            btnCerrar = new Button();
            btnAlquilar = new Button();
            btnPelicula = new Button();
            btnCliente = new Button();
            SuspendLayout();
            // 
            // CineTec
            // 
            CineTec.AutoSize = true;
            CineTec.BackColor = Color.Transparent;
            CineTec.Font = new Font("SimSun-ExtB", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            CineTec.Location = new Point(293, 35);
            CineTec.Name = "CineTec";
            CineTec.Size = new Size(150, 38);
            CineTec.TabIndex = 9;
            CineTec.Text = "CineTec";
            // 
            // btnCerrar
            // 
            btnCerrar.BackColor = Color.Yellow;
            btnCerrar.Font = new Font("SimSun-ExtB", 9F);
            btnCerrar.Location = new Point(466, 240);
            btnCerrar.Margin = new Padding(3, 2, 3, 2);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(82, 22);
            btnCerrar.TabIndex = 8;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = false;
            btnCerrar.Click += btnCerrar_Click;
            // 
            // btnAlquilar
            // 
            btnAlquilar.BackColor = Color.Yellow;
            btnAlquilar.Font = new Font("SimSun-ExtB", 9F);
            btnAlquilar.Location = new Point(328, 208);
            btnAlquilar.Margin = new Padding(3, 2, 3, 2);
            btnAlquilar.Name = "btnAlquilar";
            btnAlquilar.Size = new Size(82, 22);
            btnAlquilar.TabIndex = 7;
            btnAlquilar.Text = "Alquilar";
            btnAlquilar.UseVisualStyleBackColor = false;
            btnAlquilar.Click += btnAlquilar_Click;
            // 
            // btnPelicula
            // 
            btnPelicula.BackColor = Color.Yellow;
            btnPelicula.Font = new Font("SimSun-ExtB", 9F);
            btnPelicula.Location = new Point(328, 173);
            btnPelicula.Margin = new Padding(3, 2, 3, 2);
            btnPelicula.Name = "btnPelicula";
            btnPelicula.Size = new Size(82, 22);
            btnPelicula.TabIndex = 6;
            btnPelicula.Text = "Pelicula";
            btnPelicula.UseVisualStyleBackColor = false;
            btnPelicula.Click += btnPelicula_Click;
            // 
            // btnCliente
            // 
            btnCliente.BackColor = Color.Yellow;
            btnCliente.Font = new Font("SimSun-ExtB", 9F);
            btnCliente.Location = new Point(328, 138);
            btnCliente.Margin = new Padding(3, 2, 3, 2);
            btnCliente.Name = "btnCliente";
            btnCliente.Size = new Size(82, 22);
            btnCliente.TabIndex = 5;
            btnCliente.Text = "Cliente ";
            btnCliente.UseVisualStyleBackColor = false;
            btnCliente.Click += btnCliente_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.fondo_cine;
            ClientSize = new Size(726, 267);
            Controls.Add(CineTec);
            Controls.Add(btnCerrar);
            Controls.Add(btnAlquilar);
            Controls.Add(btnPelicula);
            Controls.Add(btnCliente);
            Name = "Menu";
            Text = "Menu";
            Load += Menu_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CineTec;
        private Button btnCerrar;
        private Button btnAlquilar;
        private Button btnPelicula;
        private Button btnCliente;
    }
}