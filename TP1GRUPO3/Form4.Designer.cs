﻿
namespace TP1GRUPO3
{
    partial class FormEjTres
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
            this.gbNombre = new System.Windows.Forms.GroupBox();
            this.RadioMasc = new System.Windows.Forms.RadioButton();
            this.radioFem = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.gbEstado = new System.Windows.Forms.GroupBox();
            this.radioSoltero = new System.Windows.Forms.RadioButton();
            this.radioCasado = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.clbOficios = new System.Windows.Forms.CheckedListBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lbElementos = new System.Windows.Forms.Label();
            this.lblOficio = new System.Windows.Forms.Label();
            this.gbNombre.SuspendLayout();
            this.gbEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Controls.Add(this.RadioMasc);
            this.gbNombre.Controls.Add(this.radioFem);
            this.gbNombre.Controls.Add(this.lblApellido);
            this.gbNombre.Controls.Add(this.btnAgrgar);
            this.gbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNombre.Location = new System.Drawing.Point(37, 13);
            this.gbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNombre.Size = new System.Drawing.Size(208, 99);
            this.gbNombre.TabIndex = 1;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Sexo";
            this.gbNombre.Enter += new System.EventHandler(this.gbNombre_Enter);
            // 
            // RadioMasc
            // 
            this.RadioMasc.AutoSize = true;
            this.RadioMasc.Location = new System.Drawing.Point(20, 55);
            this.RadioMasc.Name = "RadioMasc";
            this.RadioMasc.Size = new System.Drawing.Size(107, 24);
            this.RadioMasc.TabIndex = 4;
            this.RadioMasc.Text = "Masculino";
            this.RadioMasc.UseVisualStyleBackColor = true;
            // 
            // radioFem
            // 
            this.radioFem.AutoSize = true;
            this.radioFem.Checked = true;
            this.radioFem.Location = new System.Drawing.Point(20, 25);
            this.radioFem.Name = "radioFem";
            this.radioFem.Size = new System.Drawing.Size(106, 24);
            this.radioFem.TabIndex = 3;
            this.radioFem.TabStop = true;
            this.radioFem.Text = "Femenino";
            this.radioFem.UseVisualStyleBackColor = true;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(37, 167);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(78, 20);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // btnAgrgar
            // 
            this.btnAgrgar.Location = new System.Drawing.Point(122, 236);
            this.btnAgrgar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAgrgar.Name = "btnAgrgar";
            this.btnAgrgar.Size = new System.Drawing.Size(95, 28);
            this.btnAgrgar.TabIndex = 0;
            this.btnAgrgar.Text = "Agregar";
            this.btnAgrgar.UseVisualStyleBackColor = true;
            // 
            // gbEstado
            // 
            this.gbEstado.Controls.Add(this.radioSoltero);
            this.gbEstado.Controls.Add(this.radioCasado);
            this.gbEstado.Controls.Add(this.label1);
            this.gbEstado.Controls.Add(this.button1);
            this.gbEstado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbEstado.Location = new System.Drawing.Point(395, 13);
            this.gbEstado.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Name = "gbEstado";
            this.gbEstado.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbEstado.Size = new System.Drawing.Size(208, 99);
            this.gbEstado.TabIndex = 2;
            this.gbEstado.TabStop = false;
            this.gbEstado.Text = "Estado Civil";
            this.gbEstado.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // radioSoltero
            // 
            this.radioSoltero.AutoSize = true;
            this.radioSoltero.Location = new System.Drawing.Point(20, 61);
            this.radioSoltero.Name = "radioSoltero";
            this.radioSoltero.Size = new System.Drawing.Size(85, 24);
            this.radioSoltero.TabIndex = 4;
            this.radioSoltero.Text = "Soltero";
            this.radioSoltero.UseVisualStyleBackColor = true;
            // 
            // radioCasado
            // 
            this.radioCasado.AutoSize = true;
            this.radioCasado.Checked = true;
            this.radioCasado.Location = new System.Drawing.Point(20, 24);
            this.radioCasado.Name = "radioCasado";
            this.radioCasado.Size = new System.Drawing.Size(88, 24);
            this.radioCasado.TabIndex = 3;
            this.radioCasado.TabStop = true;
            this.radioCasado.Text = "Casado";
            this.radioCasado.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 167);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Apellido:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(122, 236);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "Agregar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // clbOficios
            // 
            this.clbOficios.FormattingEnabled = true;
            this.clbOficios.Items.AddRange(new object[] {
            "Data Entry",
            "Operador de PC",
            "Programador",
            "Reparador de PC",
            "Tester"});
            this.clbOficios.Location = new System.Drawing.Point(186, 149);
            this.clbOficios.Name = "clbOficios";
            this.clbOficios.Size = new System.Drawing.Size(266, 79);
            this.clbOficios.TabIndex = 3;
            this.clbOficios.SelectedIndexChanged += new System.EventHandler(this.clbOficios_SelectedIndexChanged);
            // 
            // btnMostrar
            // 
            this.btnMostrar.Location = new System.Drawing.Point(232, 249);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(155, 23);
            this.btnMostrar.TabIndex = 8;
            this.btnMostrar.Text = "Mostrar lo que se seleccionó";
            this.btnMostrar.UseVisualStyleBackColor = true;
            this.btnMostrar.Click += new System.EventHandler(this.label2_Click);
            // 
            // lbElementos
            // 
            this.lbElementos.AutoSize = true;
            this.lbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbElementos.Location = new System.Drawing.Point(12, 300);
            this.lbElementos.Name = "lbElementos";
            this.lbElementos.Size = new System.Drawing.Size(375, 20);
            this.lbElementos.TabIndex = 9;
            this.lbElementos.Text = "Usted seleccionó los siguientes elementos:";
            this.lbElementos.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblOficio
            // 
            this.lblOficio.AutoSize = true;
            this.lblOficio.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOficio.Location = new System.Drawing.Point(12, 384);
            this.lblOficio.Name = "lblOficio";
            this.lblOficio.Size = new System.Drawing.Size(60, 20);
            this.lblOficio.TabIndex = 10;
            this.lblOficio.Text = "Oficio:";
            // 
            // FormEjTres
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 533);
            this.Controls.Add(this.lblOficio);
            this.Controls.Add(this.lbElementos);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.clbOficios);
            this.Controls.Add(this.gbEstado);
            this.Controls.Add(this.gbNombre);
            this.Name = "FormEjTres";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 3";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjTres_FormClosed);
            this.Load += new System.EventHandler(this.FormEjTres_Load);
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbEstado.ResumeLayout(false);
            this.gbEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Button btnAgrgar;
        private System.Windows.Forms.GroupBox gbEstado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton RadioMasc;
        private System.Windows.Forms.RadioButton radioFem;
        private System.Windows.Forms.RadioButton radioSoltero;
        private System.Windows.Forms.RadioButton radioCasado;
        private System.Windows.Forms.CheckedListBox clbOficios;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.Label lbElementos;
        private System.Windows.Forms.Label lblOficio;
    }
}