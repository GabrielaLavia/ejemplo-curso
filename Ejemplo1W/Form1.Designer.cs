namespace Ejemplo1W
{
    partial class Form1
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
            this.btnSaludar = new System.Windows.Forms.Button();
            this.labelSaludo = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaludar
            // 
            this.btnSaludar.Location = new System.Drawing.Point(277, 96);
            this.btnSaludar.Name = "btnSaludar";
            this.btnSaludar.Size = new System.Drawing.Size(75, 23);
            this.btnSaludar.TabIndex = 0;
            this.btnSaludar.Text = "Saludar";
            this.btnSaludar.UseVisualStyleBackColor = true;
            this.btnSaludar.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // labelSaludo
            // 
            this.labelSaludo.AutoSize = true;
            this.labelSaludo.Location = new System.Drawing.Point(289, 204);
            this.labelSaludo.Name = "labelSaludo";
            this.labelSaludo.Size = new System.Drawing.Size(0, 13);
            this.labelSaludo.TabIndex = 1;
            this.labelSaludo.Click += new System.EventHandler(this.btnSaludar_Click);
            // 
            // textNombre
            // 
            this.textNombre.Location = new System.Drawing.Point(292, 49);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(222, 55);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(47, 13);
            this.labelNombre.TabIndex = 3;
            this.labelNombre.Text = "Nombre:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.labelSaludo);
            this.Controls.Add(this.btnSaludar);
            this.Name = "Form1";
            this.Text = "PRIMERA APP";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
           
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaludar;
        private System.Windows.Forms.Label labelSaludo;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.Label labelNombre;
    }
}

