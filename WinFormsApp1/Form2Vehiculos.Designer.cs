namespace WinFormsApp1
{
    partial class Form2Vehiculos
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tx_marca = new TextBox();
            tx_modelo = new TextBox();
            tx_año = new TextBox();
            tx_precio = new TextBox();
            tx_kilometraje = new TextBox();
            groupBox1 = new GroupBox();
            boton_guardar = new Button();
            groupBox2 = new GroupBox();
            tx_listadovehiculos = new TextBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 25);
            label1.Name = "label1";
            label1.Size = new Size(43, 15);
            label1.TabIndex = 0;
            label1.Text = "Marca:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 58);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 1;
            label2.Text = "Modelo:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 86);
            label3.Name = "label3";
            label3.Size = new Size(32, 15);
            label3.TabIndex = 2;
            label3.Text = "Año:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(9, 118);
            label4.Name = "label4";
            label4.Size = new Size(43, 15);
            label4.TabIndex = 3;
            label4.Text = "Precio:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(0, 144);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 4;
            label5.Text = "Kilometraje:";
            // 
            // tx_marca
            // 
            tx_marca.Location = new Point(70, 17);
            tx_marca.Margin = new Padding(3, 2, 3, 2);
            tx_marca.Name = "tx_marca";
            tx_marca.Size = new Size(123, 23);
            tx_marca.TabIndex = 5;
            // 
            // tx_modelo
            // 
            tx_modelo.Location = new Point(70, 52);
            tx_modelo.Margin = new Padding(3, 2, 3, 2);
            tx_modelo.Name = "tx_modelo";
            tx_modelo.Size = new Size(123, 23);
            tx_modelo.TabIndex = 6;
            // 
            // tx_año
            // 
            tx_año.Location = new Point(70, 83);
            tx_año.Margin = new Padding(3, 2, 3, 2);
            tx_año.Name = "tx_año";
            tx_año.Size = new Size(78, 23);
            tx_año.TabIndex = 7;
            // 
            // tx_precio
            // 
            tx_precio.Location = new Point(70, 110);
            tx_precio.Margin = new Padding(3, 2, 3, 2);
            tx_precio.Name = "tx_precio";
            tx_precio.Size = new Size(123, 23);
            tx_precio.TabIndex = 8;
            // 
            // tx_kilometraje
            // 
            tx_kilometraje.Location = new Point(70, 139);
            tx_kilometraje.Margin = new Padding(3, 2, 3, 2);
            tx_kilometraje.Name = "tx_kilometraje";
            tx_kilometraje.Size = new Size(123, 23);
            tx_kilometraje.TabIndex = 9;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(boton_guardar);
            groupBox1.Controls.Add(tx_año);
            groupBox1.Controls.Add(tx_kilometraje);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tx_precio);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(tx_modelo);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(tx_marca);
            groupBox1.Controls.Add(label5);
            groupBox1.Location = new Point(10, 9);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(374, 194);
            groupBox1.TabIndex = 10;
            groupBox1.TabStop = false;
            groupBox1.Text = "Agregar Vehiculo";
            // 
            // boton_guardar
            // 
            boton_guardar.Location = new Point(269, 168);
            boton_guardar.Margin = new Padding(3, 2, 3, 2);
            boton_guardar.Name = "boton_guardar";
            boton_guardar.Size = new Size(82, 22);
            boton_guardar.TabIndex = 10;
            boton_guardar.Text = "&Guardar";
            boton_guardar.UseVisualStyleBackColor = true;
            boton_guardar.Click += boton_guardar_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(tx_listadovehiculos);
            groupBox2.Location = new Point(420, 34);
            groupBox2.Margin = new Padding(3, 2, 3, 2);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(3, 2, 3, 2);
            groupBox2.Size = new Size(298, 137);
            groupBox2.TabIndex = 11;
            groupBox2.TabStop = false;
            groupBox2.Text = "Listado Vehiculos";
            // 
            // tx_listadovehiculos
            // 
            tx_listadovehiculos.Location = new Point(5, 20);
            tx_listadovehiculos.Margin = new Padding(3, 2, 3, 2);
            tx_listadovehiculos.Multiline = true;
            tx_listadovehiculos.Name = "tx_listadovehiculos";
            tx_listadovehiculos.Size = new Size(288, 114);
            tx_listadovehiculos.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(657, 200);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 12;
            button1.Text = "&Cerrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Form2Vehiculos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(744, 235);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2Vehiculos";
            Text = "Listado Vehiculos";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tx_marca;
        private TextBox tx_modelo;
        private TextBox tx_año;
        private TextBox tx_precio;
        private TextBox tx_kilometraje;
        private GroupBox groupBox1;
        private Button boton_guardar;
        private GroupBox groupBox2;
        private TextBox tx_listadovehiculos;
        private Button button1;
    }
}