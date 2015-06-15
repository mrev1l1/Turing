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
            this.RibbonsContentTextBox = new System.Windows.Forms.TextBox();
            this.DoAlgorithmButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 316);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(147, 316);
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
            // RibbonsContentTextBox
            // 
            this.RibbonsContentTextBox.Location = new System.Drawing.Point(12, 113);
            this.RibbonsContentTextBox.Multiline = true;
            this.RibbonsContentTextBox.Name = "RibbonsContentTextBox";
            this.RibbonsContentTextBox.Size = new System.Drawing.Size(283, 95);
            this.RibbonsContentTextBox.TabIndex = 3;
            // 
            // DoAlgorithmButton
            // 
            this.DoAlgorithmButton.Location = new System.Drawing.Point(320, 185);
            this.DoAlgorithmButton.Name = "DoAlgorithmButton";
            this.DoAlgorithmButton.Size = new System.Drawing.Size(75, 23);
            this.DoAlgorithmButton.TabIndex = 5;
            this.DoAlgorithmButton.Text = "Launch";
            this.DoAlgorithmButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 368);
            this.Controls.Add(this.DoAlgorithmButton);
            this.Controls.Add(this.RibbonsContentTextBox);
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
        private System.Windows.Forms.TextBox RibbonsContentTextBox;
        private System.Windows.Forms.Button DoAlgorithmButton;
    }
}

