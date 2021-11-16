
namespace Mainmen
{
    partial class For01
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
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.buttonResult = new System.Windows.Forms.Button();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(15, 12);
            this.labelA.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(36, 24);
            this.labelA.TabIndex = 0;
            this.labelA.Text = "a =";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(185, 10);
            this.labelB.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(37, 24);
            this.labelB.TabIndex = 1;
            this.labelB.Text = "b =";
            this.labelB.Click += new System.EventHandler(this.labelB_Click);
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelRes.Location = new System.Drawing.Point(234, 126);
            this.labelRes.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(60, 24);
            this.labelRes.TabIndex = 2;
            this.labelRes.Text = "label3";
            this.labelRes.Visible = false;
            this.labelRes.Click += new System.EventHandler(this.label3_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelResult.Location = new System.Drawing.Point(103, 126);
            this.labelResult.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(119, 24);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат =";
            this.labelResult.Visible = false;
            this.labelResult.Click += new System.EventHandler(this.labelResult_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonResult.ForeColor = System.Drawing.Color.Lime;
            this.buttonResult.Location = new System.Drawing.Point(122, 64);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(138, 42);
            this.buttonResult.TabIndex = 4;
            this.buttonResult.Text = "Порахувати";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(63, 7);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(85, 29);
            this.textBoxB.TabIndex = 5;
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(225, 6);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(85, 29);
            this.textBoxA.TabIndex = 6;
            // 
            // For01
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 224);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "For01";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For01";
            this.Load += new System.EventHandler(this.For01_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Label labelA;
        public System.Windows.Forms.Label labelRes;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.Label labelB;
        public System.Windows.Forms.Button buttonResult;
        public System.Windows.Forms.TextBox textBoxB;
        public System.Windows.Forms.TextBox textBoxA;
    }
}