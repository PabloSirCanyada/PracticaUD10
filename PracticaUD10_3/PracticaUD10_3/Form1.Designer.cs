
namespace PracticaUD10_3
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
            this.bGuardar = new System.Windows.Forms.Button();
            this.tNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tApellidos = new System.Windows.Forms.TextBox();
            this.tMovil = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.listSocios = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lSocios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bGuardar
            // 
            this.bGuardar.Location = new System.Drawing.Point(560, 90);
            this.bGuardar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bGuardar.Name = "bGuardar";
            this.bGuardar.Size = new System.Drawing.Size(76, 29);
            this.bGuardar.TabIndex = 0;
            this.bGuardar.Text = "Guardar";
            this.bGuardar.UseVisualStyleBackColor = true;
            this.bGuardar.Click += new System.EventHandler(this.bGuardar_Click);
            // 
            // tNombre
            // 
            this.tNombre.Location = new System.Drawing.Point(78, 53);
            this.tNombre.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tNombre.Name = "tNombre";
            this.tNombre.Size = new System.Drawing.Size(138, 20);
            this.tNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(237, 56);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Apellidos:";
            // 
            // tApellidos
            // 
            this.tApellidos.Location = new System.Drawing.Point(293, 55);
            this.tApellidos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tApellidos.Name = "tApellidos";
            this.tApellidos.Size = new System.Drawing.Size(138, 20);
            this.tApellidos.TabIndex = 4;
            // 
            // tMovil
            // 
            this.tMovil.Location = new System.Drawing.Point(500, 55);
            this.tMovil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tMovil.Name = "tMovil";
            this.tMovil.Size = new System.Drawing.Size(138, 20);
            this.tMovil.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(462, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Móvil:";
            // 
            // listSocios
            // 
            this.listSocios.FormattingEnabled = true;
            this.listSocios.Location = new System.Drawing.Point(26, 149);
            this.listSocios.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listSocios.Name = "listSocios";
            this.listSocios.Size = new System.Drawing.Size(612, 277);
            this.listSocios.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 123);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Lista de socios:";
            // 
            // lSocios
            // 
            this.lSocios.AutoSize = true;
            this.lSocios.Location = new System.Drawing.Point(36, 161);
            this.lSocios.Name = "lSocios";
            this.lSocios.Size = new System.Drawing.Size(0, 13);
            this.lSocios.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 457);
            this.Controls.Add(this.lSocios);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listSocios);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tMovil);
            this.Controls.Add(this.tApellidos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tNombre);
            this.Controls.Add(this.bGuardar);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Grabar Socio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bGuardar;
        private System.Windows.Forms.TextBox tNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tApellidos;
        private System.Windows.Forms.TextBox tMovil;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox listSocios;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lSocios;
    }
}

