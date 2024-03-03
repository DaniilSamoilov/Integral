namespace Integral
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.RightBorder = new System.Windows.Forms.TextBox();
            this.LeftBorder = new System.Windows.Forms.TextBox();
            this.NumberOfSplits = new System.Windows.Forms.TextBox();
            this.Calculate = new System.Windows.Forms.Button();
            this.IntegralResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.RequiredTime = new System.Windows.Forms.TextBox();
            this.MethodsList = new System.Windows.Forms.ComboBox();
            this.FunctionList = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Левая граница";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Правая граница";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Используемый метод";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Функция";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(0, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Количество разбиений";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 134);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Результат";
            // 
            // RightBorder
            // 
            this.RightBorder.Location = new System.Drawing.Point(125, 26);
            this.RightBorder.Name = "RightBorder";
            this.RightBorder.Size = new System.Drawing.Size(147, 20);
            this.RightBorder.TabIndex = 2;
            // 
            // LeftBorder
            // 
            this.LeftBorder.Location = new System.Drawing.Point(125, 0);
            this.LeftBorder.Name = "LeftBorder";
            this.LeftBorder.Size = new System.Drawing.Size(147, 20);
            this.LeftBorder.TabIndex = 1;
            // 
            // NumberOfSplits
            // 
            this.NumberOfSplits.Location = new System.Drawing.Point(125, 102);
            this.NumberOfSplits.Name = "NumberOfSplits";
            this.NumberOfSplits.Size = new System.Drawing.Size(147, 20);
            this.NumberOfSplits.TabIndex = 5;
            // 
            // Calculate
            // 
            this.Calculate.Location = new System.Drawing.Point(8, 245);
            this.Calculate.Name = "Calculate";
            this.Calculate.Size = new System.Drawing.Size(75, 23);
            this.Calculate.TabIndex = 8;
            this.Calculate.Text = "Высчитать";
            this.Calculate.UseVisualStyleBackColor = true;
            this.Calculate.Click += new System.EventHandler(this.Calculate_Click);
            // 
            // IntegralResult
            // 
            this.IntegralResult.Location = new System.Drawing.Point(125, 131);
            this.IntegralResult.Name = "IntegralResult";
            this.IntegralResult.ReadOnly = true;
            this.IntegralResult.Size = new System.Drawing.Size(147, 20);
            this.IntegralResult.TabIndex = 6;
            this.IntegralResult.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(0, 168);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Время выполнения";
            // 
            // RequiredTime
            // 
            this.RequiredTime.Location = new System.Drawing.Point(125, 165);
            this.RequiredTime.Name = "RequiredTime";
            this.RequiredTime.ReadOnly = true;
            this.RequiredTime.Size = new System.Drawing.Size(147, 20);
            this.RequiredTime.TabIndex = 7;
            this.RequiredTime.TabStop = false;
            // 
            // MethodsList
            // 
            this.MethodsList.FormattingEnabled = true;
            this.MethodsList.Location = new System.Drawing.Point(125, 50);
            this.MethodsList.Name = "MethodsList";
            this.MethodsList.Size = new System.Drawing.Size(147, 21);
            this.MethodsList.TabIndex = 3;
            // 
            // FunctionList
            // 
            this.FunctionList.FormattingEnabled = true;
            this.FunctionList.Location = new System.Drawing.Point(125, 77);
            this.FunctionList.Name = "FunctionList";
            this.FunctionList.Size = new System.Drawing.Size(147, 21);
            this.FunctionList.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 196);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 280);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.FunctionList);
            this.Controls.Add(this.MethodsList);
            this.Controls.Add(this.RequiredTime);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.IntegralResult);
            this.Controls.Add(this.Calculate);
            this.Controls.Add(this.NumberOfSplits);
            this.Controls.Add(this.LeftBorder);
            this.Controls.Add(this.RightBorder);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox RightBorder;
        private System.Windows.Forms.TextBox LeftBorder;
        private System.Windows.Forms.TextBox NumberOfSplits;
        private System.Windows.Forms.Button Calculate;
        private System.Windows.Forms.TextBox IntegralResult;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox RequiredTime;
        private System.Windows.Forms.ComboBox MethodsList;
        private System.Windows.Forms.ComboBox FunctionList;
        private System.Windows.Forms.Label label8;
    }
}

