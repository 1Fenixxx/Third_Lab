namespace WindowsFormsApp1
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
            this.IsUsingLimits = new System.Windows.Forms.CheckBox();
            this.B_CalculateY = new System.Windows.Forms.Button();
            this.TB_X1_MAX = new System.Windows.Forms.TextBox();
            this.TB_X2_MAX = new System.Windows.Forms.TextBox();
            this.TB_X2 = new System.Windows.Forms.TextBox();
            this.TB_X1 = new System.Windows.Forms.TextBox();
            this.TB_INTERVAL_X1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LB_Results = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TB_INTERVAL_X2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // IsUsingLimits
            // 
            this.IsUsingLimits.AutoSize = true;
            this.IsUsingLimits.Location = new System.Drawing.Point(642, 131);
            this.IsUsingLimits.Name = "IsUsingLimits";
            this.IsUsingLimits.Size = new System.Drawing.Size(146, 17);
            this.IsUsingLimits.TabIndex = 0;
            this.IsUsingLimits.Text = "Использовать пределы";
            this.IsUsingLimits.UseVisualStyleBackColor = true;
            this.IsUsingLimits.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // B_CalculateY
            // 
            this.B_CalculateY.Location = new System.Drawing.Point(609, 258);
            this.B_CalculateY.Name = "B_CalculateY";
            this.B_CalculateY.Size = new System.Drawing.Size(179, 48);
            this.B_CalculateY.TabIndex = 1;
            this.B_CalculateY.Text = "Calculate Y";
            this.B_CalculateY.UseVisualStyleBackColor = true;
            this.B_CalculateY.Click += new System.EventHandler(this.B_CalculateY_Click);
            // 
            // TB_X1_MAX
            // 
            this.TB_X1_MAX.Location = new System.Drawing.Point(688, 154);
            this.TB_X1_MAX.Name = "TB_X1_MAX";
            this.TB_X1_MAX.Size = new System.Drawing.Size(100, 20);
            this.TB_X1_MAX.TabIndex = 2;
            // 
            // TB_X2_MAX
            // 
            this.TB_X2_MAX.Location = new System.Drawing.Point(688, 180);
            this.TB_X2_MAX.Name = "TB_X2_MAX";
            this.TB_X2_MAX.Size = new System.Drawing.Size(100, 20);
            this.TB_X2_MAX.TabIndex = 3;
            // 
            // TB_X2
            // 
            this.TB_X2.Location = new System.Drawing.Point(688, 105);
            this.TB_X2.Name = "TB_X2";
            this.TB_X2.Size = new System.Drawing.Size(100, 20);
            this.TB_X2.TabIndex = 4;
            // 
            // TB_X1
            // 
            this.TB_X1.Location = new System.Drawing.Point(688, 79);
            this.TB_X1.Name = "TB_X1";
            this.TB_X1.Size = new System.Drawing.Size(100, 20);
            this.TB_X1.TabIndex = 5;
            // 
            // TB_INTERVAL_X1
            // 
            this.TB_INTERVAL_X1.Location = new System.Drawing.Point(688, 206);
            this.TB_INTERVAL_X1.Name = "TB_INTERVAL_X1";
            this.TB_INTERVAL_X1.Size = new System.Drawing.Size(100, 20);
            this.TB_INTERVAL_X1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(633, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "X1_MAX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(633, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "X2_MAX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "INTERVAL X1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(647, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "X2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(647, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "X1";
            // 
            // LB_Results
            // 
            this.LB_Results.FormattingEnabled = true;
            this.LB_Results.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.LB_Results.Location = new System.Drawing.Point(12, 12);
            this.LB_Results.Name = "LB_Results";
            this.LB_Results.Size = new System.Drawing.Size(588, 420);
            this.LB_Results.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(606, 235);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "INTERVAL X2";
            // 
            // TB_INTERVAL_X2
            // 
            this.TB_INTERVAL_X2.Location = new System.Drawing.Point(688, 232);
            this.TB_INTERVAL_X2.Name = "TB_INTERVAL_X2";
            this.TB_INTERVAL_X2.Size = new System.Drawing.Size(100, 20);
            this.TB_INTERVAL_X2.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TB_INTERVAL_X2);
            this.Controls.Add(this.LB_Results);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TB_INTERVAL_X1);
            this.Controls.Add(this.TB_X1);
            this.Controls.Add(this.TB_X2);
            this.Controls.Add(this.TB_X2_MAX);
            this.Controls.Add(this.TB_X1_MAX);
            this.Controls.Add(this.B_CalculateY);
            this.Controls.Add(this.IsUsingLimits);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox IsUsingLimits;
        private System.Windows.Forms.Button B_CalculateY;
        private System.Windows.Forms.TextBox TB_X1_MAX;
        private System.Windows.Forms.TextBox TB_X2_MAX;
        private System.Windows.Forms.TextBox TB_X2;
        private System.Windows.Forms.TextBox TB_X1;
        private System.Windows.Forms.TextBox TB_INTERVAL_X1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox LB_Results;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TB_INTERVAL_X2;
    }
}

