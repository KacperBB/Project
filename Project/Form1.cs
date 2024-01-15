using System;
using System.Diagnostics;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Project
{
    [DebuggerDisplay("{" + nameof(GetDebuggerDisplay) + "(),nq}")]
    public partial class Form1 : Form
    {
        SerialPort mySerialPort;
        Timer myTimer;
        bool isTestingMode = false; // New field to track testing mode


        public Form1()
        {
            InitializeComponent();
            InitializeTimer();
            bool isTestingMode = false; // New field to track testing mode
        }

        private void InitializeTimer()
        {
            myTimer = new Timer();
            myTimer.Tick += new EventHandler(TimerEventProcessor);
            myTimer.Interval = 2000; // Set interval in milliseconds
            myTimer.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Initialize the COM ports list
            string[] ports = SerialPort.GetPortNames();
            comListener.Items.AddRange(ports);
            if (comListener.Items.Count > 0)
                comListener.SelectedIndex = 0; // Select the first port by default
            else
                MessageBox.Show("No COM ports found.");

            // Initialize the SerialPort object
            SetupSerialPort();
        }


        private void SetupSerialPort()
        {
            mySerialPort = new SerialPort();
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadLine(); // Read one line of data
            Invoke(new Action(() =>
            {
                // Split the data into label and value
                string[] parts = indata.Split(':');
                if (parts.Length != 2) return; // Skip if the data is not in expected format

                string label = parts[0].Trim();
                string value = parts[1].Trim();

                // Parse the value to the appropriate data type (int, double, etc.)
                if (!double.TryParse(value, out double numericValue))
                    return; // Skip if the value is not a number

                // Update the corresponding text box and chart based on the label
                switch (label)
                {
                    case "Wind Direction":
                        textBoxWindDirection.Text = value;
                        UpdateChart(winddirectionchart, numericValue);
                        break;
                    case "Wind Speed":
                        textBoxWindSpeed.Text = value;
                        UpdateChart(windspeedchart, numericValue);
                        break;
                    case "Temperature":
                        textBoxTemperature.Text = value;
                        UpdateChart(temperaturechart, numericValue);
                        break;
                    case "Dew Point":
                        textBoxDewPoint.Text = value;
                        UpdateChart(dewpointchart, numericValue);
                        break;
                    case "QNH":
                        textBoxQNH.Text = value;
                        UpdateChart(qnhchart, numericValue);
                        break;
                }
            }));
        }

        private void UpdateChart(Chart chart, double value)
        {
            // Add new value to the chart's series
            chart.Series[0].Points.AddY(value);

            // Optionally, adjust the chart's view to maintain a certain range or limit
            // For example, keeping the last 20 points visible:
            while (chart.Series[0].Points.Count > 20)
                chart.Series[0].Points.RemoveAt(0);

            chart.Invalidate(); // Refresh the chart
        }

        private void WriteToFile(string fileName, string text)
        {
            string folderPath = AppDomain.CurrentDomain.BaseDirectory; // Or specify your path
            string filePath = Path.Combine(folderPath, fileName);

            using (StreamWriter sw = new StreamWriter(filePath, true)) // Append to the file
            {
                sw.WriteLine(DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss") + ": " + text);
            }
        }

        private void TimerEventProcessor(Object myObject, EventArgs myEventArgs)
        {
            if (isTestingMode)
            {
                // Generate random data for testing
                Random random = new Random();
                double windDirectionValue = random.Next(0, 360);
                double windSpeedValue = random.Next(0, 100);
                double temperatureValue = random.Next(-10, 35);
                double dewPointValue = random.Next(-10, 25);
                double qnhValue = random.Next(950, 1050);

                UpdateChart(winddirectionchart, windDirectionValue);
                UpdateChart(windspeedchart, windSpeedValue);
                UpdateChart(temperaturechart, temperatureValue);
                UpdateChart(dewpointchart, dewPointValue);
                UpdateChart(qnhchart, qnhValue);

                // Update text boxes with random values
                // Ensure the text box names match these
                textBoxWindDirection.Text = windDirectionValue.ToString();
                textBoxWindSpeed.Text = windSpeedValue.ToString();
                textBoxTemperature.Text = temperatureValue.ToString();
                textBoxDewPoint.Text = dewPointValue.ToString();
                textBoxQNH.Text = qnhValue.ToString();

                statusLabel.Text = "Generating random DATA";
            }
            else
            {
                // Perform regular checks or UI updates
                statusLabel.Text = "Listening to Serial Port...";
            }
        }



        private string GetDebuggerDisplay()
        {
            return ToString();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            if (mySerialPort != null && mySerialPort.IsOpen)
            {
                mySerialPort.Close();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chart1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart2_Click(object sender, EventArgs e)
        {

        }

        private void chart3_Click(object sender, EventArgs e)
        {

        }

        private void chart4_Click(object sender, EventArgs e)
        {

        }

        private void chart5_Click(object sender, EventArgs e)
        {

        }

        private void onbutton_Click(object sender, EventArgs e)
        {
            isTestingMode = false; // Set to real mode
            if (!mySerialPort.IsOpen)
            {
                try
                {
                    mySerialPort.PortName = comListener.SelectedItem.ToString(); // Set the port name to the selected item
                    mySerialPort.Open(); // Try to open the selected serial port
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error opening serial port: " + ex.Message);
                }
            }
        }

        private void offbutton_Click(object sender, EventArgs e)
        {
            isTestingMode = true; // Set to testing mode
            if (mySerialPort.IsOpen)
            {
                mySerialPort.Close(); // Close the serial port
            }
        }

        private void comListener_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
