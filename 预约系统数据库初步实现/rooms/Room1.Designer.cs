namespace 系统初步实现2_数据库.rooms
{
    partial class Room1
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
            this.book = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lookbutton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.endDate = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.endTime = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.startDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.startTime = new System.Windows.Forms.ComboBox();
            this.seatsPanel = new System.Windows.Forms.Panel();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.seatsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // book
            // 
            this.book.Location = new System.Drawing.Point(345, 395);
            this.book.Name = "book";
            this.book.Size = new System.Drawing.Size(75, 32);
            this.book.TabIndex = 27;
            this.book.Text = "预约";
            this.book.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(518, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 25);
            this.label1.TabIndex = 26;
            this.label1.Text = "Room1座位分布如下";
            // 
            // lookbutton
            // 
            this.lookbutton.Location = new System.Drawing.Point(114, 66);
            this.lookbutton.Name = "lookbutton";
            this.lookbutton.Size = new System.Drawing.Size(120, 31);
            this.lookbutton.TabIndex = 36;
            this.lookbutton.Text = "查看教室实景";
            this.lookbutton.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.endDate);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.endTime);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.startDate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.startTime);
            this.panel1.Location = new System.Drawing.Point(25, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(340, 196);
            this.panel1.TabIndex = 38;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.Location = new System.Drawing.Point(26, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(284, 23);
            this.label6.TabIndex = 46;
            this.label6.Text = "请先填写信息再进行选座";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // endDate
            // 
            this.endDate.Location = new System.Drawing.Point(89, 145);
            this.endDate.Name = "endDate";
            this.endDate.Size = new System.Drawing.Size(100, 25);
            this.endDate.TabIndex = 45;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 15);
            this.label5.TabIndex = 44;
            this.label5.Text = "结束时间";
            // 
            // endTime
            // 
            this.endTime.FormattingEnabled = true;
            this.endTime.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00",
            "24:00:00"});
            this.endTime.Location = new System.Drawing.Point(215, 147);
            this.endTime.Name = "endTime";
            this.endTime.Size = new System.Drawing.Size(121, 23);
            this.endTime.TabIndex = 43;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(243, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 42;
            this.label4.Text = "选择时间";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 41;
            this.label3.Text = "填写日期";
            // 
            // startDate
            // 
            this.startDate.Location = new System.Drawing.Point(89, 89);
            this.startDate.Name = "startDate";
            this.startDate.Size = new System.Drawing.Size(100, 25);
            this.startDate.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 39;
            this.label2.Text = "开始时间";
            // 
            // startTime
            // 
            this.startTime.FormattingEnabled = true;
            this.startTime.Items.AddRange(new object[] {
            "00:00:00",
            "01:00:00",
            "02:00:00",
            "03:00:00",
            "04:00:00",
            "05:00:00",
            "06:00:00",
            "07:00:00",
            "08:00:00",
            "09:00:00",
            "10:00:00",
            "11:00:00",
            "12:00:00",
            "13:00:00",
            "14:00:00",
            "15:00:00",
            "16:00:00",
            "17:00:00",
            "18:00:00",
            "19:00:00",
            "20:00:00",
            "21:00:00",
            "22:00:00",
            "23:00:00",
            "24:00:00"});
            this.startTime.Location = new System.Drawing.Point(215, 91);
            this.startTime.Name = "startTime";
            this.startTime.Size = new System.Drawing.Size(121, 23);
            this.startTime.TabIndex = 38;
            // 
            // seatsPanel
            // 
            this.seatsPanel.Controls.Add(this.checkBox7);
            this.seatsPanel.Controls.Add(this.checkBox6);
            this.seatsPanel.Controls.Add(this.checkBox5);
            this.seatsPanel.Controls.Add(this.checkBox4);
            this.seatsPanel.Controls.Add(this.checkBox3);
            this.seatsPanel.Controls.Add(this.checkBox2);
            this.seatsPanel.Controls.Add(this.checkBox1);
            this.seatsPanel.Location = new System.Drawing.Point(383, 31);
            this.seatsPanel.Name = "seatsPanel";
            this.seatsPanel.Size = new System.Drawing.Size(387, 326);
            this.seatsPanel.TabIndex = 52;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(271, 188);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(101, 19);
            this.checkBox7.TabIndex = 63;
            this.checkBox7.Text = "checkBox7";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(271, 124);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(101, 19);
            this.checkBox6.TabIndex = 57;
            this.checkBox6.Text = "checkBox6";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(271, 70);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(101, 19);
            this.checkBox5.TabIndex = 56;
            this.checkBox5.Text = "checkBox5";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(15, 225);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(101, 19);
            this.checkBox4.TabIndex = 55;
            this.checkBox4.Text = "checkBox4";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(15, 161);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(101, 19);
            this.checkBox3.TabIndex = 54;
            this.checkBox3.Text = "checkBox3";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 97);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(101, 19);
            this.checkBox2.TabIndex = 53;
            this.checkBox2.Text = "checkBox2";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 41);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(101, 19);
            this.checkBox1.TabIndex = 52;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // Room1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.seatsPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lookbutton);
            this.Controls.Add(this.book);
            this.Controls.Add(this.label1);
            this.Name = "Room1";
            this.Text = "Room1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.seatsPanel.ResumeLayout(false);
            this.seatsPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button book;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lookbutton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox endDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox endTime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox startDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox startTime;
        private System.Windows.Forms.Panel seatsPanel;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}