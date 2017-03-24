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
using System.Threading;

namespace SerialPortWinFormVersion
{
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            InitializeCOMCombox();
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            mySerialPort.Encoding = System.Text.Encoding.GetEncoding("GB2312");//解决中文乱码
        }

        private void InitializeCOMCombox()
        {
            #region 波特率
            //int[] baud = new int[] { 4800, 9600 };
            //BaudRate.Items.AddRange();
            //BaudRate.Items.Add(4800);
            //BaudRate.Items.Add(9600);
            //BaudRate.Items.Add(19200);
            //BaudRate.Items.Add(38400);
            //BaudRate.Items.Add(57600);
            //BaudRate.Items.Add(115200);
            BaudRate.Text = BaudRate.Items[BaudRate.Items.Count - 1].ToString();
            #endregion

            #region 数据位
            //DataBits.Items.Add(7);
            //DataBits.Items.Add(8);
            DataBits.Text = DataBits.Items[DataBits.Items.Count - 1].ToString();
            #endregion

            #region 停止位
            //Stop.Items.Add(1);
            //Stop.Items.Add(1.5);
            //Stop.Items.Add(2);
            Stop.Text = Stop.Items[0].ToString();
            #endregion

            #region　奇偶校验
            Parity.Text = Parity.Items[0].ToString();
            #endregion

            #region 端口号
            string[] ArrayComPortsNames = System.IO.Ports.SerialPort.GetPortNames();
            if (ArrayComPortsNames.Length == 0)
            {
                //statuslabel.Text = "No COM found !";
                ConnectBtn.Enabled = false;
            }
            else
            {
                Array.Sort(ArrayComPortsNames);
                for (int i = 0; i < ArrayComPortsNames.Length; i++)
                {
                    PortName.Items.Add(ArrayComPortsNames[i]);
                }
                PortName.Text = ArrayComPortsNames[0];
                ConnectBtn.Enabled = true;
            }
            #endregion
        }

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            //_myserialPort = new SerialPort(PortName.Text, Convert.ToInt16(BaudRate.Text),0, Convert.ToInt16(DataBits.Text),StopBits.One);
            mySerialPort.PortName = PortName.Text;
            mySerialPort.BaudRate = Convert.ToInt32(BaudRate.Text);
            mySerialPort.DataBits = int.Parse(DataBits.Text);
            mySerialPort.StopBits = (StopBits)Enum.Parse(typeof(StopBits), Stop.Text, true);
            mySerialPort.Parity = (Parity)Enum.Parse(typeof(Parity), Parity.Text, true);
            mySerialPort.Open();
            //if (mySerialPort.IsOpen)
            //    DataReceiveBox.Text = "11";

            ConnectBtn.Enabled = false;
            DiscntBtn.Enabled = true;
            SendDataBtn.Enabled = true;
        }

        private void DiscntBtn_Click(object sender, EventArgs e)
        {
            mySerialPort.Close();
            //if (!mySerialPort.IsOpen)
            //    DataSBox.Text = "22";
            ConnectBtn.Enabled = true;
            DiscntBtn.Enabled = false;
            SendDataBtn.Enabled = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mySerialPort.DataReceived += new SerialDataReceivedEventHandler(Port_DataReceived);
        }

        private void Port_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {

            string str = mySerialPort.ReadExisting();//字符串方式读
            DataRBox.AppendText(str);//添加内容
        }

        private void SendDataBox_Click(object sender, EventArgs e)
        {
            //byte[] Data = new byte[1];//作用同上集
            if (mySerialPort.IsOpen)//判断串口是否打开，如果打开执行下一步操作
            {
                if (DataSBox.Text != "")
                {
                    try
                    {
                        mySerialPort.WriteLine(DataSBox.Text + "\r\n");
                        /*byte[] data = Encoding.Unicode.GetBytes(DataSBox.Text);
                        string str = Convert.ToBase64String(data);
                        if (newLineChkBox.Checked)
                        {
                            str = str + "\r\n";
                        }
                        mySerialPort.WriteLine(str);*/
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("串口数据写入错误", "错误");//出错提示
                        mySerialPort.Close();
                        ConnectBtn.Enabled = true;//打开串口按钮可用
                        DiscntBtn.Enabled = false;//关闭串口按钮不可用
                    }
                }
            }
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            DataRBox.Text = "";
        }
    }
}
