
namespace Mainmen
{
    partial class For02cs
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
            this.buttonres = new System.Windows.Forms.Button();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.labelres2 = new System.Windows.Forms.Label();
            this.labelres = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonres
            // 
            this.buttonres.Location = new System.Drawing.Point(91, 52);
            this.buttonres.Margin = new System.Windows.Forms.Padding(6);
            this.buttonres.Name = "buttonres";
            this.buttonres.Size = new System.Drawing.Size(144, 35);
            this.buttonres.TabIndex = 0;
            this.buttonres.Text = "Порахувати";
            this.buttonres.UseVisualStyleBackColor = true;
            this.buttonres.Click += new System.EventHandler(this.buttonres_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.Location = new System.Drawing.Point(99, 11);
            this.labelN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(42, 24);
            this.labelN.TabIndex = 1;
            this.labelN.Text = "n = ";
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(153, 11);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(69, 29);
            this.textBoxN.TabIndex = 2;
            // 
            // labelres2
            // 
            this.labelres2.AutoSize = true;
            this.labelres2.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelres2.Location = new System.Drawing.Point(162, 106);
            this.labelres2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelres2.Name = "labelres2";
            this.labelres2.Size = new System.Drawing.Size(60, 24);
            this.labelres2.TabIndex = 3;
            this.labelres2.Text = "label1";
            this.labelres2.Visible = false;
            // 
            // labelres
            // 
            this.labelres.AutoSize = true;
            this.labelres.ForeColor = System.Drawing.Color.OrangeRed;
            this.labelres.Location = new System.Drawing.Point(42, 106);
            this.labelres.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelres.Name = "labelres";
            this.labelres.Size = new System.Drawing.Size(119, 24);
            this.labelres.TabIndex = 4;
            this.labelres.Text = "Результат =";
            this.labelres.Visible = false;
            // 
            // For02cs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.labelres);
            this.Controls.Add(this.labelres2);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.buttonres);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "For02cs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For02cs";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonres;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Label labelres2;
        private System.Windows.Forms.Label labelres;
    }
}