namespace CharAndFibonacci
{
    partial class Form1
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
            this.buttonFibo = new System.Windows.Forms.Button();
            this.textBoxFibo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxFiboMegoldas = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonFibo
            // 
            this.buttonFibo.Location = new System.Drawing.Point(370, 171);
            this.buttonFibo.Name = "buttonFibo";
            this.buttonFibo.Size = new System.Drawing.Size(75, 23);
            this.buttonFibo.TabIndex = 0;
            this.buttonFibo.Text = "Mehet";
            this.buttonFibo.UseVisualStyleBackColor = true;
            this.buttonFibo.Click += new System.EventHandler(this.buttonFibo_Click);
            // 
            // textBoxFibo
            // 
            this.textBoxFibo.Location = new System.Drawing.Point(86, 48);
            this.textBoxFibo.Multiline = true;
            this.textBoxFibo.Name = "textBoxFibo";
            this.textBoxFibo.Size = new System.Drawing.Size(359, 41);
            this.textBoxFibo.TabIndex = 1;
            this.textBoxFibo.Text = "A szövegdoboz jelenleg pontosan -55 karaktert tartalmaz";
            this.textBoxFibo.Click += new System.EventHandler(this.textBoxFibo_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Kérem adjon meg maximum 55 karaktert";
            // 
            // textBoxFiboMegoldas
            // 
            this.textBoxFiboMegoldas.Location = new System.Drawing.Point(86, 95);
            this.textBoxFiboMegoldas.Multiline = true;
            this.textBoxFiboMegoldas.Name = "textBoxFiboMegoldas";
            this.textBoxFiboMegoldas.Size = new System.Drawing.Size(359, 41);
            this.textBoxFiboMegoldas.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 215);
            this.Controls.Add(this.textBoxFiboMegoldas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFibo);
            this.Controls.Add(this.buttonFibo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFibo;
        private System.Windows.Forms.TextBox textBoxFibo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxFiboMegoldas;
    }
}

