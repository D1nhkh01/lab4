using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_Bai3 : Form
    {
        public Lab4_Bai3()
        {
            InitializeComponent();
        }

        //Hàm download nội dung từ 1 trang web
        public void DownloadHTML(string url, string filePath)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    // Download nội dung trang web từ địa chỉ URL
                    string htmlContent = client.DownloadString(url);

                    // Lưu nội dung trang web vào file HTML
                    using (StreamWriter writer = new StreamWriter(filePath))
                    {
                        writer.Write(htmlContent);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btDownload_Click(object sender, EventArgs e)
        {
            if (tbURL.Text.Length > 0 && tbAddress.Text.Length > 0)
            {
                // Lấy địa chỉ URL và đường dẫn lưu file từ TextBox
                string url = tbURL.Text;
                string filePath = tbAddress.Text;

                // Download nội dung trang web và lưu vào file HTML
                DownloadHTML(url, filePath);

                // Hiển thị nội dung file HTML lên rTBContent
                rTBContent.LoadFile(filePath, RichTextBoxStreamType.PlainText);
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ URL và địa chỉ lưu file!", "Thông báo");
            }
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            Close();   
        }
    }
}
