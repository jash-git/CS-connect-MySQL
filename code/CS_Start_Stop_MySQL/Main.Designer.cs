namespace CS_Start_Stop_MySQL
{
    partial class Main
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
            this.butstart = new System.Windows.Forms.Button();
            this.butstop = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // butstart
            // 
            this.butstart.Location = new System.Drawing.Point(29, 32);
            this.butstart.Name = "butstart";
            this.butstart.Size = new System.Drawing.Size(75, 23);
            this.butstart.TabIndex = 0;
            this.butstart.Text = "start";
            this.butstart.UseVisualStyleBackColor = true;
            this.butstart.Click += new System.EventHandler(this.butstart_Click);
            // 
            // butstop
            // 
            this.butstop.Location = new System.Drawing.Point(169, 31);
            this.butstop.Name = "butstop";
            this.butstop.Size = new System.Drawing.Size(75, 23);
            this.butstop.TabIndex = 1;
            this.butstop.Text = "stop";
            this.butstop.UseVisualStyleBackColor = true;
            this.butstop.Click += new System.EventHandler(this.butstop_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 83);
            this.Controls.Add(this.butstop);
            this.Controls.Add(this.butstart);
            this.Name = "Main";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button butstart;
        private System.Windows.Forms.Button butstop;
    }
}

