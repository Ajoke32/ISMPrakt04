
namespace Mainmen
{
    partial class For03
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
            this.LabelCh = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelN = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelresq = new System.Windows.Forms.Label();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LabelCh
            // 
            this.LabelCh.Location = new System.Drawing.Point(166, 9);
            this.LabelCh.Margin = new System.Windows.Forms.Padding(6);
            this.LabelCh.Name = "LabelCh";
            this.LabelCh.Size = new System.Drawing.Size(138, 42);
            this.LabelCh.TabIndex = 0;
            this.LabelCh.Text = "Порахувати";
            this.LabelCh.UseVisualStyleBackColor = true;
            this.LabelCh.Click += new System.EventHandler(this.LabelCh_Click);
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.ForeColor = System.Drawing.Color.Blue;
            this.labelA.Location = new System.Drawing.Point(15, 9);
            this.labelA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(36, 24);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a =";
            this.labelA.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.ForeColor = System.Drawing.Color.Red;
            this.labelN.Location = new System.Drawing.Point(14, 54);
            this.labelN.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(37, 24);
            this.labelN.TabIndex = 2;
            this.labelN.Text = "n =";
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelRes.Location = new System.Drawing.Point(59, 103);
            this.labelRes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(119, 24);
            this.labelRes.TabIndex = 3;
            this.labelRes.Text = "Результат =";
            this.labelRes.Visible = false;
            // 
            // labelresq
            // 
            this.labelresq.AutoSize = true;
            this.labelresq.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelresq.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelresq.Location = new System.Drawing.Point(180, 103);
            this.labelresq.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelresq.Name = "labelresq";
            this.labelresq.Size = new System.Drawing.Size(60, 24);
            this.labelresq.TabIndex = 4;
            this.labelresq.Text = "label4";
            this.labelresq.Visible = false;
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(63, 9);
            this.textBoxQ.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(66, 29);
            this.textBoxQ.TabIndex = 5;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(63, 49);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(66, 29);
            this.textBoxN.TabIndex = 6;
            // 
            // For03
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.labelresq);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.LabelCh);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "For03";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For03";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LabelCh;
        private System.Windows.Forms.Label labelA;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.Label labelRes;
        private System.Windows.Forms.Label labelresq;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.TextBox textBoxN;
    }
}