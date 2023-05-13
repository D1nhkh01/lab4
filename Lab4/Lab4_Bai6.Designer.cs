namespace Lab4
{
    partial class Lab4_Bai6
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
            this.btGet = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.btExit = new System.Windows.Forms.Button();
            this.pBLoad = new System.Windows.Forms.ProgressBar();
            this.lVWeb = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // btGet
            // 
            this.btGet.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGet.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGet.Location = new System.Drawing.Point(1037, 22);
            this.btGet.Name = "btGet";
            this.btGet.Size = new System.Drawing.Size(120, 31);
            this.btGet.TabIndex = 0;
            this.btGet.Text = "Get";
            this.btGet.UseVisualStyleBackColor = false;
            this.btGet.Click += new System.EventHandler(this.btGet_Click);
            // 
            // tbURL
            // 
            this.tbURL.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(19, 22);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(1003, 29);
            this.tbURL.TabIndex = 1;
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightCoral;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(1037, 59);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(120, 31);
            this.btExit.TabIndex = 2;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // pBLoad
            // 
            this.pBLoad.Location = new System.Drawing.Point(19, 807);
            this.pBLoad.Name = "pBLoad";
            this.pBLoad.Size = new System.Drawing.Size(1138, 27);
            this.pBLoad.TabIndex = 4;
            // 
            // lVWeb
            // 
            this.lVWeb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lVWeb.HideSelection = false;
            this.lVWeb.Location = new System.Drawing.Point(19, 96);
            this.lVWeb.Name = "lVWeb";
            this.lVWeb.Size = new System.Drawing.Size(1138, 705);
            this.lVWeb.TabIndex = 5;
            this.lVWeb.UseCompatibleStateImageBehavior = false;
            this.lVWeb.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lVURL_MouseDoubleClick);
            // 
            // Lab4_Bai6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(1184, 841);
            this.Controls.Add(this.lVWeb);
            this.Controls.Add(this.pBLoad);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.tbURL);
            this.Controls.Add(this.btGet);
            this.Name = "Lab4_Bai6";
            this.Text = "Bài 6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btGet;
        private System.Windows.Forms.TextBox tbURL;
        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.ProgressBar pBLoad;
        private System.Windows.Forms.ListView lVWeb;
    }
}