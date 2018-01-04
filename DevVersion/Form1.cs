using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace DevVersion
{
    public partial class mainForm : Form
    {
        private SerialPort serial;
        private const string DEV_NAME = "Inn";

        private void CommunicationInit()
        {
            var ports = SerialPort.GetPortNames();
            var devPort = "";

            foreach(var port in ports)
            {
                if (port.Contains(DEV_NAME))
                {
                    devPort = port;
                    break;
                }
            }

            if (!string.IsNullOrEmpty(devPort))
            {
                serial = new SerialPort();
                serial.PortName = devPort;
                serial.BaudRate = 9600;
                serial.ReadTimeout = 100;
                serial.WriteTimeout = 100;
                serial.Open();
                btnGetVer.Enabled = true;
            }
        }

        public mainForm()
        {
            InitializeComponent();
        }

        private void btnGetVer_Click(object sender, EventArgs e)
        {
            byte[] tx = {0x1b, 0x52}; // ESC R
            
            try
            {
                serial.Write(tx, 0, tx.Length);
                labVer.Text = serial.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            CommunicationInit();
        }
    }
}
