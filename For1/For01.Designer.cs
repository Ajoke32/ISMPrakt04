
namespace For1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.labelA = new System.Windows.Forms.Label();
            this.labelB = new System.Windows.Forms.Label();
            this.labelResult = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(230, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // labelA
            // 
            this.labelA.AutoSize = true;
            this.labelA.Location = new System.Drawing.Point(145, 75);
            this.labelA.Name = "labelA";
            this.labelA.Size = new System.Drawing.Size(22, 13);
            this.labelA.TabIndex = 1;
            this.labelA.Text = "a =";
            // 
            // labelB
            // 
            this.labelB.AutoSize = true;
            this.labelB.Location = new System.Drawing.Point(68, 52);
            this.labelB.Name = "labelB";
            this.labelB.Size = new System.Drawing.Size(22, 13);
            this.labelB.TabIndex = 2;
            this.labelB.Text = "b =";
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Location = new System.Drawing.Point(53, 111);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(68, 13);
            this.labelResult.TabIndex = 3;
            this.labelResult.Text = "Результат =";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(127, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 196);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.labelB);
            this.Controls.Add(this.labelA);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "For1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label labelA;
        public System.Windows.Forms.Label labelB;
        public System.Windows.Forms.Label labelResult;
        public System.Windows.Forms.Label label4;
    }
}

