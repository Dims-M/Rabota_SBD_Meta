namespace UchetMarket
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DateNastroika = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.Comment_textBox4 = new System.Windows.Forms.TextBox();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.opisanieTover = new System.Windows.Forms.Label();
            this.AddToverCount = new System.Windows.Forms.Label();
            this.AddTover = new System.Windows.Forms.Label();
            this.AddToverID = new System.Windows.Forms.Label();
            this.AddToverText_textBox = new System.Windows.Forms.TextBox();
            this.OpisanieTovar_textBox3 = new System.Windows.Forms.TextBox();
            this.Comment_label5 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.DateNastroika.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(334, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Добавить товар";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.DateNastroika);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 245);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(334, 88);
            this.panel1.TabIndex = 2;
            // 
            // DateNastroika
            // 
            this.DateNastroika.Controls.Add(this.tableLayoutPanel2);
            this.DateNastroika.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DateNastroika.Location = new System.Drawing.Point(0, 1);
            this.DateNastroika.Name = "DateNastroika";
            this.DateNastroika.Size = new System.Drawing.Size(334, 87);
            this.DateNastroika.TabIndex = 0;
            this.DateNastroika.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.89024F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.10976F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.button2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.button3, 1, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 16);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(328, 68);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Время";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(123, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(196, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = ".";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(123, 37);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(196, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Выход";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Comment_textBox4
            // 
            this.Comment_textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.Comment_textBox4.Location = new System.Drawing.Point(75, 205);
            this.Comment_textBox4.Multiline = true;
            this.Comment_textBox4.Name = "Comment_textBox4";
            this.Comment_textBox4.Size = new System.Drawing.Size(256, 38);
            this.Comment_textBox4.TabIndex = 11;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown2.Location = new System.Drawing.Point(75, 105);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(256, 20);
            this.numericUpDown2.TabIndex = 8;
            this.numericUpDown2.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Location = new System.Drawing.Point(75, 6);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(256, 20);
            this.numericUpDown1.TabIndex = 6;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // opisanieTover
            // 
            this.opisanieTover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.opisanieTover.Location = new System.Drawing.Point(3, 142);
            this.opisanieTover.Name = "opisanieTover";
            this.opisanieTover.Size = new System.Drawing.Size(66, 54);
            this.opisanieTover.TabIndex = 3;
            this.opisanieTover.Text = "Описание товара";
            this.opisanieTover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddToverCount
            // 
            this.AddToverCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToverCount.Location = new System.Drawing.Point(3, 88);
            this.AddToverCount.Name = "AddToverCount";
            this.AddToverCount.Size = new System.Drawing.Size(66, 54);
            this.AddToverCount.TabIndex = 2;
            this.AddToverCount.Text = "Количество";
            this.AddToverCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddTover
            // 
            this.AddTover.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddTover.Location = new System.Drawing.Point(3, 32);
            this.AddTover.Name = "AddTover";
            this.AddTover.Size = new System.Drawing.Size(66, 56);
            this.AddTover.TabIndex = 1;
            this.AddTover.Text = "Товар";
            this.AddTover.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddToverID
            // 
            this.AddToverID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddToverID.Location = new System.Drawing.Point(3, 0);
            this.AddToverID.Name = "AddToverID";
            this.AddToverID.Size = new System.Drawing.Size(66, 32);
            this.AddToverID.TabIndex = 0;
            this.AddToverID.Text = "ID";
            this.AddToverID.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AddToverText_textBox
            // 
            this.AddToverText_textBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToverText_textBox.Location = new System.Drawing.Point(75, 41);
            this.AddToverText_textBox.Multiline = true;
            this.AddToverText_textBox.Name = "AddToverText_textBox";
            this.AddToverText_textBox.Size = new System.Drawing.Size(256, 38);
            this.AddToverText_textBox.TabIndex = 9;
            // 
            // OpisanieTovar_textBox3
            // 
            this.OpisanieTovar_textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.OpisanieTovar_textBox3.Location = new System.Drawing.Point(75, 150);
            this.OpisanieTovar_textBox3.Multiline = true;
            this.OpisanieTovar_textBox3.Name = "OpisanieTovar_textBox3";
            this.OpisanieTovar_textBox3.Size = new System.Drawing.Size(256, 37);
            this.OpisanieTovar_textBox3.TabIndex = 10;
            // 
            // Comment_label5
            // 
            this.Comment_label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Comment_label5.Location = new System.Drawing.Point(3, 196);
            this.Comment_label5.Name = "Comment_label5";
            this.Comment_label5.Size = new System.Drawing.Size(66, 57);
            this.Comment_label5.TabIndex = 12;
            this.Comment_label5.Text = "Комент";
            this.Comment_label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 21.62162F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 78.37838F));
            this.tableLayoutPanel1.Controls.Add(this.Comment_label5, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.OpisanieTovar_textBox3, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.AddToverText_textBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddToverID, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.AddTover, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.AddToverCount, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.opisanieTover, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.numericUpDown2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.Comment_textBox4, 1, 4);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.96549F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.20704F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.60916F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(334, 253);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 356);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(350, 426);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(350, 395);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить товар";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.panel1.ResumeLayout(false);
            this.DateNastroika.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox DateNastroika;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox Comment_textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label opisanieTover;
        private System.Windows.Forms.Label AddToverCount;
        private System.Windows.Forms.Label AddTover;
        private System.Windows.Forms.Label AddToverID;
        private System.Windows.Forms.TextBox AddToverText_textBox;
        private System.Windows.Forms.TextBox OpisanieTovar_textBox3;
        private System.Windows.Forms.Label Comment_label5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button button2;
       // public System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label2;
    }
}