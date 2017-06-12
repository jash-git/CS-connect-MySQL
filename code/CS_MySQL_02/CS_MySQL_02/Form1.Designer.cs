namespace CS_MySQL_02
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CW10_textBox00 = new System.Windows.Forms.TextBox();
            this.CW10_textBox01 = new System.Windows.Forms.TextBox();
            this.CW10_dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CW10_button04 = new System.Windows.Forms.Button();
            this.CW10_button03 = new System.Windows.Forms.Button();
            this.CW10_button02 = new System.Windows.Forms.Button();
            this.CW10_button01 = new System.Windows.Forms.Button();
            this.CW10_textBox02 = new System.Windows.Forms.TextBox();
            this.CW10_label02 = new System.Windows.Forms.Label();
            this.CW10_label01 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CW10_dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(905, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "open DB";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(905, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Create Table";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CW10_textBox00
            // 
            this.CW10_textBox00.Location = new System.Drawing.Point(491, 58);
            this.CW10_textBox00.Name = "CW10_textBox00";
            this.CW10_textBox00.Size = new System.Drawing.Size(33, 22);
            this.CW10_textBox00.TabIndex = 40;
            this.CW10_textBox00.Visible = false;
            // 
            // CW10_textBox01
            // 
            this.CW10_textBox01.Location = new System.Drawing.Point(172, 14);
            this.CW10_textBox01.Name = "CW10_textBox01";
            this.CW10_textBox01.Size = new System.Drawing.Size(135, 22);
            this.CW10_textBox01.TabIndex = 39;
            // 
            // CW10_dataGridView1
            // 
            this.CW10_dataGridView1.AllowUserToAddRows = false;
            this.CW10_dataGridView1.AllowUserToDeleteRows = false;
            this.CW10_dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.CW10_dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.CW10_dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CW10_dataGridView1.Location = new System.Drawing.Point(31, 114);
            this.CW10_dataGridView1.Name = "CW10_dataGridView1";
            this.CW10_dataGridView1.ReadOnly = true;
            this.CW10_dataGridView1.RowTemplate.Height = 24;
            this.CW10_dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CW10_dataGridView1.Size = new System.Drawing.Size(567, 422);
            this.CW10_dataGridView1.TabIndex = 38;
            this.CW10_dataGridView1.SelectionChanged += new System.EventHandler(this.CW10_dataGridView1_SelectionChanged);
            // 
            // CW10_button04
            // 
            this.CW10_button04.Location = new System.Drawing.Point(301, 71);
            this.CW10_button04.Name = "CW10_button04";
            this.CW10_button04.Size = new System.Drawing.Size(67, 29);
            this.CW10_button04.TabIndex = 37;
            this.CW10_button04.Text = "button4";
            this.CW10_button04.UseVisualStyleBackColor = true;
            this.CW10_button04.Click += new System.EventHandler(this.CW10_button04_Click);
            // 
            // CW10_button03
            // 
            this.CW10_button03.Location = new System.Drawing.Point(211, 71);
            this.CW10_button03.Name = "CW10_button03";
            this.CW10_button03.Size = new System.Drawing.Size(67, 29);
            this.CW10_button03.TabIndex = 36;
            this.CW10_button03.Text = "button3";
            this.CW10_button03.UseVisualStyleBackColor = true;
            this.CW10_button03.Click += new System.EventHandler(this.CW10_button03_Click);
            // 
            // CW10_button02
            // 
            this.CW10_button02.Location = new System.Drawing.Point(121, 71);
            this.CW10_button02.Name = "CW10_button02";
            this.CW10_button02.Size = new System.Drawing.Size(67, 29);
            this.CW10_button02.TabIndex = 35;
            this.CW10_button02.Text = "button2";
            this.CW10_button02.UseVisualStyleBackColor = true;
            this.CW10_button02.Click += new System.EventHandler(this.CW10_button02_Click);
            // 
            // CW10_button01
            // 
            this.CW10_button01.Location = new System.Drawing.Point(31, 71);
            this.CW10_button01.Name = "CW10_button01";
            this.CW10_button01.Size = new System.Drawing.Size(67, 29);
            this.CW10_button01.TabIndex = 34;
            this.CW10_button01.Text = "button1";
            this.CW10_button01.UseVisualStyleBackColor = true;
            this.CW10_button01.Click += new System.EventHandler(this.CW10_button01_Click);
            // 
            // CW10_textBox02
            // 
            this.CW10_textBox02.Location = new System.Drawing.Point(461, 14);
            this.CW10_textBox02.Name = "CW10_textBox02";
            this.CW10_textBox02.Size = new System.Drawing.Size(137, 22);
            this.CW10_textBox02.TabIndex = 33;
            // 
            // CW10_label02
            // 
            this.CW10_label02.AutoSize = true;
            this.CW10_label02.Location = new System.Drawing.Point(319, 17);
            this.CW10_label02.Name = "CW10_label02";
            this.CW10_label02.Size = new System.Drawing.Size(33, 12);
            this.CW10_label02.TabIndex = 32;
            this.CW10_label02.Text = "label2";
            // 
            // CW10_label01
            // 
            this.CW10_label01.AutoSize = true;
            this.CW10_label01.Location = new System.Drawing.Point(28, 17);
            this.CW10_label01.Name = "CW10_label01";
            this.CW10_label01.Size = new System.Drawing.Size(33, 12);
            this.CW10_label01.TabIndex = 31;
            this.CW10_label01.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 548);
            this.Controls.Add(this.CW10_textBox00);
            this.Controls.Add(this.CW10_textBox01);
            this.Controls.Add(this.CW10_dataGridView1);
            this.Controls.Add(this.CW10_button04);
            this.Controls.Add(this.CW10_button03);
            this.Controls.Add(this.CW10_button02);
            this.Controls.Add(this.CW10_button01);
            this.Controls.Add(this.CW10_textBox02);
            this.Controls.Add(this.CW10_label02);
            this.Controls.Add(this.CW10_label01);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CW10_dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CW10_textBox00;
        private System.Windows.Forms.TextBox CW10_textBox01;
        private System.Windows.Forms.DataGridView CW10_dataGridView1;
        private System.Windows.Forms.Button CW10_button04;
        private System.Windows.Forms.Button CW10_button03;
        private System.Windows.Forms.Button CW10_button02;
        private System.Windows.Forms.Button CW10_button01;
        private System.Windows.Forms.TextBox CW10_textBox02;
        private System.Windows.Forms.Label CW10_label02;
        private System.Windows.Forms.Label CW10_label01;
    }
}

