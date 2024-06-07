namespace TrabajoFinal
{
    partial class Alquiler
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            dataGridView1 = new DataGridView();
            lblEjemplarP = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            BtnGuardar = new Button();
            BtnEliminar = new Button();
            BtnActualizar = new Button();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 286);
            label2.Name = "label2";
            label2.Size = new Size(136, 20);
            label2.TabIndex = 1;
            label2.Text = "Fecha de devolucion";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(113, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de alquiler";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(12, 324);
            label4.Name = "label4";
            label4.Size = new Size(94, 20);
            label4.TabIndex = 3;
            label4.Text = "Dni del cliente";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(186, 24);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(316, 154);
            dataGridView1.TabIndex = 4;
            // 
            // lblEjemplarP
            // 
            lblEjemplarP.AutoSize = true;
            lblEjemplarP.BackColor = SystemColors.ActiveCaption;
            lblEjemplarP.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEjemplarP.ForeColor = Color.Black;
            lblEjemplarP.Location = new Point(12, 221);
            lblEjemplarP.Name = "lblEjemplarP";
            lblEjemplarP.Size = new Size(182, 20);
            lblEjemplarP.TabIndex = 14;
            lblEjemplarP.Text = "Numero ejemplar de pelicula";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(252, 252);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 16;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(252, 283);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(252, 321);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(100, 23);
            textBox3.TabIndex = 18;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Black;
            label1.Location = new Point(12, 187);
            label1.Name = "label1";
            label1.Size = new Size(70, 20);
            label1.TabIndex = 19;
            label1.Text = "id_alquiler";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(252, 184);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(100, 23);
            textBox4.TabIndex = 20;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(252, 218);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(100, 23);
            textBox5.TabIndex = 21;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(0, 0);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 26;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(0, 0);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 25;
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(401, 315);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 30;
            BtnActualizar.Text = "Actualizar";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += Btnnuevo_Click;
            // 
            // button1
            // 
            button1.Location = new Point(401, 286);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 29;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(401, 257);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 28;
            button2.Text = "Guardar";
            button2.UseVisualStyleBackColor = true;
            // 
            // Alquiler
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.renta;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(514, 450);
            Controls.Add(BtnActualizar);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnGuardar);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(lblEjemplarP);
            Controls.Add(dataGridView1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Alquiler";
            Text = "Alquiler";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private DataGridView dataGridView1;
        private Label lblEjemplarP;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private TextBox textBox4;
        private TextBox textBox5;
        private Button BtnGuardar;
        private Button BtnEliminar;
        private Button BtnActualizar;
        private Button button1;
        private Button button2;
    }
}