
namespace Mainmen
{
    partial class Form05
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
            this.labelres = new System.Windows.Forms.Label();
            this.labelres2 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelN = new System.Windows.Forms.Label();
            this.buttonres = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelres
            // 
            this.labelres.AutoSize = true;
            this.labelres.ForeColor = System.Drawing.Color.Lime;
            this.labelres.Location = new System.Drawing.Point(88, 123);
            this.labelres.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelres.Name = "labelres";
            this.labelres.Size = new System.Drawing.Size(119, 24);
            this.labelres.TabIndex = 9;
            this.labelres.Text = "Результат =";
            this.labelres.Visible = false;
            // 
            // labelres2
            // 
            this.labelres2.AutoSize = true;
            this.labelres2.ForeColor = System.Drawing.Color.Lime;
            this.labelres2.Location = new System.Drawing.Point(207, 123);
            this.labelres2.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelres2.Name = "labelres2";
            this.labelres2.Size = new System.Drawing.Size(60, 24);
            this.labelres2.TabIndex = 8;
            this.labelres2.Text = "label1";
            this.labelres2.Visible = false;
            // 
            // textBoxN
            // 
            this.textBoxN.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxN.ForeColor = System.Drawing.Color.Lime;
            this.textBoxN.Location = new System.Drawing.Point(140, 9);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(11);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(88, 29);
            this.textBoxN.TabIndex = 7;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.ForeColor = System.Drawing.Color.Lime;
            this.labelN.Location = new System.Drawing.Point(103, 12);
            this.labelN.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(42, 24);
            this.labelN.TabIndex = 6;
            this.labelN.Text = "n = ";
            // 
            // buttonres
            // 
            this.buttonres.ForeColor = System.Drawing.Color.Lime;
            this.buttonres.Location = new System.Drawing.Point(72, 60);
            this.buttonres.Margin = new System.Windows.Forms.Padding(11);
            this.buttonres.Name = "buttonres";
            this.buttonres.Size = new System.Drawing.Size(204, 42);
            this.buttonres.TabIndex = 5;
            this.buttonres.Text = "Порахувати";
            this.buttonres.UseVisualStyleBackColor = true;
            this.buttonres.Click += new System.EventHandler(this.buttonres_Click);
            // 
            // Form05
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.labelres);
            this.Controls.Add(this.labelres2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form05";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form05";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelres;
        private System.Windows.Forms.Label labelres2;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Button buttonres;
    }
}