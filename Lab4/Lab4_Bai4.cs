using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Bai4 : Form
    {
        public Lab4_Bai4()
        {
            InitializeComponent();
        }

        //Nút truy cập trang web
        private void btGo_Click(object sender, EventArgs e)
        {
            wBContent.Navigate(tbURL.Text);
        }

        //Nút download file HTML
        private void btDownload_Click(object sender, EventArgs e)
        {
            string html = wBContent.DocumentText;
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML File|*.html";
            saveFileDialog1.Title = "Save an HTML File";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(saveFileDialog1.FileName))
                {
                    sw.Write(html);
                }
            }
        }

        //Nút view source
        private void btView_Click(object sender, EventArgs e)
        {
            string html = wBContent.DocumentText;
            ViewSourceForm viewSourceForm = new ViewSourceForm(html);
            viewSourceForm.ShowDialog();
        }

        //Tạo form mới để view source
        public class ViewSourceForm : Form
        {
            private TextBox txtSource;

            public ViewSourceForm(string html)
            {
                InitializeComponent();
                txtSource.Text = html;
            }

            private void InitializeComponent()
            {
                this.txtSource = new System.Windows.Forms.TextBox();
                this.SuspendLayout();
                
                // txtSource                
                this.txtSource.Dock = System.Windows.Forms.DockStyle.Fill;
                this.txtSource.Location = new System.Drawing.Point(0, 0);
                this.txtSource.Multiline = true;
                this.txtSource.Name = "txtSource";
                this.txtSource.ScrollBars = System.Windows.Forms.ScrollBars.Both;
                this.txtSource.Size = new System.Drawing.Size(800, 450);
                this.txtSource.TabIndex = 0;
                
                // ViewSourceForm                
                this.ClientSize = new System.Drawing.Size(800, 450);
                this.Controls.Add(this.txtSource);
                this.Name = "ViewSourceForm";
                this.Text = "View Source";
                this.ResumeLayout(false);
                this.PerformLayout();
            }
        }

        //Thiết lập ScriptErrorsSuppressed thành true để chương trình không cáo lỗi Script khi chạy
        private void Lab4_Bai4_Load(object sender, EventArgs e)
        {
            wBContent.ScriptErrorsSuppressed = true;
        }

        //Thoát chương trình
        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
