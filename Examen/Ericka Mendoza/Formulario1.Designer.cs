namespace Ericka_Mendoza
{
    partial class Formulario1
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
            this.label1 = new System.Windows.Forms.Label();
            this.calcularbutton = new System.Windows.Forms.Button();
            this.tiempolistBox = new System.Windows.Forms.ListBox();
            this.captextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.interestextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese capital";
            // 
            // calcularbutton
            // 
            this.calcularbutton.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.calcularbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calcularbutton.Location = new System.Drawing.Point(247, 223);
            this.calcularbutton.Name = "calcularbutton";
            this.calcularbutton.Size = new System.Drawing.Size(90, 45);
            this.calcularbutton.TabIndex = 1;
            this.calcularbutton.Text = "Calcular";
            this.calcularbutton.UseVisualStyleBackColor = false;
            this.calcularbutton.Click += new System.EventHandler(this.calcularbutton_Click);
            // 
            // tiempolistBox
            // 
            this.tiempolistBox.FormattingEnabled = true;
            this.tiempolistBox.Items.AddRange(new object[] {
            "Intereses Gnerados:"});
            this.tiempolistBox.Location = new System.Drawing.Point(35, 107);
            this.tiempolistBox.Name = "tiempolistBox";
            this.tiempolistBox.Size = new System.Drawing.Size(167, 134);
            this.tiempolistBox.TabIndex = 2;
            // 
            // captextBox
            // 
            this.captextBox.Location = new System.Drawing.Point(125, 13);
            this.captextBox.Name = "captextBox";
            this.captextBox.Size = new System.Drawing.Size(100, 20);
            this.captextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Intereses";
            // 
            // interestextBox
            // 
            this.interestextBox.Location = new System.Drawing.Point(125, 49);
            this.interestextBox.Name = "interestextBox";
            this.interestextBox.Size = new System.Drawing.Size(100, 20);
            this.interestextBox.TabIndex = 5;
            // 
            // Formulario1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 326);
            this.Controls.Add(this.interestextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.captextBox);
            this.Controls.Add(this.tiempolistBox);
            this.Controls.Add(this.calcularbutton);
            this.Controls.Add(this.label1);
            this.Name = "Formulario1";
            this.Text = "Formulario1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button calcularbutton;
        private System.Windows.Forms.ListBox tiempolistBox;
        private System.Windows.Forms.TextBox captextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox interestextBox;
    }
}