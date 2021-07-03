
namespace Ejercicio5_LilianKenyon
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
            this.ejecutarbutton1 = new System.Windows.Forms.Button();
            this.numfilatextBox1 = new System.Windows.Forms.TextBox();
            this.numcolumnatextBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Limpiarbutton2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ejecutarbutton1
            // 
            this.ejecutarbutton1.Location = new System.Drawing.Point(156, 214);
            this.ejecutarbutton1.Name = "ejecutarbutton1";
            this.ejecutarbutton1.Size = new System.Drawing.Size(125, 48);
            this.ejecutarbutton1.TabIndex = 0;
            this.ejecutarbutton1.Text = "EJECUTAR";
            this.ejecutarbutton1.UseVisualStyleBackColor = true;
            this.ejecutarbutton1.Click += new System.EventHandler(this.ejecutarbutton1_Click);
            // 
            // numfilatextBox1
            // 
            this.numfilatextBox1.Location = new System.Drawing.Point(266, 48);
            this.numfilatextBox1.Name = "numfilatextBox1";
            this.numfilatextBox1.Size = new System.Drawing.Size(100, 26);
            this.numfilatextBox1.TabIndex = 1;
            // 
            // numcolumnatextBox2
            // 
            this.numcolumnatextBox2.Location = new System.Drawing.Point(266, 89);
            this.numcolumnatextBox2.Name = "numcolumnatextBox2";
            this.numcolumnatextBox2.Size = new System.Drawing.Size(100, 26);
            this.numcolumnatextBox2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese primer número";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese segundo número";
            // 
            // Limpiarbutton2
            // 
            this.Limpiarbutton2.Location = new System.Drawing.Point(320, 214);
            this.Limpiarbutton2.Name = "Limpiarbutton2";
            this.Limpiarbutton2.Size = new System.Drawing.Size(137, 50);
            this.Limpiarbutton2.TabIndex = 5;
            this.Limpiarbutton2.Text = "LIMPIAR";
            this.Limpiarbutton2.UseVisualStyleBackColor = true;
            this.Limpiarbutton2.Click += new System.EventHandler(this.Limpiarbutton2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Limpiarbutton2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numcolumnatextBox2);
            this.Controls.Add(this.numfilatextBox1);
            this.Controls.Add(this.ejecutarbutton1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ejecutarbutton1;
        private System.Windows.Forms.TextBox numfilatextBox1;
        private System.Windows.Forms.TextBox numcolumnatextBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Limpiarbutton2;
    }
}

