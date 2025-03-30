
namespace TP1GRUPO3
{
    partial class FormEjDos
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
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.gbNombre.SuspendLayout();
            this.gbElementos.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbNombre
            // 
            this.gbNombre.Controls.Add(this.txtApellido);
            this.gbNombre.Controls.Add(this.txtNombre);
            this.gbNombre.Controls.Add(this.lblApellido);
            this.gbNombre.Controls.Add(this.lblNombre);
            this.gbNombre.Controls.Add(this.btnAgrgar);
            this.gbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbNombre.Location = new System.Drawing.Point(34, 45);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Size = new System.Drawing.Size(350, 398);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Ingresar nombre";
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.lbSalida);
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElementos.Location = new System.Drawing.Point(498, 45);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Size = new System.Drawing.Size(350, 398);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // btnAgrgar
            // 
            this.btnAgrgar.Location = new System.Drawing.Point(163, 290);
            this.btnAgrgar.Name = "btnAgrgar";
            this.btnAgrgar.Size = new System.Drawing.Size(127, 35);
            this.btnAgrgar.TabIndex = 0;
            this.btnAgrgar.Text = "Agregar";
            this.btnAgrgar.UseVisualStyleBackColor = true;
            this.btnAgrgar.Click += new System.EventHandler(this.btnAgrgar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(112, 318);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(117, 35);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(49, 149);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(94, 25);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(49, 205);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(97, 25);
            this.lblApellido.TabIndex = 2;
            this.lblApellido.Text = "Apellido:";
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.ItemHeight = 25;
            this.lbSalida.Location = new System.Drawing.Point(19, 70);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(302, 229);
            this.lbSalida.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(163, 149);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(127, 30);
            this.txtNombre.TabIndex = 3;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(163, 205);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(127, 30);
            this.txtApellido.TabIndex = 4;
            // 
            // FormEjDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbNombre);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FormEjDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjDos_FormClosed);
            this.gbNombre.ResumeLayout(false);
            this.gbNombre.PerformLayout();
            this.gbElementos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button btnAgrgar;
        private System.Windows.Forms.GroupBox gbElementos;
        private System.Windows.Forms.ListBox lbSalida;
        private System.Windows.Forms.Button btnBorrar;
    }
}