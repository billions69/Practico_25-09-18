﻿namespace Trabajo_PabloPerez {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent() {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.cboQuitar = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtConsonantes = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtVocales = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLineas = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTabuladores = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBlancos = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCaracteres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPalabras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLectura = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNombreRuta = new System.Windows.Forms.TextBox();
            this.btnExaminar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnProcesar);
            this.groupBox1.Controls.Add(this.cboQuitar);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtConsonantes);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtVocales);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtLineas);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtTabuladores);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBlancos);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtCaracteres);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtPalabras);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLectura);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtNombreRuta);
            this.groupBox1.Controls.Add(this.btnExaminar);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(714, 517);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(472, 463);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(103, 23);
            this.btnGuardar.TabIndex = 23;
            this.btnGuardar.Text = "Guardar como...";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(363, 463);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(103, 23);
            this.btnProcesar.TabIndex = 22;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.button2_Click);
            // 
            // cboQuitar
            // 
            this.cboQuitar.FormattingEnabled = true;
            this.cboQuitar.Items.AddRange(new object[] {
            "Espacios en blanco",
            "Vocales",
            "Consonantes"});
            this.cboQuitar.Location = new System.Drawing.Point(199, 465);
            this.cboQuitar.Name = "cboQuitar";
            this.cboQuitar.Size = new System.Drawing.Size(158, 21);
            this.cboQuitar.TabIndex = 21;
            this.cboQuitar.SelectedIndexChanged += new System.EventHandler(this.cboQuitar_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(141, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 18);
            this.label10.TabIndex = 20;
            this.label10.Text = "Quitar:";
            // 
            // txtConsonantes
            // 
            this.txtConsonantes.Enabled = false;
            this.txtConsonantes.Location = new System.Drawing.Point(344, 423);
            this.txtConsonantes.Name = "txtConsonantes";
            this.txtConsonantes.Size = new System.Drawing.Size(100, 20);
            this.txtConsonantes.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(237, 422);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 18);
            this.label8.TabIndex = 16;
            this.label8.Text = "Consonantes:";
            // 
            // txtVocales
            // 
            this.txtVocales.Enabled = false;
            this.txtVocales.Location = new System.Drawing.Point(344, 398);
            this.txtVocales.Name = "txtVocales";
            this.txtVocales.Size = new System.Drawing.Size(100, 20);
            this.txtVocales.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(273, 397);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Vocales:";
            // 
            // txtLineas
            // 
            this.txtLineas.Enabled = false;
            this.txtLineas.Location = new System.Drawing.Point(344, 372);
            this.txtLineas.Name = "txtLineas";
            this.txtLineas.Size = new System.Drawing.Size(100, 20);
            this.txtLineas.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(283, 371);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Líneas:";
            // 
            // txtTabuladores
            // 
            this.txtTabuladores.Enabled = false;
            this.txtTabuladores.Location = new System.Drawing.Point(344, 346);
            this.txtTabuladores.Name = "txtTabuladores";
            this.txtTabuladores.Size = new System.Drawing.Size(100, 20);
            this.txtTabuladores.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(244, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tabuladores:";
            // 
            // txtBlancos
            // 
            this.txtBlancos.Enabled = false;
            this.txtBlancos.Location = new System.Drawing.Point(344, 320);
            this.txtBlancos.Name = "txtBlancos";
            this.txtBlancos.Size = new System.Drawing.Size(100, 20);
            this.txtBlancos.TabIndex = 9;
            this.txtBlancos.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(196, 319);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 18);
            this.label4.TabIndex = 8;
            this.label4.Text = "Espacios en blanco:";
            // 
            // txtCaracteres
            // 
            this.txtCaracteres.Enabled = false;
            this.txtCaracteres.Location = new System.Drawing.Point(344, 294);
            this.txtCaracteres.Name = "txtCaracteres";
            this.txtCaracteres.Size = new System.Drawing.Size(100, 20);
            this.txtCaracteres.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(253, 293);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Caracteres:";
            // 
            // txtPalabras
            // 
            this.txtPalabras.Enabled = false;
            this.txtPalabras.Location = new System.Drawing.Point(344, 268);
            this.txtPalabras.Name = "txtPalabras";
            this.txtPalabras.Size = new System.Drawing.Size(100, 20);
            this.txtPalabras.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(268, 267);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Palabras:";
            // 
            // txtLectura
            // 
            this.txtLectura.Enabled = false;
            this.txtLectura.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLectura.Location = new System.Drawing.Point(7, 63);
            this.txtLectura.Multiline = true;
            this.txtLectura.Name = "txtLectura";
            this.txtLectura.Size = new System.Drawing.Size(690, 201);
            this.txtLectura.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Archivo:";
            // 
            // txtNombreRuta
            // 
            this.txtNombreRuta.Enabled = false;
            this.txtNombreRuta.Location = new System.Drawing.Point(159, 22);
            this.txtNombreRuta.Name = "txtNombreRuta";
            this.txtNombreRuta.Size = new System.Drawing.Size(403, 20);
            this.txtNombreRuta.TabIndex = 1;
            // 
            // btnExaminar
            // 
            this.btnExaminar.Location = new System.Drawing.Point(568, 20);
            this.btnExaminar.Name = "btnExaminar";
            this.btnExaminar.Size = new System.Drawing.Size(129, 23);
            this.btnExaminar.TabIndex = 0;
            this.btnExaminar.Text = "Examinar";
            this.btnExaminar.UseVisualStyleBackColor = true;
            this.btnExaminar.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(741, 542);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtLectura;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNombreRuta;
        private System.Windows.Forms.Button btnExaminar;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.ComboBox cboQuitar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtConsonantes;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtVocales;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtLineas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTabuladores;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBlancos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCaracteres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPalabras;
        private System.Windows.Forms.Label label2;
    }
}

