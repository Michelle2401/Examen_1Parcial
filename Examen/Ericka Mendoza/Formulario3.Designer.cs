namespace Ericka_Mendoza
{
    partial class Formulario3
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
            this.button1 = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.ListBox();
            this.multiplotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hastatexBox = new System.Windows.Forms.NumericUpDown();
            this.desdetexBox = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.hastatexBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdetexBox)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 87);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // list
            // 
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(22, 125);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(263, 329);
            this.list.TabIndex = 1;
            // 
            // multiplotextBox
            // 
            this.multiplotextBox.Location = new System.Drawing.Point(106, 19);
            this.multiplotextBox.Name = "multiplotextBox";
            this.multiplotextBox.Size = new System.Drawing.Size(100, 20);
            this.multiplotextBox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Listar multiplos de";
            // 
            // hastatexBox
            // 
            this.hastatexBox.Location = new System.Drawing.Point(190, 61);
            this.hastatexBox.Name = "hastatexBox";
            this.hastatexBox.Size = new System.Drawing.Size(120, 20);
            this.hastatexBox.TabIndex = 4;
            this.hastatexBox.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // desdetexBox
            // 
            this.desdetexBox.Location = new System.Drawing.Point(13, 61);
            this.desdetexBox.Name = "desdetexBox";
            this.desdetexBox.Size = new System.Drawing.Size(120, 20);
            this.desdetexBox.TabIndex = 5;
            this.desdetexBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Hasta";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 87);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Formulario3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(330, 487);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.desdetexBox);
            this.Controls.Add(this.hastatexBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.multiplotextBox);
            this.Controls.Add(this.list);
            this.Controls.Add(this.button1);
            this.Name = "Formulario3";
            this.Text = "Formulario3";
            
            ((System.ComponentModel.ISupportInitialize)(this.hastatexBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desdetexBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox list;
        private System.Windows.Forms.TextBox multiplotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown hastatexBox;
        private System.Windows.Forms.NumericUpDown desdetexBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
    }
}