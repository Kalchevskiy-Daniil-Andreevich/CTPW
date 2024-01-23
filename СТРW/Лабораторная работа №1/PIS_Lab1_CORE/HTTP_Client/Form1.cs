using System;
using System.Net.Http;
using System.Text;
using System.Windows.Forms;

namespace HTTP_Client
{
    public partial class Form1 : Form
    {
        private readonly HttpClient httpClient; 

        public Form1()
        {
            InitializeComponent();
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://localhost:5044");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void button1_Click(object sender, EventArgs e)
        {
            double x, y;

            if (double.TryParse(textBox1.Text, out x) && double.TryParse(textBox2.Text, out y))
            {
                var request = new { X = x, Y = y };
                var jsonRequest = Newtonsoft.Json.JsonConvert.SerializeObject(request);
                var content = new StringContent(jsonRequest, Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync("api/calculator/add", content);

                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    textBox3.Text = result;
                }
                else
                {
                    textBox3.Text = "Ошибка при выполнении запроса.";
                }
            }
            else
            {
                textBox3.Text = "Неверный формат чисел X и/или Y.";
            }
        }
    }
}
