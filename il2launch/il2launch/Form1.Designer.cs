namespace il2launch
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonTR = new System.Windows.Forms.Button();
            this.buttonHotas = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonTR
            // 
            this.buttonTR.Location = new System.Drawing.Point(12, 12);
            this.buttonTR.Name = "buttonTR";
            this.buttonTR.Size = new System.Drawing.Size(75, 23);
            this.buttonTR.TabIndex = 0;
            this.buttonTR.Text = "TR set";
            this.buttonTR.UseVisualStyleBackColor = true;
            this.buttonTR.Click += new System.EventHandler(this.buttonTR_Click);
            // 
            // buttonHotas
            // 
            this.buttonHotas.Location = new System.Drawing.Point(12, 41);
            this.buttonHotas.Name = "buttonHotas";
            this.buttonHotas.Size = new System.Drawing.Size(75, 23);
            this.buttonHotas.TabIndex = 1;
            this.buttonHotas.Text = "Hotas";
            this.buttonHotas.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 216);
            this.Controls.Add(this.buttonHotas);
            this.Controls.Add(this.buttonTR);
            this.Name = "Form1";
            this.Text = "il2 launch";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonTR;
        private System.Windows.Forms.Button buttonHotas;
    }
}

