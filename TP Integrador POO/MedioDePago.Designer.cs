namespace TP_Integrador_POO
{
    partial class MedioDePago
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.productoUno = new System.Windows.Forms.Label();
            this.productoDos = new System.Windows.Forms.Label();
            this.precioCafe = new System.Windows.Forms.Label();
            this.precioComida = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.total = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cantUno = new System.Windows.Forms.Label();
            this.cantDos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(321, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONCRETAR COMPRA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(72, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seleccionar tarjeta de crédito";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Visa",
            "Mastercard"});
            this.comboBox1.Location = new System.Drawing.Point(128, 217);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 272);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingresar N° de Tarjeta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 330);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(146, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Fecha Venc. MM/AA";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(213, 330);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(146, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Código de Seg. XXX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 388);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(299, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Nombre y Apellido que figura en la tarjeta:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(15, 441);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "DNI:";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(187, 266);
            this.txtUser.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(179, 22);
            this.txtUser.TabIndex = 9;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(59, 350);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(72, 22);
            this.textBox1.TabIndex = 10;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(244, 350);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(72, 22);
            this.textBox2.TabIndex = 11;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(19, 409);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(179, 22);
            this.textBox3.TabIndex = 12;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(19, 462);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(179, 22);
            this.textBox4.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 553);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Anteiku S.A";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 505);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(73, 36);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pagar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(13, 62);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 19);
            this.label9.TabIndex = 16;
            this.label9.Text = "Detalle del pedido:";
            // 
            // productoUno
            // 
            this.productoUno.AccessibleName = "productoUno";
            this.productoUno.AutoSize = true;
            this.productoUno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoUno.Location = new System.Drawing.Point(13, 91);
            this.productoUno.Name = "productoUno";
            this.productoUno.Size = new System.Drawing.Size(75, 17);
            this.productoUno.TabIndex = 17;
            this.productoUno.Text = "Producto1";
            this.productoUno.Click += new System.EventHandler(this.label10_Click);
            // 
            // productoDos
            // 
            this.productoDos.AutoSize = true;
            this.productoDos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.productoDos.Location = new System.Drawing.Point(13, 119);
            this.productoDos.Name = "productoDos";
            this.productoDos.Size = new System.Drawing.Size(75, 17);
            this.productoDos.TabIndex = 18;
            this.productoDos.Text = "Producto2";
            this.productoDos.Click += new System.EventHandler(this.label11_Click);
            // 
            // precioCafe
            // 
            this.precioCafe.AutoSize = true;
            this.precioCafe.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioCafe.Location = new System.Drawing.Point(305, 91);
            this.precioCafe.Name = "precioCafe";
            this.precioCafe.Size = new System.Drawing.Size(50, 17);
            this.precioCafe.TabIndex = 19;
            this.precioCafe.Text = "Precio";
            this.precioCafe.Click += new System.EventHandler(this.label12_Click);
            // 
            // precioComida
            // 
            this.precioComida.AutoSize = true;
            this.precioComida.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.precioComida.Location = new System.Drawing.Point(305, 119);
            this.precioComida.Name = "precioComida";
            this.precioComida.Size = new System.Drawing.Size(50, 17);
            this.precioComida.TabIndex = 20;
            this.precioComida.Text = "Precio";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(15, 150);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(57, 18);
            this.label14.TabIndex = 21;
            this.label14.Text = "TOTAL";
            // 
            // total
            // 
            this.total.AutoSize = true;
            this.total.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total.Location = new System.Drawing.Point(305, 150);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(54, 18);
            this.total.TabIndex = 22;
            this.total.Text = "Precio";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(325, 450);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(35, 130);
            this.panel1.TabIndex = 23;
            // 
            // cantUno
            // 
            this.cantUno.AccessibleName = "productoUno";
            this.cantUno.AutoSize = true;
            this.cantUno.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantUno.Location = new System.Drawing.Point(256, 91);
            this.cantUno.Name = "cantUno";
            this.cantUno.Size = new System.Drawing.Size(39, 17);
            this.cantUno.TabIndex = 24;
            this.cantUno.Tag = "cantUno";
            this.cantUno.Text = "Cant";
            // 
            // cantDos
            // 
            this.cantDos.AccessibleName = "productoUno";
            this.cantDos.AutoSize = true;
            this.cantDos.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantDos.Location = new System.Drawing.Point(256, 119);
            this.cantDos.Name = "cantDos";
            this.cantDos.Size = new System.Drawing.Size(39, 17);
            this.cantDos.TabIndex = 25;
            this.cantDos.Tag = "cantUno";
            this.cantDos.Text = "Cant";
            this.cantDos.Click += new System.EventHandler(this.cantDos_Click);
            // 
            // label16
            // 
            this.label16.AccessibleName = "productoUno";
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(240, 91);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(15, 17);
            this.label16.TabIndex = 26;
            this.label16.Tag = "cantUno";
            this.label16.Text = "x";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label17
            // 
            this.label17.AccessibleName = "productoUno";
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(240, 119);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(15, 17);
            this.label17.TabIndex = 27;
            this.label17.Tag = "cantUno";
            this.label17.Text = "x";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // MedioDePago
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(408, 453);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.cantDos);
            this.Controls.Add(this.cantUno);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.total);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.precioComida);
            this.Controls.Add(this.precioCafe);
            this.Controls.Add(this.productoDos);
            this.Controls.Add(this.productoUno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MedioDePago";
            this.Text = "MedioDePago";
            this.Load += new System.EventHandler(this.MedioDePago_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label productoDos;
        private System.Windows.Forms.Label precioCafe;
        private System.Windows.Forms.Label precioComida;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label total;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label productoUno;
        public System.Windows.Forms.Label cantUno;
        public System.Windows.Forms.Label cantDos;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
    }
}