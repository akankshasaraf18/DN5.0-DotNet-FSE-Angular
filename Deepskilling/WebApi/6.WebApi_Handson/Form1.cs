using System;
using System.Windows.Forms;
using Confluent.Kafka;
using System;
using System.Windows.Forms;
namespace KafkaChatApp
{
    public partial class Form1 : Form
    {
        private readonly ProducerConfig config = new ProducerConfig
        {
            BootstrapServers = "localhost:9092"
        };
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Enter a message.");
                return;
            }

            using (var producer = new ProducerBuilder<Null, string>(config).Build())
            {
                try
                {
                    var result = await producer.ProduceAsync(
                        "employee-topic",
                        new Message<Null, string>
                        {
                            Value = textBox1.Text
                        });

                    listBox1.Items.Add("Sent : " + textBox1.Text);

                    MessageBox.Show("Message Sent Successfully!");

                    textBox1.Clear();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}