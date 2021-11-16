
namespace Mainmen
{
    partial class For04
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
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.buttonResult = new System.Windows.Forms.Button();
            this.labelResult = new System.Windows.Forms.Label();
            this.labelRes = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelA = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(223, 17);
            this.textBoxA.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(86, 29);
            this.textBoxA.TabIndex = 13;
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(60, 17);
            this.textBoxB.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(81, 29);
            this.textBoxB.TabIndex = 12;
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(95, 71);
            this.buttonResult.Margin = new System.Windows.Forms.Padding(11, 11, 11, 11);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(141, 42);
            this.buttonResult.TabIndex = 11;
            this.buttonResult.Text = "Порахувати";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Microsoft JhengHei Light", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelResult.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelResult.Location = new System.Drawing.Point(88, 139);
            this.labelResult.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(134, 25);
            this.labelResult.TabIndex = 10;
            this.labelResult.Text = "Результат =";
            this.labelResult.Visible = false;
            // 
            // labelRes
            // 
            this.labelRes.AutoSize = true;
            this.labelRes.Font = new System.Drawing.Font("Microsoft JhengHei Light", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.labelRes.Location = new System.Drawing.Point(219, 140);
            this.labelRes.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelRes.Name = "labelRes";
            this.labelRes.Size = new System.Drawing.Size(67, 24);
            this.labelRes.TabIndex = 9;
            this.labelRes.Text = "label3";
            this.labelRes.Visible = false;
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(185, 20);
            this.labelB.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(37, 24);
            this.labelB.TabIndex = 8;
            this.labelB.Text = "b =";
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(20, 20);
            this.labelA.Margin = new System.Windows.Forms.Padding(11, 0, 11, 0);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(36, 24);
            this.labelA.TabIndex = 7;
            this.labelA.Text = "a =";
            this.labelA.Click += new System.EventHandler(this.labelA_Click);
            // 
            // For04
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.textBoxA);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelRes);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "For04";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "For04";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox textBoxA;
        public System.Windows.Forms.TextBox textBoxB;
        public System.Windows.Forms.Button buttonResult;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.Label labelRes;
        public System.Windows.Forms.Label labelB;
        public System.Windows.Forms.Label labelA;
    }
}