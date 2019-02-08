namespace UchetMarket
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SettingAddNewTover = new System.Windows.Forms.Button();
            this.SettingSaveTable = new System.Windows.Forms.Button();
            this.SettingUpdateTabl = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tovers = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Count = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.OpisanieTovara = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Top = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Coment = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ToverTable = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ToverTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.SettingAddNewTover);
            this.panel1.Controls.Add(this.SettingSaveTable);
            this.panel1.Controls.Add(this.SettingUpdateTabl);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(733, 53);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Настройки";
            // 
            // SettingAddNewTover
            // 
            this.SettingAddNewTover.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingAddNewTover.Location = new System.Drawing.Point(569, 25);
            this.SettingAddNewTover.Name = "SettingAddNewTover";
            this.SettingAddNewTover.Size = new System.Drawing.Size(161, 28);
            this.SettingAddNewTover.TabIndex = 2;
            this.SettingAddNewTover.Text = "Добавть новый товар";
            this.SettingAddNewTover.UseVisualStyleBackColor = true;
            this.SettingAddNewTover.Click += new System.EventHandler(this.button3_Click);
            // 
            // SettingSaveTable
            // 
            this.SettingSaveTable.Location = new System.Drawing.Point(135, 25);
            this.SettingSaveTable.Name = "SettingSaveTable";
            this.SettingSaveTable.Size = new System.Drawing.Size(126, 27);
            this.SettingSaveTable.TabIndex = 1;
            this.SettingSaveTable.Text = "Сохранить таблицу";
            this.SettingSaveTable.UseVisualStyleBackColor = true;
            // 
            // SettingUpdateTabl
            // 
            this.SettingUpdateTabl.Location = new System.Drawing.Point(0, 25);
            this.SettingUpdateTabl.Name = "SettingUpdateTabl";
            this.SettingUpdateTabl.Size = new System.Drawing.Size(110, 27);
            this.SettingUpdateTabl.TabIndex = 0;
            this.SettingUpdateTabl.Text = "Обновить таблицу";
            this.SettingUpdateTabl.UseVisualStyleBackColor = true;
            this.SettingUpdateTabl.Click += new System.EventHandler(this.SettingUpdateTabl_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.Tovers,
            this.Count,
            this.OpisanieTovara,
            this.Top,
            this.DateTime,
            this.Coment});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 25;
            this.dataGridView1.Size = new System.Drawing.Size(724, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            // 
            // Tovers
            // 
            this.Tovers.HeaderText = "Товары";
            this.Tovers.Name = "Tovers";
            // 
            // Count
            // 
            this.Count.HeaderText = "Количество";
            this.Count.Name = "Count";
            // 
            // OpisanieTovara
            // 
            this.OpisanieTovara.HeaderText = "Описание товара.";
            this.OpisanieTovara.Name = "OpisanieTovara";
            // 
            // Top
            // 
            this.Top.HeaderText = "Популярность";
            this.Top.Name = "Top";
            // 
            // DateTime
            // 
            this.DateTime.HeaderText = "Дата создания";
            this.DateTime.Name = "DateTime";
            // 
            // Coment
            // 
            this.Coment.HeaderText = "Коментарии";
            this.Coment.Name = "Coment";
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 103);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 230);
            this.panel2.TabIndex = 3;
            // 
            // ToverTable
            // 
            this.ToverTable.Controls.Add(this.textBox1);
            this.ToverTable.Controls.Add(this.dataGridView1);
            this.ToverTable.Location = new System.Drawing.Point(3, 61);
            this.ToverTable.Name = "ToverTable";
            this.ToverTable.Size = new System.Drawing.Size(730, 272);
            this.ToverTable.TabIndex = 4;
            this.ToverTable.TabStop = false;
            this.ToverTable.Text = "Настройки";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(145, 116);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(423, 109);
            this.textBox1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 333);
            this.Controls.Add(this.ToverTable);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(750, 375);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(749, 372);
            this.Name = "Form1";
            this.Text = "Учет";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ToverTable.ResumeLayout(false);
            this.ToverTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button SettingAddNewTover;
        private System.Windows.Forms.Button SettingSaveTable;
        private System.Windows.Forms.Button SettingUpdateTabl;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox ToverTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tovers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Count;
        private System.Windows.Forms.DataGridViewTextBoxColumn OpisanieTovara;
        private System.Windows.Forms.DataGridViewTextBoxColumn Top;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Coment;
        private System.Windows.Forms.TextBox textBox1;
    }
}

