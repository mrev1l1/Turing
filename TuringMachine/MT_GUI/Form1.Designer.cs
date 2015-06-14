namespace MT_GUI
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
            this.RibbonQuantitySelector = new System.Windows.Forms.ComboBox();
            this.RibbonsContentTextBox = new System.Windows.Forms.TextBox();
            this.FileWithRules = new System.Windows.Forms.OpenFileDialog();
            this.OpenFileButton = new System.Windows.Forms.Button();
            this.DoAlgorithmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.RibbonQuantitySelector.Location = new System.Drawing.Point(12, 12);
            this.RibbonQuantitySelector.Name = "RibbonQuantitySelector";
            this.RibbonQuantitySelector.Size = new System.Drawing.Size(283, 21);
            this.RibbonQuantitySelector.TabIndex = 1;
            this.RibbonQuantitySelector.Text = "Выберите количество лент";
            // 
            // RibbonsContentTextBox
            // 
            this.RibbonsContentTextBox.Location = new System.Drawing.Point(12, 74);
            this.RibbonsContentTextBox.Multiline = true;
            this.RibbonsContentTextBox.Name = "RibbonsContentTextBox";
            this.RibbonsContentTextBox.Size = new System.Drawing.Size(283, 95);
            this.RibbonsContentTextBox.TabIndex = 2;
            // 
            // FileWithRules
            // 
            this.FileWithRules.FileName = "turing";
            // 
            // OpenFileButton
            // 
            this.OpenFileButton.Location = new System.Drawing.Point(122, 190);
            this.OpenFileButton.Name = "OpenFileButton";
            this.OpenFileButton.Size = new System.Drawing.Size(172, 23);
            this.OpenFileButton.TabIndex = 3;
            this.OpenFileButton.Text = "Выберите файл с алгоритмом";
            this.OpenFileButton.UseVisualStyleBackColor = true;
            this.OpenFileButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // DoAlgorithmButton
            // 
            this.DoAlgorithmButton.Location = new System.Drawing.Point(218, 220);
            this.DoAlgorithmButton.Name = "DoAlgorithmButton";
            this.DoAlgorithmButton.Size = new System.Drawing.Size(75, 23);
            this.DoAlgorithmButton.TabIndex = 4;
            this.DoAlgorithmButton.Text = "Запустить";
            this.DoAlgorithmButton.UseVisualStyleBackColor = true;
            this.DoAlgorithmButton.Click += new System.EventHandler(this.DoAlgorithmButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 317);
            this.Controls.Add(this.DoAlgorithmButton);
            this.Controls.Add(this.OpenFileButton);
            this.Controls.Add(this.RibbonsContentTextBox);
            this.Controls.Add(this.RibbonQuantitySelector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox RibbonQuantitySelector;
        private System.Windows.Forms.TextBox RibbonsContentTextBox;
        private System.Windows.Forms.OpenFileDialog FileWithRules;
        private System.Windows.Forms.Button OpenFileButton;
        private System.Windows.Forms.Button DoAlgorithmButton;
    }
}

