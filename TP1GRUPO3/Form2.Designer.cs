
namespace TP1GRUPO3
{
    partial class FormEjUno
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
            this.lbNombres = new System.Windows.Forms.ListBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombres = new System.Windows.Forms.TextBox();
            this.btnSinglePass = new System.Windows.Forms.Button();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.btnlistado = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNombres
            // 
            this.lbNombres.FormattingEnabled = true;
            this.lbNombres.Location = new System.Drawing.Point(61, 128);
            this.lbNombres.Margin = new System.Windows.Forms.Padding(2);
            this.lbNombres.Name = "lbNombres";
            this.lbNombres.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbNombres.Size = new System.Drawing.Size(200, 212);
            this.lbNombres.TabIndex = 0;
            this.lbNombres.SelectedIndexChanged += new System.EventHandler(this.lbNombres_SelectedIndexChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(457, 63);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(2);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(76, 31);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(57, 66);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(147, 20);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Ingrese un nombre:";
            // 
            // txtNombres
            // 
            this.txtNombres.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombres.Location = new System.Drawing.Point(213, 63);
            this.txtNombres.Margin = new System.Windows.Forms.Padding(2);
            this.txtNombres.Name = "txtNombres";
            this.txtNombres.Size = new System.Drawing.Size(221, 26);
            this.txtNombres.TabIndex = 3;
            this.txtNombres.TextChanged += new System.EventHandler(this.txtNombres_TextChanged);
            // 
            // btnSinglePass
            // 
            this.btnSinglePass.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSinglePass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSinglePass.Location = new System.Drawing.Point(311, 128);
            this.btnSinglePass.Name = "btnSinglePass";
            this.btnSinglePass.Size = new System.Drawing.Size(75, 33);
            this.btnSinglePass.TabIndex = 4;
            this.btnSinglePass.Text = ">";
            this.btnSinglePass.UseVisualStyleBackColor = true;
            this.btnSinglePass.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.Location = new System.Drawing.Point(457, 128);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSalida.Size = new System.Drawing.Size(192, 212);
            this.lbSalida.TabIndex = 5;
            // 
            // btnlistado
            // 
            this.btnlistado.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnlistado.Location = new System.Drawing.Point(311, 192);
            this.btnlistado.Name = "btnlistado";
            this.btnlistado.Size = new System.Drawing.Size(75, 33);
            this.btnlistado.TabIndex = 6;
            this.btnlistado.Text = ">>";
            this.btnlistado.UseVisualStyleBackColor = true;
            this.btnlistado.Click += new System.EventHandler(this.Btnlistado_Click);
            // 
            // FormEjUno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnlistado);
            this.Controls.Add(this.lbSalida);
            this.Controls.Add(this.btnSinglePass);
            this.Controls.Add(this.txtNombres);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lbNombres);
            this.Name = "FormEjUno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio Uno";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjUno_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbNombres;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombres;
        private System.Windows.Forms.Button btnSinglePass;
        private System.Windows.Forms.ListBox lbSalida;
        private System.Windows.Forms.Button btnlistado;
    }
}