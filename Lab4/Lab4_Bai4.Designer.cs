namespace Lab4
{
    partial class Lab4_Bai4
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
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btGo = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.btDownload = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.wBContent = new System.Windows.Forms.WebBrowser();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbURL
            // 
            this.tbURL.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(23, 22);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(850, 29);
            this.tbURL.TabIndex = 0;
            // 
            // btGo
            // 
            this.btGo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGo.Location = new System.Drawing.Point(890, 21);
            this.btGo.Name = "btGo";
            this.btGo.Size = new System.Drawing.Size(149, 33);
            this.btGo.TabIndex = 1;
            this.btGo.Text = "Go";
            this.btGo.UseVisualStyleBackColor = false;
            this.btGo.Click += new System.EventHandler(this.btGo_Click);
            // 
            // btView
            // 
            this.btView.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btView.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btView.Location = new System.Drawing.Point(890, 60);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(149, 33);
            this.btView.TabIndex = 2;
            this.btView.Text = "View Source";
            this.btView.UseVisualStyleBackColor = false;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.Location = new System.Drawing.Point(1054, 21);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(149, 33);
            this.btDownload.TabIndex = 3;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // wBContent
            // 
            this.wBContent.Location = new System.Drawing.Point(23, 99);
            this.wBContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBContent.Name = "wBContent";
            this.wBContent.Size = new System.Drawing.Size(1200, 841);
            this.wBContent.TabIndex = 4;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightCoral;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1054, 60);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(149, 33);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Lab4_Bai4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1258, 962);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.wBContent);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btGo);
            this.Controls.Add(this.tbURL);
            this.Name = "Lab4_Bai4";
            this.Text = "Bài 4";
            this.Load += new System.EventHandler(this.Lab4_Bai4_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btGo;
        private System.Windows.Forms.Button btView;
        private System.Windows.Forms.Button btDownload;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.WebBrowser wBContent;
        private System.Windows.Forms.Button btExit;
    }
}