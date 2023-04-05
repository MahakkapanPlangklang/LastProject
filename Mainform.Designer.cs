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
            button1 = new Button();
            price = new TextBox();
            NameList = new ListBox();
            totalprice = new TextBox();
            button2 = new Button();
            label2 = new Label();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            ไฟลToolStripMenuItem = new ToolStripMenuItem();
            บนทกToolStripMenuItem = new ToolStripMenuItem();
            เปดToolStripMenuItem = new ToolStripMenuItem();
            ลอคเอาทToolStripMenuItem = new ToolStripMenuItem();
            groupBox1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(297, 28);
            label1.Name = "label1";
            label1.Size = new Size(103, 20);
            label1.TabIndex = 0;
            label1.Text = "Table Booking";
            // 
            // panel1
            // 
            panel1.Location = new Point(30, 61);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 296);
            panel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(table);
            groupBox1.Location = new Point(30, 61);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(476, 296);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // table
            // 
            table.BackColor = SystemColors.Control;
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
            table.Size = new Size(476, 293);
            table.TabIndex = 0;
            table.Paint += tableLayoutPanel1_Paint;
            // 
            // button1
            // 
            button1.Location = new Point(30, 397);
            button1.Name = "button1";
            button1.Size = new Size(117, 29);
            button1.TabIndex = 3;
            button1.Text = "จอง";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // price
            // 
            price.Location = new Point(306, 397);
            price.Name = "price";
            price.ReadOnly = true;
            price.Size = new Size(125, 27);
            price.TabIndex = 4;
            // 
            // NameList
            // 
            NameList.FormattingEnabled = true;
            NameList.ItemHeight = 20;
            NameList.Location = new Point(522, 64);
            NameList.Name = "NameList";
            NameList.Size = new Size(190, 304);
            NameList.TabIndex = 6;
            NameList.SelectedIndexChanged += NameList_SelectedIndexChanged;
            // 
            // totalprice
            // 
            totalprice.Location = new Point(306, 439);
            totalprice.Name = "totalprice";
            totalprice.ReadOnly = true;
            totalprice.Size = new Size(125, 27);
            totalprice.TabIndex = 7;
            // 
            // button2
            // 
            button2.Location = new Point(30, 432);
            button2.Name = "button2";
            button2.Size = new Size(117, 29);
            button2.TabIndex = 8;
            button2.Text = "ยกเลิกการจอง";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(244, 401);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 9;
            label2.Text = "ราคา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(182, 446);
            label3.Name = "label3";
            label3.Size = new Size(100, 20);
            label3.TabIndex = 10;
            label3.Text = "ราคารวมทั้งหมด";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { ไฟลToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(746, 28);
            menuStrip1.TabIndex = 11;
            menuStrip1.Text = "menuStrip1";
            // 
            // ไฟลToolStripMenuItem
            // 
            ไฟลToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { บนทกToolStripMenuItem, เปดToolStripMenuItem, ลอคเอาทToolStripMenuItem });
            ไฟลToolStripMenuItem.Name = "ไฟลToolStripMenuItem";
            ไฟลToolStripMenuItem.Size = new Size(47, 24);
            ไฟลToolStripMenuItem.Text = "ไฟล์";
            // 
            // บนทกToolStripMenuItem
            // 
            บนทกToolStripMenuItem.Name = "บนทกToolStripMenuItem";
            บนทกToolStripMenuItem.Size = new Size(170, 26);
            บนทกToolStripMenuItem.Text = "บันทึก";
            บนทกToolStripMenuItem.Click += บนทกToolStripMenuItem_Click;
            // 
            // เปดToolStripMenuItem
            // 
            เปดToolStripMenuItem.Name = "เปดToolStripMenuItem";
            เปดToolStripMenuItem.Size = new Size(170, 26);
            เปดToolStripMenuItem.Text = "เปิด";
            เปดToolStripMenuItem.Click += เปดToolStripMenuItem_Click;
            // 
            // ลอคเอาทToolStripMenuItem
            // 
            ลอคเอาทToolStripMenuItem.Name = "ลอคเอาทToolStripMenuItem";
            ลอคเอาทToolStripMenuItem.Size = new Size(170, 26);
            ลอคเอาทToolStripMenuItem.Text = "ออกจากระบบ";
            ลอคเอาทToolStripMenuItem.Click += ลอคเอาทToolStripMenuItem_Click;
            // 
            // Mainform
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(746, 494);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(totalprice);
            Controls.Add(NameList);
            Controls.Add(price);
            Controls.Add(button1);
            Controls.Add(groupBox1);
            Controls.Add(panel1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Mainform";
            Text = "Mainform";
            FormClosing += Mainform_FormClosing;
            Load += Mainform_Load;
            groupBox1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Panel panel1;
        private GroupBox groupBox1;
        private TableLayoutPanel table;
        private Button button1;
        private TextBox price;
        private ListBox NameList;
        private TextBox totalprice;
        private Button button2;
        private Label label2;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem ไฟลToolStripMenuItem;
        private ToolStripMenuItem บนทกToolStripMenuItem;
        private ToolStripMenuItem เปดToolStripMenuItem;
        private ToolStripMenuItem ลอคเอาทToolStripMenuItem;
    }
}