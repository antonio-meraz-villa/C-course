
namespace E03_Combobox
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
            this.tb_grados = new System.Windows.Forms.TextBox();
            this.lb_grados = new System.Windows.Forms.Label();
            this.cb_grados = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_grados2 = new System.Windows.Forms.ComboBox();
            this.tb_grados2 = new System.Windows.Forms.TextBox();
            this.b_convertir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_grados
            // 
            this.tb_grados.Location = new System.Drawing.Point(43, 32);
            this.tb_grados.Name = "tb_grados";
            this.tb_grados.Size = new System.Drawing.Size(64, 20);
            this.tb_grados.TabIndex = 0;
            // 
            // lb_grados
            // 
            this.lb_grados.AutoSize = true;
            this.lb_grados.Location = new System.Drawing.Point(43, 13);
            this.lb_grados.Name = "lb_grados";
            this.lb_grados.Size = new System.Drawing.Size(41, 13);
            this.lb_grados.TabIndex = 1;
            this.lb_grados.Text = "Grados";
            // 
            // cb_grados
            // 
            this.cb_grados.FormattingEnabled = true;
            this.cb_grados.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cb_grados.Location = new System.Drawing.Point(114, 30);
            this.cb_grados.Name = "cb_grados";
            this.cb_grados.Size = new System.Drawing.Size(121, 21);
            this.cb_grados.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(241, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "A";
            // 
            // cb_grados2
            // 
            this.cb_grados2.FormattingEnabled = true;
            this.cb_grados2.Items.AddRange(new object[] {
            "Celsius",
            "Fahrenheit",
            "Kelvin"});
            this.cb_grados2.Location = new System.Drawing.Point(261, 30);
            this.cb_grados2.Name = "cb_grados2";
            this.cb_grados2.Size = new System.Drawing.Size(121, 21);
            this.cb_grados2.TabIndex = 4;
            // 
            // tb_grados2
            // 
            this.tb_grados2.Enabled = false;
            this.tb_grados2.Location = new System.Drawing.Point(388, 32);
            this.tb_grados2.Name = "tb_grados2";
            this.tb_grados2.Size = new System.Drawing.Size(64, 20);
            this.tb_grados2.TabIndex = 5;
            // 
            // b_convertir
            // 
            this.b_convertir.Location = new System.Drawing.Point(210, 57);
            this.b_convertir.Name = "b_convertir";
            this.b_convertir.Size = new System.Drawing.Size(75, 23);
            this.b_convertir.TabIndex = 6;
            this.b_convertir.Text = "Convertir";
            this.b_convertir.UseVisualStyleBackColor = true;
            this.b_convertir.Click += new System.EventHandler(this.b_convertir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 98);
            this.Controls.Add(this.b_convertir);
            this.Controls.Add(this.tb_grados2);
            this.Controls.Add(this.cb_grados2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_grados);
            this.Controls.Add(this.lb_grados);
            this.Controls.Add(this.tb_grados);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_grados;
        private System.Windows.Forms.Label lb_grados;
        private System.Windows.Forms.ComboBox cb_grados;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_grados2;
        private System.Windows.Forms.TextBox tb_grados2;
        private System.Windows.Forms.Button b_convertir;
    }
}

