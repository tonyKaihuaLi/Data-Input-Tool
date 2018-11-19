namespace DataImport
{
    partial class MainForm
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
            this.buttonOpenFiles = new System.Windows.Forms.Button();
            this.textFilePath = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOpenFiles
            // 
            this.buttonOpenFiles.Location = new System.Drawing.Point(813, 25);
            this.buttonOpenFiles.Name = "buttonOpenFiles";
            this.buttonOpenFiles.Size = new System.Drawing.Size(368, 252);
            this.buttonOpenFiles.TabIndex = 0;
            this.buttonOpenFiles.Text = "Open";
            this.buttonOpenFiles.UseVisualStyleBackColor = true;
            this.buttonOpenFiles.Click += new System.EventHandler(this.buttonOpenFiles_Click);
            // 
            // textFilePath
            // 
            this.textFilePath.Location = new System.Drawing.Point(73, 38);
            this.textFilePath.Multiline = true;
            this.textFilePath.Name = "textFilePath";
            this.textFilePath.Size = new System.Drawing.Size(683, 226);
            this.textFilePath.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 862);
            this.Controls.Add(this.textFilePath);
            this.Controls.Add(this.buttonOpenFiles);
            this.Name = "MainForm";
            this.Text = "Data Import";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOpenFiles;
        private System.Windows.Forms.TextBox textFilePath;
    }
}

