namespace TP1GRUPO3
{
    partial class FormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnEjUno = new System.Windows.Forms.Button();
            this.btnEjDos = new System.Windows.Forms.Button();
            this.btnEjTres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEjUno
            // 
            this.btnEjUno.AutoSize = true;
            this.btnEjUno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjUno.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjUno.Location = new System.Drawing.Point(101, 41);
            this.btnEjUno.Name = "btnEjUno";
            this.btnEjUno.Size = new System.Drawing.Size(169, 36);
            this.btnEjUno.TabIndex = 0;
            this.btnEjUno.Text = "EJERCICIO 1";
            this.btnEjUno.UseVisualStyleBackColor = true;
            this.btnEjUno.Click += new System.EventHandler(this.btnEjUno_Click);
            // 
            // btnEjDos
            // 
            this.btnEjDos.AutoSize = true;
            this.btnEjDos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjDos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjDos.Location = new System.Drawing.Point(302, 41);
            this.btnEjDos.Name = "btnEjDos";
            this.btnEjDos.Size = new System.Drawing.Size(169, 36);
            this.btnEjDos.TabIndex = 1;
            this.btnEjDos.Text = "EJERCICIO 2";
            this.btnEjDos.UseVisualStyleBackColor = true;
            this.btnEjDos.Click += new System.EventHandler(this.btnEjDos_Click);
            // 
            // btnEjTres
            // 
            this.btnEjTres.AutoSize = true;
            this.btnEjTres.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEjTres.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEjTres.Location = new System.Drawing.Point(501, 41);
            this.btnEjTres.Name = "btnEjTres";
            this.btnEjTres.Size = new System.Drawing.Size(169, 36);
            this.btnEjTres.TabIndex = 2;
            this.btnEjTres.Text = "EJERCICIO 3";
            this.btnEjTres.UseVisualStyleBackColor = true;
            this.btnEjTres.Click += new System.EventHandler(this.btnEjTres_Click);
            // 
            // FormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEjTres);
            this.Controls.Add(this.btnEjDos);
            this.Controls.Add(this.btnEjUno);
            this.Name = "FormularioPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Formulario Principal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEjUno;
        private System.Windows.Forms.Button btnEjDos;
        private System.Windows.Forms.Button btnEjTres;
    }
}

