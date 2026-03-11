namespace lab2
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
            this.fileImportButton = new System.Windows.Forms.Button();
            this.fileExportButton = new System.Windows.Forms.Button();
            this.encodeButton = new System.Windows.Forms.Button();
            this.decodeButton = new System.Windows.Forms.Button();
            this.plainText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.keyText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cipherText = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // fileImportButton
            // 
            this.fileImportButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileImportButton.FlatAppearance.BorderSize = 2;
            this.fileImportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileImportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileImportButton.ForeColor = System.Drawing.Color.Crimson;
            this.fileImportButton.Location = new System.Drawing.Point(650, 394);
            this.fileImportButton.Name = "fileImportButton";
            this.fileImportButton.Size = new System.Drawing.Size(209, 51);
            this.fileImportButton.TabIndex = 1;
            this.fileImportButton.Text = "Выбор файла";
            this.fileImportButton.UseVisualStyleBackColor = false;
            this.fileImportButton.Click += new System.EventHandler(this.fileImportButton_Click);
            // 
            // fileExportButton
            // 
            this.fileExportButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.fileExportButton.FlatAppearance.BorderSize = 2;
            this.fileExportButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fileExportButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileExportButton.ForeColor = System.Drawing.Color.Crimson;
            this.fileExportButton.Location = new System.Drawing.Point(650, 458);
            this.fileExportButton.Name = "fileExportButton";
            this.fileExportButton.Size = new System.Drawing.Size(209, 51);
            this.fileExportButton.TabIndex = 2;
            this.fileExportButton.Text = "Сохранение файла";
            this.fileExportButton.UseVisualStyleBackColor = false;
            this.fileExportButton.Click += new System.EventHandler(this.fileExportButton_Click);
            // 
            // encodeButton
            // 
            this.encodeButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.encodeButton.FlatAppearance.BorderSize = 2;
            this.encodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.encodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.encodeButton.ForeColor = System.Drawing.Color.Crimson;
            this.encodeButton.Location = new System.Drawing.Point(650, 45);
            this.encodeButton.Name = "encodeButton";
            this.encodeButton.Size = new System.Drawing.Size(209, 51);
            this.encodeButton.TabIndex = 3;
            this.encodeButton.Text = "Зашифровать";
            this.encodeButton.UseVisualStyleBackColor = false;
            this.encodeButton.Click += new System.EventHandler(this.encodeButton_Click);
            // 
            // decodeButton
            // 
            this.decodeButton.BackColor = System.Drawing.Color.LavenderBlush;
            this.decodeButton.FlatAppearance.BorderSize = 2;
            this.decodeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.decodeButton.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.decodeButton.ForeColor = System.Drawing.Color.Crimson;
            this.decodeButton.Location = new System.Drawing.Point(650, 110);
            this.decodeButton.Name = "decodeButton";
            this.decodeButton.Size = new System.Drawing.Size(209, 51);
            this.decodeButton.TabIndex = 4;
            this.decodeButton.Text = "Очистить поле";
            this.decodeButton.UseVisualStyleBackColor = false;
            this.decodeButton.Click += new System.EventHandler(this.decodeButton_Click);
            // 
            // plainText
            // 
            this.plainText.BackColor = System.Drawing.Color.LavenderBlush;
            this.plainText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.plainText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.plainText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plainText.ForeColor = System.Drawing.Color.Crimson;
            this.plainText.Location = new System.Drawing.Point(12, 45);
            this.plainText.Multiline = true;
            this.plainText.Name = "plainText";
            this.plainText.ReadOnly = true;
            this.plainText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.plainText.Size = new System.Drawing.Size(632, 116);
            this.plainText.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(263, 30);
            this.label1.TabIndex = 6;
            this.label1.Text = "Исходный массив битов:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Crimson;
            this.label2.Location = new System.Drawing.Point(12, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 30);
            this.label2.TabIndex = 8;
            this.label2.Text = "Ключ:";
            // 
            // keyText
            // 
            this.keyText.BackColor = System.Drawing.Color.LavenderBlush;
            this.keyText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.keyText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.keyText.ForeColor = System.Drawing.Color.Crimson;
            this.keyText.Location = new System.Drawing.Point(12, 214);
            this.keyText.Multiline = true;
            this.keyText.Name = "keyText";
            this.keyText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.keyText.Size = new System.Drawing.Size(632, 116);
            this.keyText.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Crimson;
            this.label3.Location = new System.Drawing.Point(12, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(330, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = "Зашифрованный массив битов:";
            // 
            // cipherText
            // 
            this.cipherText.BackColor = System.Drawing.Color.LavenderBlush;
            this.cipherText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.cipherText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cipherText.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.cipherText.ForeColor = System.Drawing.Color.Crimson;
            this.cipherText.Location = new System.Drawing.Point(12, 394);
            this.cipherText.Multiline = true;
            this.cipherText.Name = "cipherText";
            this.cipherText.ReadOnly = true;
            this.cipherText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.cipherText.Size = new System.Drawing.Size(632, 116);
            this.cipherText.TabIndex = 9;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(871, 521);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cipherText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.keyText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.plainText);
            this.Controls.Add(this.encodeButton);
            this.Controls.Add(this.decodeButton);
            this.Controls.Add(this.fileExportButton);
            this.Controls.Add(this.fileImportButton);
            this.Name = "Form1";
            this.Text = "Lab2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button fileImportButton;
        private System.Windows.Forms.Button fileExportButton;
        private System.Windows.Forms.Button encodeButton;
        private System.Windows.Forms.Button decodeButton;
        private System.Windows.Forms.TextBox plainText;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox keyText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox cipherText;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

