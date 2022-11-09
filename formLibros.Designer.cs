
namespace capaPresentacion
{
    partial class formLibros
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_TITULO = new System.Windows.Forms.TextBox();
            this.textBox_UBICACION = new System.Windows.Forms.TextBox();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox_GENERO = new System.Windows.Forms.ComboBox();
            this.comboBox_NOMBRE_AUTOR = new System.Windows.Forms.ComboBox();
            this.comboBox_EDITORIAL = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label_FECHA = new System.Windows.Forms.Label();
            this.dateTime_FECHAALTA = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox_APELLIDO_AUTOR = new System.Windows.Forms.ComboBox();
            this.boton_ALTA_AUTOR = new System.Windows.Forms.Button();
            this.boton_ALTA_EDITORIAL = new System.Windows.Forms.Button();
            this.boton_ALTA_GENERO = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Titulo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 122);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ubicacion";
            // 
            // textBox_TITULO
            // 
            this.textBox_TITULO.Location = new System.Drawing.Point(118, 86);
            this.textBox_TITULO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_TITULO.Name = "textBox_TITULO";
            this.textBox_TITULO.Size = new System.Drawing.Size(205, 20);
            this.textBox_TITULO.TabIndex = 6;
            // 
            // textBox_UBICACION
            // 
            this.textBox_UBICACION.Location = new System.Drawing.Point(118, 118);
            this.textBox_UBICACION.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_UBICACION.Name = "textBox_UBICACION";
            this.textBox_UBICACION.Size = new System.Drawing.Size(205, 20);
            this.textBox_UBICACION.TabIndex = 9;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAGREGAR.Location = new System.Drawing.Point(73, 347);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(67, 65);
            this.btnAGREGAR.TabIndex = 10;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSALIR.Location = new System.Drawing.Point(188, 347);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(67, 65);
            this.btnSALIR.TabIndex = 11;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 33F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(26, 19);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 52);
            this.label6.TabIndex = 12;
            this.label6.Text = "Alta Libros";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(32, 304);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Disponible";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 160);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Autor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 193);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Editorial";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 231);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "Genero";
            // 
            // comboBox_GENERO
            // 
            this.comboBox_GENERO.FormattingEnabled = true;
            this.comboBox_GENERO.Location = new System.Drawing.Point(87, 228);
            this.comboBox_GENERO.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_GENERO.Name = "comboBox_GENERO";
            this.comboBox_GENERO.Size = new System.Drawing.Size(205, 21);
            this.comboBox_GENERO.TabIndex = 21;
            // 
            // comboBox_NOMBRE_AUTOR
            // 
            this.comboBox_NOMBRE_AUTOR.FormattingEnabled = true;
            this.comboBox_NOMBRE_AUTOR.Location = new System.Drawing.Point(133, 152);
            this.comboBox_NOMBRE_AUTOR.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_NOMBRE_AUTOR.Name = "comboBox_NOMBRE_AUTOR";
            this.comboBox_NOMBRE_AUTOR.Size = new System.Drawing.Size(108, 21);
            this.comboBox_NOMBRE_AUTOR.TabIndex = 22;
            // 
            // comboBox_EDITORIAL
            // 
            this.comboBox_EDITORIAL.FormattingEnabled = true;
            this.comboBox_EDITORIAL.Location = new System.Drawing.Point(87, 190);
            this.comboBox_EDITORIAL.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBox_EDITORIAL.Name = "comboBox_EDITORIAL";
            this.comboBox_EDITORIAL.Size = new System.Drawing.Size(205, 21);
            this.comboBox_EDITORIAL.TabIndex = 23;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(105, 300);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(35, 17);
            this.checkBox1.TabIndex = 24;
            this.checkBox1.Text = "Si";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label_FECHA
            // 
            this.label_FECHA.AutoSize = true;
            this.label_FECHA.Location = new System.Drawing.Point(35, 273);
            this.label_FECHA.Name = "label_FECHA";
            this.label_FECHA.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_FECHA.Size = new System.Drawing.Size(72, 13);
            this.label_FECHA.TabIndex = 25;
            this.label_FECHA.Text = "Fecha de alta";
            // 
            // dateTime_FECHAALTA
            // 
            this.dateTime_FECHAALTA.Location = new System.Drawing.Point(118, 266);
            this.dateTime_FECHAALTA.Name = "dateTime_FECHAALTA";
            this.dateTime_FECHAALTA.Size = new System.Drawing.Size(200, 20);
            this.dateTime_FECHAALTA.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(84, 159);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "Nombre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(264, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 28;
            this.label9.Text = "Apellido";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // comboBox_APELLIDO_AUTOR
            // 
            this.comboBox_APELLIDO_AUTOR.FormattingEnabled = true;
            this.comboBox_APELLIDO_AUTOR.Location = new System.Drawing.Point(314, 151);
            this.comboBox_APELLIDO_AUTOR.Name = "comboBox_APELLIDO_AUTOR";
            this.comboBox_APELLIDO_AUTOR.Size = new System.Drawing.Size(121, 21);
            this.comboBox_APELLIDO_AUTOR.TabIndex = 29;
            // 
            // boton_ALTA_AUTOR
            // 
            this.boton_ALTA_AUTOR.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_ALTA_AUTOR.Location = new System.Drawing.Point(441, 141);
            this.boton_ALTA_AUTOR.Name = "boton_ALTA_AUTOR";
            this.boton_ALTA_AUTOR.Size = new System.Drawing.Size(35, 32);
            this.boton_ALTA_AUTOR.TabIndex = 30;
            this.boton_ALTA_AUTOR.Text = "+";
            this.boton_ALTA_AUTOR.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.boton_ALTA_AUTOR.UseVisualStyleBackColor = true;
            this.boton_ALTA_AUTOR.Click += new System.EventHandler(this.boton_ALTA_AUTOR_Click);
            // 
            // boton_ALTA_EDITORIAL
            // 
            this.boton_ALTA_EDITORIAL.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_ALTA_EDITORIAL.Location = new System.Drawing.Point(297, 180);
            this.boton_ALTA_EDITORIAL.Name = "boton_ALTA_EDITORIAL";
            this.boton_ALTA_EDITORIAL.Size = new System.Drawing.Size(35, 32);
            this.boton_ALTA_EDITORIAL.TabIndex = 31;
            this.boton_ALTA_EDITORIAL.Text = "+";
            this.boton_ALTA_EDITORIAL.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.boton_ALTA_EDITORIAL.UseVisualStyleBackColor = true;
            this.boton_ALTA_EDITORIAL.Click += new System.EventHandler(this.boton_ALTA_EDITORIAL_Click);
            // 
            // boton_ALTA_GENERO
            // 
            this.boton_ALTA_GENERO.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_ALTA_GENERO.Location = new System.Drawing.Point(297, 218);
            this.boton_ALTA_GENERO.Name = "boton_ALTA_GENERO";
            this.boton_ALTA_GENERO.Size = new System.Drawing.Size(35, 32);
            this.boton_ALTA_GENERO.TabIndex = 32;
            this.boton_ALTA_GENERO.Text = "+";
            this.boton_ALTA_GENERO.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.boton_ALTA_GENERO.UseVisualStyleBackColor = true;
            this.boton_ALTA_GENERO.Click += new System.EventHandler(this.boton_ALTA_GENERO_Click);
            // 
            // formLibros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 440);
            this.Controls.Add(this.boton_ALTA_GENERO);
            this.Controls.Add(this.boton_ALTA_EDITORIAL);
            this.Controls.Add(this.boton_ALTA_AUTOR);
            this.Controls.Add(this.comboBox_APELLIDO_AUTOR);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dateTime_FECHAALTA);
            this.Controls.Add(this.label_FECHA);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox_EDITORIAL);
            this.Controls.Add(this.comboBox_NOMBRE_AUTOR);
            this.Controls.Add(this.comboBox_GENERO);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSALIR);
            this.Controls.Add(this.btnAGREGAR);
            this.Controls.Add(this.textBox_UBICACION);
            this.Controls.Add(this.textBox_TITULO);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "formLibros";
            this.Text = "formLibros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_TITULO;
        private System.Windows.Forms.TextBox textBox_UBICACION;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_GENERO;
        private System.Windows.Forms.ComboBox comboBox_NOMBRE_AUTOR;
        private System.Windows.Forms.ComboBox comboBox_EDITORIAL;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label_FECHA;
        private System.Windows.Forms.DateTimePicker dateTime_FECHAALTA;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox_APELLIDO_AUTOR;
        private System.Windows.Forms.Button boton_ALTA_AUTOR;
        private System.Windows.Forms.Button boton_ALTA_EDITORIAL;
        private System.Windows.Forms.Button boton_ALTA_GENERO;
    }
}