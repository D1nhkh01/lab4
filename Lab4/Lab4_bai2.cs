using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4
{
    public partial class Lab4_bai2 : Form
    {
        public Lab4_bai2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getHTTP(textBox1.Text, textBox2.Text);
            richTextBox1.Text = getHTML(textBox1.Text);
        }

        public string getHTTP(string szURL, string szPost)
        {
            HttpWebRequest httprequest;
            HttpWebResponse httpresponse;
            StreamReader bodyreader;
            string bodytext = "";
            Stream responsestream;
            Stream requestStream;
            httprequest = (HttpWebRequest)WebRequest.Create(szURL);
            httprequest.Method = "POST";
            httprequest.ContentType =
            "text/plain";
            httprequest.ContentLength = szPost.Length;
            requestStream = httprequest.GetRequestStream();
            requestStream.Write(Encoding.ASCII.GetBytes(szPost), 0,
            szPost.Length);
            requestStream.Close();
            httpresponse = (HttpWebResponse)httprequest.GetResponse();
            responsestream = httpresponse.GetResponseStream();
            bodyreader = new StreamReader(responsestream);
            bodytext = bodyreader.ReadToEnd();
            return bodytext;
        }

        private string getHTML(string szURL)
        {
            // Create a request for the URL.
            WebRequest request = WebRequest.Create(textBox1.Text);
            // Get the response. 
            WebResponse response = request.GetResponse();
            // Get the stream containing content returned by the server. 
            Stream dataStream = response.GetResponseStream();
            // Open the stream using a StreamReader for easy access. 
            StreamReader reader = new StreamReader(dataStream);
            // Read the content. 
            string responseFromServer = reader.ReadToEnd();
            // Close the response. 
            response.Close();
            return responseFromServer;
        }

        private void Lab4_bai2_Load(object sender, EventArgs e)
        {

        }
    }
}