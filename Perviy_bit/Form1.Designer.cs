namespace Perviy_bit
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
            this.labelMas = new System.Windows.Forms.Label();
            this.textBoxMas = new System.Windows.Forms.TextBox();
            this.textBoxSort = new System.Windows.Forms.TextBox();
            this.labelSort = new System.Windows.Forms.Label();
            this.textBoxFIO = new System.Windows.Forms.TextBox();
            this.labelFIO = new System.Windows.Forms.Label();
            this.textBoxSR = new System.Windows.Forms.TextBox();
            this.labelSR = new System.Windows.Forms.Label();
            this.textBoxBol = new System.Windows.Forms.TextBox();
            this.labelBol = new System.Windows.Forms.Label();
            this.buttonWord = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // labelMas
            // 
            this.labelMas.AutoSize = true;
            this.labelMas.Location = new System.Drawing.Point(30, 63);
            this.labelMas.Name = "labelMas";
            this.labelMas.Size = new System.Drawing.Size(56, 17);
            this.labelMas.TabIndex = 0;
            this.labelMas.Text = "Массив";
            // 
            // textBoxMas
            // 
            this.textBoxMas.Location = new System.Drawing.Point(236, 60);
            this.textBoxMas.Name = "textBoxMas";
            this.textBoxMas.Size = new System.Drawing.Size(510, 22);
            this.textBoxMas.TabIndex = 1;
            // 
            // textBoxSort
            // 
            this.textBoxSort.Location = new System.Drawing.Point(236, 122);
            this.textBoxSort.Name = "textBoxSort";
            this.textBoxSort.Size = new System.Drawing.Size(510, 22);
            this.textBoxSort.TabIndex = 3;
            // 
            // labelSort
            // 
            this.labelSort.AutoSize = true;
            this.labelSort.Location = new System.Drawing.Point(30, 125);
            this.labelSort.Name = "labelSort";
            this.labelSort.Size = new System.Drawing.Size(176, 17);
            this.labelSort.TabIndex = 2;
            this.labelSort.Text = "Сортировка по убыванию";
            // 
            // textBoxFIO
            // 
            this.textBoxFIO.Location = new System.Drawing.Point(236, 301);
            this.textBoxFIO.Name = "textBoxFIO";
            this.textBoxFIO.Size = new System.Drawing.Size(510, 22);
            this.textBoxFIO.TabIndex = 7;
            // 
            // labelFIO
            // 
            this.labelFIO.AutoSize = true;
            this.labelFIO.Location = new System.Drawing.Point(30, 304);
            this.labelFIO.Name = "labelFIO";
            this.labelFIO.Size = new System.Drawing.Size(42, 17);
            this.labelFIO.TabIndex = 6;
            this.labelFIO.Text = "ФИО";
            // 
            // textBoxSR
            // 
            this.textBoxSR.Location = new System.Drawing.Point(236, 184);
            this.textBoxSR.Name = "textBoxSR";
            this.textBoxSR.Size = new System.Drawing.Size(510, 22);
            this.textBoxSR.TabIndex = 5;
            // 
            // labelSR
            // 
            this.labelSR.AutoSize = true;
            this.labelSR.Location = new System.Drawing.Point(30, 187);
            this.labelSR.Name = "labelSR";
            this.labelSR.Size = new System.Drawing.Size(108, 17);
            this.labelSR.TabIndex = 4;
            this.labelSR.Text = "Среднее число";
            // 
            // textBoxBol
            // 
            this.textBoxBol.Location = new System.Drawing.Point(236, 238);
            this.textBoxBol.Name = "textBoxBol";
            this.textBoxBol.Size = new System.Drawing.Size(510, 22);
            this.textBoxBol.TabIndex = 9;
            // 
            // labelBol
            // 
            this.labelBol.AutoSize = true;
            this.labelBol.Location = new System.Drawing.Point(30, 241);
            this.labelBol.Name = "labelBol";
            this.labelBol.Size = new System.Drawing.Size(110, 17);
            this.labelBol.TabIndex = 8;
            this.labelBol.Text = "Большее число";
            // 
            // buttonWord
            // 
            this.buttonWord.Location = new System.Drawing.Point(33, 353);
            this.buttonWord.Name = "buttonWord";
            this.buttonWord.Size = new System.Drawing.Size(105, 23);
            this.buttonWord.TabIndex = 11;
            this.buttonWord.Text = "Разделить";
            this.buttonWord.UseVisualStyleBackColor = true;
            this.buttonWord.Click += new System.EventHandler(this.buttonWord_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(236, 353);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(510, 96);
            this.richTextBox1.TabIndex = 12;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 483);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonWord);
            this.Controls.Add(this.textBoxBol);
            this.Controls.Add(this.labelBol);
            this.Controls.Add(this.textBoxFIO);
            this.Controls.Add(this.labelFIO);
            this.Controls.Add(this.textBoxSR);
            this.Controls.Add(this.labelSR);
            this.Controls.Add(this.textBoxSort);
            this.Controls.Add(this.labelSort);
            this.Controls.Add(this.textBoxMas);
            this.Controls.Add(this.labelMas);
            this.Name = "Form1";
            this.Text = "Работа с массивами";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMas;
        private System.Windows.Forms.TextBox textBoxMas;
        private System.Windows.Forms.TextBox textBoxSort;
        private System.Windows.Forms.Label labelSort;
        private System.Windows.Forms.TextBox textBoxFIO;
        private System.Windows.Forms.Label labelFIO;
        private System.Windows.Forms.TextBox textBoxSR;
        private System.Windows.Forms.Label labelSR;
        private System.Windows.Forms.TextBox textBoxBol;
        private System.Windows.Forms.Label labelBol;
        private System.Windows.Forms.Button buttonWord;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

