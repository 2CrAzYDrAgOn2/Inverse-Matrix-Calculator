namespace WinFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridViewA = new DataGridView();
            comboBox = new ComboBox();
            calculateButton = new Button();
            clearButton = new Button();
            exitButton = new Button();
            wordButton = new Button();
            excelButton = new Button();
            dataGridViewB = new DataGridView();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridViewA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewB).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewA
            // 
            dataGridViewA.AllowUserToAddRows = false;
            dataGridViewA.AllowUserToDeleteRows = false;
            dataGridViewA.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewA.Location = new Point(13, 12);
            dataGridViewA.Margin = new Padding(4, 3, 4, 3);
            dataGridViewA.Name = "dataGridViewA";
            dataGridViewA.RowTemplate.Height = 25;
            dataGridViewA.Size = new Size(750, 250);
            dataGridViewA.TabIndex = 0;
            // 
            // comboBox
            // 
            comboBox.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FormattingEnabled = true;
            comboBox.Items.AddRange(new object[] { "2x2", "3x3", "4x4", "5x5", "6x6", "7x7" });
            comboBox.Location = new Point(1011, 292);
            comboBox.Margin = new Padding(4, 3, 4, 3);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(140, 23);
            comboBox.TabIndex = 1;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // calculateButton
            // 
            calculateButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            calculateButton.Location = new Point(1011, 12);
            calculateButton.Margin = new Padding(4, 3, 4, 3);
            calculateButton.Name = "calculateButton";
            calculateButton.Size = new Size(140, 50);
            calculateButton.TabIndex = 2;
            calculateButton.Text = "Рассчитать";
            calculateButton.UseVisualStyleBackColor = true;
            calculateButton.Click += calculateButton_Click;
            // 
            // clearButton
            // 
            clearButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            clearButton.Location = new Point(1011, 68);
            clearButton.Margin = new Padding(4, 3, 4, 3);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(140, 50);
            clearButton.TabIndex = 3;
            clearButton.Text = "Очистить";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // exitButton
            // 
            exitButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            exitButton.Location = new Point(1011, 236);
            exitButton.Margin = new Padding(4, 3, 4, 3);
            exitButton.Name = "exitButton";
            exitButton.Size = new Size(140, 50);
            exitButton.TabIndex = 4;
            exitButton.Text = "Выйти";
            exitButton.UseVisualStyleBackColor = true;
            exitButton.Click += exitButton_Click;
            // 
            // wordButton
            // 
            wordButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            wordButton.Location = new Point(1011, 124);
            wordButton.Margin = new Padding(4, 3, 4, 3);
            wordButton.Name = "wordButton";
            wordButton.Size = new Size(140, 50);
            wordButton.TabIndex = 5;
            wordButton.Text = "Показать в Word";
            wordButton.UseVisualStyleBackColor = true;
            wordButton.Click += wordButton_Click;
            // 
            // excelButton
            // 
            excelButton.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            excelButton.Location = new Point(1011, 180);
            excelButton.Margin = new Padding(4, 3, 4, 3);
            excelButton.Name = "excelButton";
            excelButton.Size = new Size(140, 50);
            excelButton.TabIndex = 6;
            excelButton.Text = "Показать в Excel";
            excelButton.UseVisualStyleBackColor = true;
            excelButton.Click += excelButton_Click;
            // 
            // dataGridViewB
            // 
            dataGridViewB.AllowUserToAddRows = false;
            dataGridViewB.AllowUserToDeleteRows = false;
            dataGridViewB.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            dataGridViewB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewB.Enabled = false;
            dataGridViewB.Location = new Point(13, 293);
            dataGridViewB.Margin = new Padding(4, 3, 4, 3);
            dataGridViewB.Name = "dataGridViewB";
            dataGridViewB.RowTemplate.Height = 25;
            dataGridViewB.Size = new Size(750, 250);
            dataGridViewB.TabIndex = 7;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(770, 12);
            label1.Name = "label1";
            label1.Size = new Size(231, 25);
            label1.TabIndex = 8;
            label1.Text = "Инструкция к программе: ";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(342, 265);
            label2.Name = "label2";
            label2.Size = new Size(85, 25);
            label2.TabIndex = 9;
            label2.Text = "Матрица";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(306, 546);
            label3.Name = "label3";
            label3.Size = new Size(166, 25);
            label3.TabIndex = 10;
            label3.Text = "Обратная матрица";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1164, 586);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridViewB);
            Controls.Add(excelButton);
            Controls.Add(wordButton);
            Controls.Add(exitButton);
            Controls.Add(clearButton);
            Controls.Add(calculateButton);
            Controls.Add(comboBox);
            Controls.Add(dataGridViewA);
            Margin = new Padding(4, 3, 4, 3);
            Name = "MainForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridViewA).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewA;
        private ComboBox comboBox;
        private Button calculateButton;
        private Button clearButton;
        private Button exitButton;
        private Button wordButton;
        private Button excelButton;
        private DataGridView dataGridViewB;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}