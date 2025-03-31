
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
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.btnAgrgar = new System.Windows.Forms.Button();
            this.gbElementos = new System.Windows.Forms.GroupBox();
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.btnBorrar = new System.Windows.Forms.Button();
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
            this.gbNombre.Location = new System.Drawing.Point(26, 37);
            this.gbNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNombre.Name = "gbNombre";
            this.gbNombre.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbNombre.Size = new System.Drawing.Size(262, 323);
            this.gbNombre.TabIndex = 0;
            this.gbNombre.TabStop = false;
            this.gbNombre.Text = "Ingresar nombre";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(122, 167);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(96, 26);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(122, 121);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(96, 26);
            this.txtNombre.TabIndex = 3;
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
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(37, 121);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(76, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
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
            this.btnAgrgar.Click += new System.EventHandler(this.btnAgrgar_Click);
            // 
            // gbElementos
            // 
            this.gbElementos.Controls.Add(this.lbSalida);
            this.gbElementos.Controls.Add(this.btnBorrar);
            this.gbElementos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbElementos.Location = new System.Drawing.Point(374, 37);
            this.gbElementos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbElementos.Name = "gbElementos";
            this.gbElementos.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.gbElementos.Size = new System.Drawing.Size(262, 323);
            this.gbElementos.TabIndex = 1;
            this.gbElementos.TabStop = false;
            this.gbElementos.Text = "Elementos";
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.ItemHeight = 20;
            this.lbSalida.Location = new System.Drawing.Point(14, 57);
            this.lbSalida.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbSalida.Size = new System.Drawing.Size(228, 184);
            this.lbSalida.TabIndex = 1;
            this.lbSalida.SelectedIndexChanged += new System.EventHandler(this.lbSalida_SelectedIndexChanged);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(84, 258);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(88, 28);
            this.btnBorrar.TabIndex = 0;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // FormEjDos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbElementos);
            this.Controls.Add(this.gbNombre);
            this.Name = "FormEjDos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ejercicio 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormEjDos_FormClosed);
            this.Load += new System.EventHandler(this.FormEjDos_Load);
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