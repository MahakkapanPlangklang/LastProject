namespace LastProject
{
    partial class Mainform
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
            label1 = new Label();
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            table = new TableLayoutPanel();
            dataGridView1 = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            button1 = new Button();
            price = new TextBox();
            NameList = new ListBox();
            totalprice = new TextBox();
            button2 = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(268, 19);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Table Booking";
            // 
            // panel1
            // 
            panel1.Location = new Point(227, 75);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 296);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(table);
            groupBox1.Location = new Point(227, 75);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // table
            // 
            table.ColumnCount = 10;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            table.Location = new Point(0, 3);
            table.Name = "table";
            table.RowCount = 10;
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            table.Size = new Size(476, 290);
            table.TabIndex = 0;
            table.Paint += tableLayoutPanel1_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Column1 });
            dataGridView1.Location = new Point(12, 75);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(177, 296);
            dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            Column1.HeaderText = "Customer Name";
            Column1.MinimumWidth = 6;
            Column1.Name = "Column1";
            Column1.Width = 125;
            // 
            // button1
            // 
            button1.Location = new Point(178, 402);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 3;
            button1.Text = "จอง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // price
            // 
            price.Location = new Point(353, 402);
            price.Name = "price";
            price.Size = new Size(125, 27);
            price.TabIndex = 4;
            // 
            // NameList
            // 
            NameList.FormattingEnabled = true;
            NameList.ItemHeight = 20;
            NameList.Location = new Point(751, 78);
            NameList.Name = "NameList";
            NameList.Size = new Size(150, 304);
            NameList.TabIndex = 6;
            NameList.SelectedIndexChanged += NameList_SelectedIndexChanged;
            // 
            // totalprice
            // 
            totalprice.Location = new Point(527, 404);
            totalprice.Name = "totalprice";
            totalprice.Size = new Size(125, 27);
            totalprice.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(178, 437);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 8;
            button2.Text = "ยกเลิกการจอง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(971, 503);
            Controls.Add(button2);
            Controls.Add(totalprice);
            Controls.Add(NameList);
            Controls.Add(price);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "Mainform";
            Text = "Mainform";
            Load += Mainform_Load;
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel table;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private Button button1;
        private TextBox price;
        private ListBox NameList;
        private TextBox totalprice;
        private Button button2;
    }
}