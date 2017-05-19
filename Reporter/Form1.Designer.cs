namespace Reporter
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtConnectionString = new System.Windows.Forms.TextBox();
            this.label_sql = new System.Windows.Forms.Label();
            this.txt_sql = new System.Windows.Forms.TextBox();
            this.label_params = new System.Windows.Forms.Label();
            this.txt_params = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接字符串";
            // 
            // txtConnectionString
            // 
            this.txtConnectionString.Location = new System.Drawing.Point(129, 24);
            this.txtConnectionString.Name = "txtConnectionString";
            this.txtConnectionString.Size = new System.Drawing.Size(644, 21);
            this.txtConnectionString.TabIndex = 1;
            // 
            // label_sql
            // 
            this.label_sql.AutoSize = true;
            this.label_sql.Location = new System.Drawing.Point(79, 73);
            this.label_sql.Name = "label_sql";
            this.label_sql.Size = new System.Drawing.Size(23, 12);
            this.label_sql.TabIndex = 2;
            this.label_sql.Text = "SQL";
            // 
            // txt_sql
            // 
            this.txt_sql.Location = new System.Drawing.Point(129, 73);
            this.txt_sql.Multiline = true;
            this.txt_sql.Name = "txt_sql";
            this.txt_sql.Size = new System.Drawing.Size(644, 223);
            this.txt_sql.TabIndex = 3;
            // 
            // label_params
            // 
            this.label_params.AutoSize = true;
            this.label_params.Location = new System.Drawing.Point(67, 339);
            this.label_params.Name = "label_params";
            this.label_params.Size = new System.Drawing.Size(29, 12);
            this.label_params.TabIndex = 4;
            this.label_params.Text = "参数";
            // 
            // txt_params
            // 
            this.txt_params.Location = new System.Drawing.Point(129, 329);
            this.txt_params.Multiline = true;
            this.txt_params.Name = "txt_params";
            this.txt_params.Size = new System.Drawing.Size(644, 95);
            this.txt_params.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(362, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "生成excel";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 540);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_params);
            this.Controls.Add(this.label_params);
            this.Controls.Add(this.txt_sql);
            this.Controls.Add(this.label_sql);
            this.Controls.Add(this.txtConnectionString);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "通用excel导出";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtConnectionString;
        private System.Windows.Forms.Label label_sql;
        private System.Windows.Forms.TextBox txt_sql;
        private System.Windows.Forms.Label label_params;
        private System.Windows.Forms.TextBox txt_params;
        private System.Windows.Forms.Button button1;
    }
}

