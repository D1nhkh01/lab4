using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using HtmlAgilityPack;
using System.Security.Policy;

namespace Lab4
{
    public partial class Lab4_Bai6 : Form
    {
        public Lab4_Bai6()
        {
            InitializeComponent();
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btGet_Click(object sender, EventArgs e)
        {
            // Lấy đường dẫn trang web từ textbox
            string url = tbURL.Text;

            // Sử dụng HtmlAgilityPack để trích xuất thông tin từ trang web
            HtmlWeb web = new HtmlWeb();
            HtmlAgilityPack.HtmlDocument doc = web.Load(url);

            // Lấy danh sách các tin tức từ trang web
            var articles = doc.DocumentNode.Descendants("article");

            // Hiển thị danh sách các tin tức lên ListView
            lVWeb.BeginUpdate();
            lVWeb.Items.Clear();
            lVWeb.View = View.List;
            int count = 0;
            foreach (var article in articles)
            {
                string title = article.Descendants("a").FirstOrDefault()?.InnerText;
                string link = article.Descendants("a").FirstOrDefault()?.GetAttributeValue("href", "");
                string description = article.Descendants("p").FirstOrDefault()?.InnerText;

                // Tạo một ListViewItem mới để hiển thị thông tin của mỗi tin tức
                ListViewItem item = new ListViewItem(new[] { title, description });
                item.Tag = link;
                lVWeb.Items.Add(item);

                count++;
                pBLoad.Invoke(new Action(() => pBLoad.Value = (int)(((double)count / articles.Count()) * 100)));
            }
            lVWeb.EndUpdate();
        }

        private void lVURL_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lVWeb.SelectedItems.Count > 0)
            {
                string link = lVWeb.SelectedItems[0].Tag.ToString();
                ContentForm newsForm = new ContentForm(link);
                newsForm.Show();
            }
        }
    }

    public partial class ContentForm : Form
    {
        private WebBrowser wBContent;

        public ContentForm(string url)
        {
            InitializeComponent();
            wBContent.Navigate(url);
            wBContent.ScriptErrorsSuppressed = true;
        }

        private void InitializeComponent()
        {
            this.wBContent = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();

            // Web browser
            this.wBContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.wBContent.Location = new System.Drawing.Point(0, 0);
            this.wBContent.MinimumSize = new System.Drawing.Size(20, 20);
            this.wBContent.Name = "Content";
            this.wBContent.Size = new System.Drawing.Size(800, 450);
            this.wBContent.TabIndex = 0;

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.wBContent);
            this.Name = "ContentForm";
            this.Text = "ContentForm";
            this.ResumeLayout(false);
        }
    }
}
