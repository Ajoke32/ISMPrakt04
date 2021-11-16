
namespace Mainmen
{
    partial class DoWhile
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonRes = new System.Windows.Forms.Button();
            this.labelRes1 = new System.Windows.Forms.Label();
            this.labelRes2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Числа =";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(15, 9);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(387, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Введіть послідовність чисел(НЕ ЧЕРЕЗ ПРОБІЛ)\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(173, 54);
            this.textBoxN.Margin = new System.Windows.Forms.Padding(6);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(200, 29);
            this.textBoxN.TabIndex = 2;
            // 
            // buttonRes
            // 
            this.buttonRes.Location = new System.Drawing.Point(201, 95);
            this.buttonRes.Margin = new System.Windows.Forms.Padding(6);
            this.buttonRes.Name = "buttonRes";
            this.buttonRes.Size = new System.Drawing.Size(138, 36);
            this.buttonRes.TabIndex = 3;
            this.buttonRes.Text = "Порахувати";
            this.buttonRes.UseVisualStyleBackColor = true;
            this.buttonRes.Click += new System.EventHandler(this.buttonRes_Click);
            // 
            // labelRes1
            // 
            this.labelRes1.AutoSize = true;
            this.labelRes1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes1.Location = new System.Drawing.Point(158, 150);
            this.labelRes1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRes1.Name = "labelRes1";
            this.labelRes1.Size = new System.Drawing.Size(154, 29);
            this.labelRes1.TabIndex = 4;
            this.labelRes1.Text = "Результат = ";
            this.labelRes1.Visible = false;
            // 
            // labelRes2
            // 
            this.labelRes2.AutoSize = true;
            this.labelRes2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelRes2.Location = new System.Drawing.Point(303, 150);
            this.labelRes2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelRes2.Name = "labelRes2";
            this.labelRes2.Size = new System.Drawing.Size(84, 29);
            this.labelRes2.TabIndex = 5;
            this.labelRes2.Text = "labelN";
            this.labelRes2.Visible = false;
            this.labelRes2.Click += new System.EventHandler(this.label4_Click);
            // 
            // DoWhile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 201);
            this.Controls.Add(this.labelRes2);
            this.Controls.Add(this.labelRes1);
            this.Controls.Add(this.buttonRes);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DoWhile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DoWhile";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBoxN;
        public System.Windows.Forms.Button buttonRes;
        public System.Windows.Forms.Label labelRes1;
        public System.Windows.Forms.Label labelRes2;
    }
}