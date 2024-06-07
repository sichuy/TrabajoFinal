namespace TrabajoFinal
{
    partial class Cliente
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
            BtnActualizar = new Button();
            BtnEliminar = new Button();
            BtnGuardar = new Button();
            lblCliente = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            txtDNI_C = new TextBox();
            txtNOM = new TextBox();
            txtDIR = new TextBox();
            txtTEL = new TextBox();
            txtDNI_S = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // BtnActualizar
            // 
            BtnActualizar.Location = new Point(640, 388);
            BtnActualizar.Name = "BtnActualizar";
            BtnActualizar.Size = new Size(75, 23);
            BtnActualizar.TabIndex = 27;
            BtnActualizar.Text = "Nuevo";
            BtnActualizar.UseVisualStyleBackColor = true;
            BtnActualizar.Click += BtnActualizar_Click;
            // 
            // BtnEliminar
            // 
            BtnEliminar.Location = new Point(640, 359);
            BtnEliminar.Name = "BtnEliminar";
            BtnEliminar.Size = new Size(75, 23);
            BtnEliminar.TabIndex = 26;
            BtnEliminar.Text = "Eliminar";
            BtnEliminar.UseVisualStyleBackColor = true;
            BtnEliminar.Click += BtnEliminar_Click;
            // 
            // BtnGuardar
            // 
            BtnGuardar.Location = new Point(640, 330);
            BtnGuardar.Name = "BtnGuardar";
            BtnGuardar.Size = new Size(75, 23);
            BtnGuardar.TabIndex = 25;
            BtnGuardar.Text = "Guardar";
            BtnGuardar.UseVisualStyleBackColor = true;
            BtnGuardar.Click += BtnGuardar_Click;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Location = new Point(47, 76);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(65, 15);
            lblCliente.TabIndex = 28;
            lblCliente.Text = "Dni Cliente";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 105);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 29;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(47, 138);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 30;
            label3.Text = "Direccion";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 169);
            label4.Name = "label4";
            label4.Size = new Size(52, 15);
            label4.TabIndex = 31;
            label4.Text = "Telefono";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(47, 208);
            label5.Name = "label5";
            label5.Size = new Size(57, 15);
            label5.TabIndex = 32;
            label5.Text = "Dni Socio";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(398, 69);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(390, 154);
            dataGridView1.TabIndex = 33;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // txtDNI_C
            // 
            txtDNI_C.Location = new Point(145, 68);
            txtDNI_C.Name = "txtDNI_C";
            txtDNI_C.Size = new Size(100, 23);
            txtDNI_C.TabIndex = 34;
            // 
            // txtNOM
            // 
            txtNOM.Location = new Point(145, 97);
            txtNOM.Name = "txtNOM";
            txtNOM.Size = new Size(100, 23);
            txtNOM.TabIndex = 35;
            // 
            // txtDIR
            // 
            txtDIR.Location = new Point(145, 130);
            txtDIR.Name = "txtDIR";
            txtDIR.Size = new Size(100, 23);
            txtDIR.TabIndex = 36;
            // 
            // txtTEL
            // 
            txtTEL.Location = new Point(145, 161);
            txtTEL.Name = "txtTEL";
            txtTEL.Size = new Size(100, 23);
            txtTEL.TabIndex = 37;
            // 
            // txtDNI_S
            // 
            txtDNI_S.Location = new Point(145, 200);
            txtDNI_S.Name = "txtDNI_S";
            txtDNI_S.Size = new Size(100, 23);
            txtDNI_S.TabIndex = 38;
            // 
            // Cliente
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtDNI_S);
            Controls.Add(txtTEL);
            Controls.Add(txtDIR);
            Controls.Add(txtNOM);
            Controls.Add(txtDNI_C);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblCliente);
            Controls.Add(BtnActualizar);
            Controls.Add(BtnEliminar);
            Controls.Add(BtnGuardar);
            Name = "Cliente";
            Text = "Cliente";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnActualizar;
        private Button BtnEliminar;
        private Button BtnGuardar;
        private Label lblCliente;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private TextBox txtDNI_C;
        private TextBox txtNOM;
        private TextBox txtDIR;
        private TextBox txtTEL;
        private TextBox txtDNI_S;
    }
}