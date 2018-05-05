namespace Practico2
{
    partial class Calculadora
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
            this.btnMensaje = new System.Windows.Forms.Button();
            this.txtDisplay = new System.Windows.Forms.TextBox();
            this.btnAsignarDatos = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMensaje
            // 
            this.btnMensaje.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMensaje.Location = new System.Drawing.Point(193, 39);
            this.btnMensaje.Name = "btnMensaje";
            this.btnMensaje.Size = new System.Drawing.Size(244, 60);
            this.btnMensaje.TabIndex = 0;
            this.btnMensaje.Text = "Mostrar mensaje";
            this.btnMensaje.UseVisualStyleBackColor = false;
            this.btnMensaje.Click += new System.EventHandler(this.btnMensaje_Click);
            // 
            // txtDisplay
            // 
            this.txtDisplay.Location = new System.Drawing.Point(250, 174);
            this.txtDisplay.Name = "txtDisplay";
            this.txtDisplay.Size = new System.Drawing.Size(100, 20);
            this.txtDisplay.TabIndex = 1;
            // 
            // btnAsignarDatos
            // 
            this.btnAsignarDatos.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnAsignarDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAsignarDatos.Location = new System.Drawing.Point(31, 251);
            this.btnAsignarDatos.Name = "btnAsignarDatos";
            this.btnAsignarDatos.Size = new System.Drawing.Size(244, 60);
            this.btnAsignarDatos.TabIndex = 2;
            this.btnAsignarDatos.Text = "Asignar datos";
            this.btnAsignarDatos.UseVisualStyleBackColor = false;
            this.btnAsignarDatos.Click += new System.EventHandler(this.btnAsignarDatos_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(330, 251);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(244, 60);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            // 
            // Calculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 356);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnAsignarDatos);
            this.Controls.Add(this.txtDisplay);
            this.Controls.Add(this.btnMensaje);
            this.Name = "Calculadora";
            this.Text = "Calculadora";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnMensaje;
        private System.Windows.Forms.TextBox txtDisplay;
        private System.Windows.Forms.Button btnAsignarDatos;
        private System.Windows.Forms.Button btnLimpiar;
    }
}

