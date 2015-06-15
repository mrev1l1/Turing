namespace Turinh_GUI
{
    partial class Form1
    {
        /// <summary>
        /// Требуется переменная конструктора.
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
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.RibbonQuantitySelector = new System.Windows.Forms.ComboBox();
            this.RulesTextBox = new System.Windows.Forms.TextBox();
            this.DoAlgorithmButton = new System.Windows.Forms.Button();
            this.RibbonsContentTextBox = new System.Windows.Forms.TextBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.StepCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 186);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(220, 186);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Load";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RibbonQuantitySelector
            // 
            this.RibbonQuantitySelector.FormattingEnabled = true;
            this.RibbonQuantitySelector.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.RibbonQuantitySelector.Location = new System.Drawing.Point(12, 28);
            this.RibbonQuantitySelector.Name = "RibbonQuantitySelector";
            this.RibbonQuantitySelector.Size = new System.Drawing.Size(283, 21);
            this.RibbonQuantitySelector.TabIndex = 2;
            this.RibbonQuantitySelector.Text = "Выберите количество лент";
            // 
            // RulesTextBox
            // 
            this.RulesTextBox.Location = new System.Drawing.Point(12, 85);
            this.RulesTextBox.Multiline = true;
            this.RulesTextBox.Name = "RulesTextBox";
            this.RulesTextBox.Size = new System.Drawing.Size(283, 95);
            this.RulesTextBox.TabIndex = 3;
            // 
            // DoAlgorithmButton
            // 
            this.DoAlgorithmButton.Location = new System.Drawing.Point(220, 336);
            this.DoAlgorithmButton.Name = "DoAlgorithmButton";
            this.DoAlgorithmButton.Size = new System.Drawing.Size(75, 23);
            this.DoAlgorithmButton.TabIndex = 5;
            this.DoAlgorithmButton.Text = "Launch";
            this.DoAlgorithmButton.UseVisualStyleBackColor = true;
            this.DoAlgorithmButton.Click += new System.EventHandler(this.DoAlgorithmButton_Click);
            // 
            // RibbonsContentTextBox
            // 
            this.RibbonsContentTextBox.Location = new System.Drawing.Point(12, 215);
            this.RibbonsContentTextBox.Multiline = true;
            this.RibbonsContentTextBox.Name = "RibbonsContentTextBox";
            this.RibbonsContentTextBox.Size = new System.Drawing.Size(283, 115);
            this.RibbonsContentTextBox.TabIndex = 6;
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(331, 85);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(283, 245);
            this.LogTextBox.TabIndex = 7;
            // 
            // StepCountLabel
            // 
            this.StepCountLabel.AutoSize = true;
            this.StepCountLabel.Location = new System.Drawing.Point(328, 36);
            this.StepCountLabel.Name = "StepCountLabel";
            this.StepCountLabel.Size = new System.Drawing.Size(100, 13);
            this.StepCountLabel.TabIndex = 8;
            this.StepCountLabel.Text = "Количество шагов";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 382);
            this.Controls.Add(this.StepCountLabel);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.RibbonsContentTextBox);
            this.Controls.Add(this.DoAlgorithmButton);
            this.Controls.Add(this.RulesTextBox);
            this.Controls.Add(this.RibbonQuantitySelector);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox RibbonQuantitySelector;
        private System.Windows.Forms.TextBox RulesTextBox;
        private System.Windows.Forms.Button DoAlgorithmButton;
        private System.Windows.Forms.TextBox RibbonsContentTextBox;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Label StepCountLabel;
    }
}

