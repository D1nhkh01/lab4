namespace Lab4
{
    partial class Lab4_Bai3
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
            this.btExit = new System.Windows.Forms.Button();
            this.rTBContent = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.btDownload = new System.Windows.Forms.Button();
            this.tbURL = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.Color.LightCoral;
            this.btExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btExit.Location = new System.Drawing.Point(641, 90);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(126, 38);
            this.btExit.TabIndex = 14;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // rTBContent
            // 
            this.rTBContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rTBContent.Location = new System.Drawing.Point(31, 156);
            this.rTBContent.Name = "rTBContent";
            this.rTBContent.ReadOnly = true;
            this.rTBContent.Size = new System.Drawing.Size(736, 349);
            this.rTBContent.TabIndex = 13;
            this.rTBContent.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(32, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "Vị trí lưu file";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "URL";
            // 
            // tbAddress
            // 
            this.tbAddress.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbAddress.Location = new System.Drawing.Point(31, 99);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(588, 29);
            this.tbAddress.TabIndex = 10;
            // 
            // btDownload
            // 
            this.btDownload.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDownload.Location = new System.Drawing.Point(641, 32);
            this.btDownload.Name = "btDownload";
            this.btDownload.Size = new System.Drawing.Size(126, 38);
            this.btDownload.TabIndex = 9;
            this.btDownload.Text = "Download";
            this.btDownload.UseVisualStyleBackColor = false;
            this.btDownload.Click += new System.EventHandler(this.btDownload_Click);
            // 
            // tbURL
            // 
            this.tbURL.BackColor = System.Drawing.SystemColors.HighlightText;
            this.tbURL.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbURL.Location = new System.Drawing.Point(31, 36);
            this.tbURL.Name = "tbURL";
            this.tbURL.Size = new System.Drawing.Size(588, 29);
            this.tbURL.TabIndex = 8;
            // 
            // Lab4_Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 517);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.rTBContent);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.btDownload);
            this.Controls.Add(this.tbURL);
            this.Name = "Lab4_Bai3";
            this.Text = "Bài 3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btExit;
        private System.Windows.Forms.RichTextBox rTBContent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Button btDownload;
        private System.Windows.Forms.TextBox tbURL;
    }
}