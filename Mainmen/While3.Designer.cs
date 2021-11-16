
namespace Mainmen
{
    partial class While3
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
            this.buttonRes = new System.Windows.Forms.Button();
            this.labelP = new System.Windows.Forms.Label();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.labelK = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelSum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(98, 56);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(138, 42);
            this.buttonRes.TabIndex = 0;
            this.buttonRes.Text = "Порахувати";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // labelP
            // 
            this.labelP.AutoSize = true;
            this.labelP.Location = new System.Drawing.Point(119, 15);
            this.labelP.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelP.Name = "labelP";
            this.labelP.Size = new System.Drawing.Size(38, 24);
            this.labelP.TabIndex = 1;
            this.labelP.Text = "P =";
            this.labelP.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(156, 12);
            this.textBoxP.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(52, 29);
            this.textBoxP.TabIndex = 2;
            this.textBoxP.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelK
            // 
            this.labelK.AutoSize = true;
            this.labelK.BackColor = System.Drawing.SystemColors.Control;
            this.labelK.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelK.ForeColor = System.Drawing.Color.Purple;
            this.labelK.Location = new System.Drawing.Point(6, 119);
            this.labelK.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelK.Name = "labelK";
            this.labelK.Size = new System.Drawing.Size(144, 24);
            this.labelK.TabIndex = 4;
            this.labelK.Text = "Кількість днів :";
            this.labelK.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.Location = new System.Drawing.Point(148, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // labelSum
            // 
            this.labelSum.AutoSize = true;
            this.labelSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSum.Location = new System.Drawing.Point(-2, 143);
            this.labelSum.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelSum.Name = "labelSum";
            this.labelSum.Size = new System.Drawing.Size(166, 24);
            this.labelSum.TabIndex = 6;
            this.labelSum.Text = "Сумарний пробіг:";
            this.labelSum.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(162, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // While3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.labelSum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelK);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.labelP);
            this.Controls.Add(this.buttonRes);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "While3";
            this.Text = "While3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRes;
        private System.Windows.Forms.Label labelP;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.Label labelSum;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label labelK;
        public System.Windows.Forms.Label label3;
    }
}