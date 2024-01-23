using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace Client_HTTP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox1.Text);
            double y = double.Parse(textBox2.Text);

            var request = new { X = x, Y = y };
            var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(request);
            var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/calculator/add", content);

            var result = await response.Content.ReadAsStringAsync();
            resultTextBox.Text = result;
        }
    }
}