
namespace Mainmen
{
    partial class John_Wallis
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
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelIT = new System.Windows.Forms.Label();
            this.textBoxIT = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(148, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "LD";
            this.label3.Visible = false;
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 132);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Результат =";
            this.label2.Visible = false;
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelIT
            // 
            this.labelIT.AutoSize = true;
            this.labelIT.Location = new System.Drawing.Point(34, 29);
            this.labelIT.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelIT.Name = "labelIT";
            this.labelIT.Size = new System.Drawing.Size(168, 24);
            this.labelIT.TabIndex = 7;
            this.labelIT.Text = "Кількість ітерацій";
            this.labelIT.Click += new System.EventHandler(this.labelIT_Click);
            // 
            // textBoxIT
            // 
            this.textBoxIT.Location = new System.Drawing.Point(204, 26);
            this.textBoxIT.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.textBoxIT.Name = "textBoxIT";
            this.textBoxIT.Size = new System.Drawing.Size(74, 29);
            this.textBoxIT.TabIndex = 6;
            this.textBoxIT.TextChanged += new System.EventHandler(this.textBoxIT_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(116, 67);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 42);
            this.button1.TabIndex = 5;
            this.button1.Text = "Порахувати";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // John_Wallis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(344, 201);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelIT);
            this.Controls.Add(this.textBoxIT);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "John_Wallis";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "John_Wallis";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelIT;
        private System.Windows.Forms.TextBox textBoxIT;
        private System.Windows.Forms.Button button1;
    }
}