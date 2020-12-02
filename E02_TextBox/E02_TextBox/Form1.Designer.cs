
namespace E02_TextBox
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
            this.tb_num3 = new System.Windows.Forms.TextBox();
            this.tb_num4 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_num3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_num3
            // 
            this.tb_num3.Location = new System.Drawing.Point(133, 39);
            this.tb_num3.Name = "tb_num3";
            this.tb_num3.Size = new System.Drawing.Size(53, 20);
            this.tb_num3.TabIndex = 0;
            // 
            // tb_num4
            // 
            this.tb_num4.Location = new System.Drawing.Point(133, 65);
            this.tb_num4.Name = "tb_num4";
            this.tb_num4.Size = new System.Drawing.Size(53, 20);
            this.tb_num4.TabIndex = 1;
            this.tb_num4.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(111, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Default;
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NUMERO 1:";
            // 
            // lb_num3
            // 
            this.lb_num3.AutoSize = true;
            this.lb_num3.Location = new System.Drawing.Point(60, 65);
            this.lb_num3.Name = "lb_num3";
            this.lb_num3.Size = new System.Drawing.Size(67, 13);
            this.lb_num3.TabIndex = 4;
            this.lb_num3.Text = "NUMERO 2:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(257, 159);
            this.Controls.Add(this.lb_num3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_num4);
            this.Controls.Add(this.tb_num3);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_num1;
        private System.Windows.Forms.TextBox tb_num1;
        private System.Windows.Forms.TextBox tb_num2;
        private System.Windows.Forms.Label lb_num2;
        private System.Windows.Forms.Button b_aceptar;
        private System.Windows.Forms.TextBox tb_num3;
        private System.Windows.Forms.TextBox tb_num4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_num3;
    }
}

