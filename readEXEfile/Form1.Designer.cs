namespace readEXEfile
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
            this.openCom = new System.Windows.Forms.Button();
            this.closeCom = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_razmer = new System.Windows.Forms.Button();
            this.button_save_exe = new System.Windows.Forms.Button();
            this.button_read_com = new System.Windows.Forms.Button();
            this.datatip = new System.Windows.Forms.Label();
            this.ClearScrin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.textt = new System.Windows.Forms.RadioButton();
            this.hex = new System.Windows.Forms.RadioButton();
            this.apply = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.sent = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openCom
            // 
            this.openCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.openCom.FlatAppearance.BorderSize = 0;
            this.openCom.Location = new System.Drawing.Point(542, 12);
            this.openCom.Name = "openCom";
            this.openCom.Size = new System.Drawing.Size(111, 38);
            this.openCom.TabIndex = 0;
            this.openCom.Text = "Открыть ComPort";
            this.openCom.UseVisualStyleBackColor = true;
            this.openCom.Click += new System.EventHandler(this.openCom_Click);
            // 
            // closeCom
            // 
            this.closeCom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeCom.FlatAppearance.BorderSize = 0;
            this.closeCom.Location = new System.Drawing.Point(666, 12);
            this.closeCom.Name = "closeCom";
            this.closeCom.Size = new System.Drawing.Size(114, 38);
            this.closeCom.TabIndex = 1;
            this.closeCom.Text = "Закрыть ComPort";
            this.closeCom.UseVisualStyleBackColor = true;
            this.closeCom.Click += new System.EventHandler(this.closeCom_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button_razmer);
            this.panel1.Controls.Add(this.button_save_exe);
            this.panel1.Controls.Add(this.button_read_com);
            this.panel1.Controls.Add(this.datatip);
            this.panel1.Controls.Add(this.ClearScrin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.openCom);
            this.panel1.Controls.Add(this.closeCom);
            this.panel1.Location = new System.Drawing.Point(12, 464);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panel1.Size = new System.Drawing.Size(1033, 63);
            this.panel1.TabIndex = 2;
            // 
            // button_razmer
            // 
            this.button_razmer.BackColor = System.Drawing.Color.DarkGray;
            this.button_razmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_razmer.FlatAppearance.BorderSize = 0;
            this.button_razmer.Location = new System.Drawing.Point(172, 12);
            this.button_razmer.Name = "button_razmer";
            this.button_razmer.Size = new System.Drawing.Size(111, 38);
            this.button_razmer.TabIndex = 9;
            this.button_razmer.Text = "Узнать размер";
            this.button_razmer.UseVisualStyleBackColor = false;
            this.button_razmer.Click += new System.EventHandler(this.button_razmer_Click);
            // 
            // button_save_exe
            // 
            this.button_save_exe.BackColor = System.Drawing.Color.DarkGray;
            this.button_save_exe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_save_exe.FlatAppearance.BorderSize = 0;
            this.button_save_exe.Location = new System.Drawing.Point(406, 12);
            this.button_save_exe.Name = "button_save_exe";
            this.button_save_exe.Size = new System.Drawing.Size(111, 38);
            this.button_save_exe.TabIndex = 8;
            this.button_save_exe.Text = "Сохранить .EXE";
            this.button_save_exe.UseVisualStyleBackColor = false;
            this.button_save_exe.Click += new System.EventHandler(this.button_save_exe_Click);
            // 
            // button_read_com
            // 
            this.button_read_com.BackColor = System.Drawing.Color.DarkGray;
            this.button_read_com.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_read_com.FlatAppearance.BorderSize = 0;
            this.button_read_com.Location = new System.Drawing.Point(289, 12);
            this.button_read_com.Name = "button_read_com";
            this.button_read_com.Size = new System.Drawing.Size(111, 38);
            this.button_read_com.TabIndex = 6;
            this.button_read_com.Text = "Скачать EXE файл";
            this.button_read_com.UseVisualStyleBackColor = false;
            this.button_read_com.Click += new System.EventHandler(this.button_read_com_Click);
            // 
            // datatip
            // 
            this.datatip.AutoSize = true;
            this.datatip.BackColor = System.Drawing.SystemColors.Control;
            this.datatip.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.datatip.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.datatip.ForeColor = System.Drawing.Color.Black;
            this.datatip.Location = new System.Drawing.Point(815, 3);
            this.datatip.Name = "datatip";
            this.datatip.Size = new System.Drawing.Size(95, 18);
            this.datatip.TabIndex = 5;
            this.datatip.Text = "Тип данных";
            // 
            // ClearScrin
            // 
            this.ClearScrin.BackColor = System.Drawing.Color.DimGray;
            this.ClearScrin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClearScrin.FlatAppearance.BorderSize = 0;
            this.ClearScrin.Location = new System.Drawing.Point(16, 12);
            this.ClearScrin.Name = "ClearScrin";
            this.ClearScrin.Size = new System.Drawing.Size(111, 38);
            this.ClearScrin.TabIndex = 2;
            this.ClearScrin.Text = "Очистить Экран";
            this.ClearScrin.UseVisualStyleBackColor = false;
            this.ClearScrin.Click += new System.EventHandler(this.ClearScrin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.textt);
            this.panel2.Controls.Add(this.hex);
            this.panel2.Location = new System.Drawing.Point(802, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(228, 38);
            this.panel2.TabIndex = 7;
            // 
            // textt
            // 
            this.textt.AutoSize = true;
            this.textt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textt.Location = new System.Drawing.Point(172, 11);
            this.textt.Name = "textt";
            this.textt.Size = new System.Drawing.Size(52, 20);
            this.textt.TabIndex = 7;
            this.textt.TabStop = true;
            this.textt.Text = "Text";
            this.textt.UseVisualStyleBackColor = true;
            // 
            // hex
            // 
            this.hex.AutoSize = true;
            this.hex.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hex.Location = new System.Drawing.Point(116, 11);
            this.hex.Name = "hex";
            this.hex.Size = new System.Drawing.Size(50, 20);
            this.hex.TabIndex = 6;
            this.hex.TabStop = true;
            this.hex.Text = "Hex";
            this.hex.UseVisualStyleBackColor = true;
            // 
            // apply
            // 
            this.apply.BackColor = System.Drawing.Color.Silver;
            this.apply.Cursor = System.Windows.Forms.Cursors.Hand;
            this.apply.FlatAppearance.BorderSize = 0;
            this.apply.Location = new System.Drawing.Point(55, 376);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(114, 38);
            this.apply.TabIndex = 2;
            this.apply.Text = "Применить";
            this.apply.UseVisualStyleBackColor = false;
            this.apply.Click += new System.EventHandler(this.button1_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Location = new System.Drawing.Point(12, 32);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel1.Controls.Add(this.textBox2);
            this.splitContainer1.Panel1.Controls.Add(this.sent);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.Color.Silver;
            this.splitContainer1.Panel2.Controls.Add(this.apply);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox5);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox4);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox3);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox1);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.ForeColor = System.Drawing.Color.Black;
            this.splitContainer1.Panel2.Margin = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1033, 426);
            this.splitContainer1.SplitterDistance = 795;
            this.splitContainer1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(16, 376);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(501, 38);
            this.textBox2.TabIndex = 5;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sent
            // 
            this.sent.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sent.FlatAppearance.BorderSize = 0;
            this.sent.Location = new System.Drawing.Point(542, 376);
            this.sent.Name = "sent";
            this.sent.Size = new System.Drawing.Size(111, 38);
            this.sent.TabIndex = 3;
            this.sent.Text = "Отправить в СОМ";
            this.sent.UseVisualStyleBackColor = true;
            this.sent.Click += new System.EventHandler(this.sent_Click);
            // 
            // textBox1
            // 
            this.textBox1.AllowDrop = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.Window;
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(16, 12);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(748, 350);
            this.textBox1.TabIndex = 0;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Items.AddRange(new object[] {
            "7",
            "8"});
            this.comboBox5.Location = new System.Drawing.Point(17, 325);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(195, 21);
            this.comboBox5.TabIndex = 9;
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "1",
            "2"});
            this.comboBox4.Location = new System.Drawing.Point(17, 247);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(195, 21);
            this.comboBox4.TabIndex = 8;
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "None",
            "Odd",
            "Even"});
            this.comboBox3.Location = new System.Drawing.Point(17, 168);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(195, 21);
            this.comboBox3.TabIndex = 7;
            this.comboBox3.SelectedIndexChanged += new System.EventHandler(this.comboBox3_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "9600",
            "19200",
            "115200"});
            this.comboBox2.Location = new System.Drawing.Point(17, 100);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(195, 21);
            this.comboBox2.TabIndex = 6;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Com1",
            "Com2",
            "Com3",
            "Com4",
            "Com5",
            "Com6",
            "Com7",
            "Com8",
            "Com9"});
            this.comboBox1.Location = new System.Drawing.Point(17, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 5;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 16);
            this.label6.TabIndex = 4;
            this.label6.Text = "Data Bits";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 228);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Stop Bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Parity";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(14, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Baud Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(14, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Port";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(828, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Опции";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(39, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(189, 18);
            this.label7.TabIndex = 4;
            this.label7.Text = "Serial port communication";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 539);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.DataBindings.Add(new System.Windows.Forms.Binding("StartPosition", global::readEXEfile.Properties.Settings.Default, "center", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.Location = new System.Drawing.Point(100, 100);
            this.Name = "Form1";
            this.StartPosition = global::readEXEfile.Properties.Settings.Default.center;
            this.Text = "VRFHost";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openCom;
        private System.Windows.Forms.Button closeCom;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Button sent;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button ClearScrin;
        private System.Windows.Forms.Label datatip;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton textt;
        private System.Windows.Forms.RadioButton hex;
        private System.Windows.Forms.Button button_read_com;
        private System.Windows.Forms.Button button_razmer;
        private System.Windows.Forms.Button button_save_exe;
    }
}

