namespace Practice14
{
    partial class Form1
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonSortAge = new System.Windows.Forms.Button();
            this.buttonSortPeople = new System.Windows.Forms.Button();
            this.buttonReadFile = new System.Windows.Forms.Button();
            this.dataGridViewPeople = new System.Windows.Forms.DataGridView();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.listBoxQueue = new System.Windows.Forms.ListBox();
            this.buttonExtract = new System.Windows.Forms.Button();
            this.textBoxAddN = new System.Windows.Forms.TextBox();
            this.buttonAddQueue = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.numericUpDownAge = new System.Windows.Forms.NumericUpDown();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).BeginInit();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numericUpDownAge);
            this.tabPage2.Controls.Add(this.buttonSortAge);
            this.tabPage2.Controls.Add(this.buttonSortPeople);
            this.tabPage2.Controls.Add(this.buttonReadFile);
            this.tabPage2.Controls.Add(this.dataGridViewPeople);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 422);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Задание4-5";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonSortAge
            // 
            this.buttonSortAge.Location = new System.Drawing.Point(508, 15);
            this.buttonSortAge.Name = "buttonSortAge";
            this.buttonSortAge.Size = new System.Drawing.Size(247, 23);
            this.buttonSortAge.TabIndex = 3;
            this.buttonSortAge.Text = "Отсортировать по возрасту(задание5)";
            this.buttonSortAge.UseVisualStyleBackColor = true;
            this.buttonSortAge.Click += new System.EventHandler(this.buttonSortAge_Click);
            // 
            // buttonSortPeople
            // 
            this.buttonSortPeople.Location = new System.Drawing.Point(157, 15);
            this.buttonSortPeople.Name = "buttonSortPeople";
            this.buttonSortPeople.Size = new System.Drawing.Size(345, 23);
            this.buttonSortPeople.TabIndex = 2;
            this.buttonSortPeople.Text = "Отсортировать до определенного возраста лет(задание4)";
            this.buttonSortPeople.UseVisualStyleBackColor = true;
            this.buttonSortPeople.Click += new System.EventHandler(this.buttonSortPeople_Click);
            // 
            // buttonReadFile
            // 
            this.buttonReadFile.Location = new System.Drawing.Point(14, 15);
            this.buttonReadFile.Name = "buttonReadFile";
            this.buttonReadFile.Size = new System.Drawing.Size(126, 23);
            this.buttonReadFile.TabIndex = 1;
            this.buttonReadFile.Text = "Считать из файла";
            this.buttonReadFile.UseVisualStyleBackColor = true;
            this.buttonReadFile.Click += new System.EventHandler(this.buttonReadFile_Click);
            // 
            // dataGridViewPeople
            // 
            this.dataGridViewPeople.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPeople.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridViewPeople.Location = new System.Drawing.Point(3, 80);
            this.dataGridViewPeople.Name = "dataGridViewPeople";
            this.dataGridViewPeople.RowTemplate.Height = 25;
            this.dataGridViewPeople.Size = new System.Drawing.Size(786, 339);
            this.dataGridViewPeople.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.listBoxQueue);
            this.tabPage1.Controls.Add(this.buttonExtract);
            this.tabPage1.Controls.Add(this.textBoxAddN);
            this.tabPage1.Controls.Add(this.buttonAddQueue);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 422);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Задание3";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // listBoxQueue
            // 
            this.listBoxQueue.FormattingEnabled = true;
            this.listBoxQueue.ItemHeight = 15;
            this.listBoxQueue.Location = new System.Drawing.Point(18, 119);
            this.listBoxQueue.Name = "listBoxQueue";
            this.listBoxQueue.Size = new System.Drawing.Size(168, 94);
            this.listBoxQueue.TabIndex = 3;
            // 
            // buttonExtract
            // 
            this.buttonExtract.Location = new System.Drawing.Point(18, 88);
            this.buttonExtract.Name = "buttonExtract";
            this.buttonExtract.Size = new System.Drawing.Size(168, 23);
            this.buttonExtract.TabIndex = 2;
            this.buttonExtract.Text = "Извлечь из очереди";
            this.buttonExtract.UseVisualStyleBackColor = true;
            this.buttonExtract.Click += new System.EventHandler(this.buttonExtract_Click);
            // 
            // textBoxAddN
            // 
            this.textBoxAddN.ForeColor = System.Drawing.Color.Gray;
            this.textBoxAddN.Location = new System.Drawing.Point(18, 30);
            this.textBoxAddN.Name = "textBoxAddN";
            this.textBoxAddN.Size = new System.Drawing.Size(168, 23);
            this.textBoxAddN.TabIndex = 1;
            this.textBoxAddN.Text = "Введите размер очереди n";
            this.textBoxAddN.Click += new System.EventHandler(this.textBoxAddN_Click);
            // 
            // buttonAddQueue
            // 
            this.buttonAddQueue.Location = new System.Drawing.Point(18, 59);
            this.buttonAddQueue.Name = "buttonAddQueue";
            this.buttonAddQueue.Size = new System.Drawing.Size(168, 23);
            this.buttonAddQueue.TabIndex = 0;
            this.buttonAddQueue.Text = "Записать в очередь";
            this.buttonAddQueue.UseVisualStyleBackColor = true;
            this.buttonAddQueue.Click += new System.EventHandler(this.buttonAddQueue_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // numericUpDownAge
            // 
            this.numericUpDownAge.Location = new System.Drawing.Point(157, 45);
            this.numericUpDownAge.Maximum = new decimal(new int[] {
            70,
            0,
            0,
            0});
            this.numericUpDownAge.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDownAge.Name = "numericUpDownAge";
            this.numericUpDownAge.Size = new System.Drawing.Size(345, 23);
            this.numericUpDownAge.TabIndex = 4;
            this.numericUpDownAge.Value = new decimal(new int[] {
            40,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPeople)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAge)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button buttonSortAge;
        private System.Windows.Forms.Button buttonSortPeople;
        private System.Windows.Forms.Button buttonReadFile;
        private System.Windows.Forms.DataGridView dataGridViewPeople;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ListBox listBoxQueue;
        private System.Windows.Forms.Button buttonExtract;
        private System.Windows.Forms.TextBox textBoxAddN;
        private System.Windows.Forms.Button buttonAddQueue;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.NumericUpDown numericUpDownAge;
    }
}
