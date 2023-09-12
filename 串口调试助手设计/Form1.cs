using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Text;
using System.Windows.Forms;

namespace 串口调试助手设计
{
    public partial class Form1 : Form
    {
        private bool isOpen = false;

        private bool isRxShow = true;

        private List<byte> reciveBuffer = new List<byte>();//做发送缓存

        private List<byte> sendBuffer = new List<byte>();//做接受缓存

        private int reciveCount = 0;//计数接收的数据

        private int sendCount = 0;//计数发送的数据
        public Form1()
        {
            InitializeComponent();

            Control.CheckForIllegalCrossThreadCalls = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)//自动清空
        {
            if (autoclear_chb.Checked)
            {
                timer1.Start();
            }
            else
            {
                timer1.Stop();
            }
          //  recive_rtb.Text.Length
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void open_btn_Click(object sender, EventArgs e)
        {
            try
            {
                if(serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = port_cbb.Text;
                    serialPort1.BaudRate = Convert.ToInt32(baud_cbb.Text);
                    serialPort1.DataBits = Convert.ToInt32(databit_cbb.Text);
                    switch (check_cbb.SelectedIndex)
                    {
                        // none odd even
                        case 0:
                            serialPort1.Parity = Parity.None;
                            break;
                        case 1:
                            serialPort1.Parity = Parity.Odd;
                            break;
                        case 2:
                            serialPort1.Parity = Parity.Even;
                            break;
                        default:
                            break;
                    }
                    switch (stopbit_cbb.SelectedIndex)
                    {
                        // 1 1.5 2
                        case 0:
                            serialPort1.StopBits = StopBits.One; break; 
                        case 1: 
                            serialPort1.StopBits = StopBits.OnePointFive; break;
                        case 2:
                            serialPort1.StopBits = StopBits.Two; break;
                        default:
                            serialPort1.StopBits = StopBits.One; break;
                    }

                    serialPort1.Open();
                    isOpen = true;
                    open_btn.Text = "关闭串口";
                }
                else
                {
                    serialPort1.Close();
                    isOpen = false;
                    open_btn.Text = "打开串口";
                }
                //if(port_cbb.Text!=null)
                //{
                //    serialPort1.PortName = port_cbb.Text;
                //}
                //serialPort1.Open();
                //if (serialPort1.IsOpen)
                //{
                //    MessageBox.Show("serialport is open");
                //}
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString() + serialPort1.PortName.ToString());
            }
        }

        private void port_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ///*-------------数据初始化------------*/
            //  this.port_cbb.SelectedIndex = 0;//端口

            //  this.baud_cbb.SelectedIndex = 1;//波特率

            //  this.check_cbb.SelectedIndex = 0;//校验位

            //  this.databit_cbb.SelectedIndex = 3;//数据位

            //  this.stopbit_cbb.SelectedIndex = 0;//停止位
            serialLoad();
        }

        private void serialLoad()
        {
            RegistryKey keyCom = Registry.LocalMachine.OpenSubKey(@"Hardware\DeviceMap\SerialComm");

            string[] sSubKeys = keyCom.GetValueNames();
            port_cbb.Items.Clear();
            foreach (var sValue in sSubKeys)
            {
                string portName = (string)keyCom.GetValue(sValue);
                port_cbb.Items.Add(portName);
            }

            /*-------------数据初始化------------*/
            this.port_cbb.SelectedIndex = 0;//端口

            this.baud_cbb.SelectedIndex = 0;//波特率

            this.check_cbb.SelectedIndex = 0;//校验位

            this.databit_cbb.SelectedIndex = 3;//数据位

            this.stopbit_cbb.SelectedIndex = 0;//停止位
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void baud_cbb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void sendData()
        {
            serialPort1.Write(sendBuffer.ToArray(),0,sendBuffer.Count);//数据发送
            sendCount += sendBuffer.Count;
            sendcount_tssl.Text = sendCount.ToString();
        }
        private void send_btn_Click(object sender, EventArgs e)
        {
            //if(this.send_rtb.Text != "" && serialPort1.IsOpen)
            //{
            //    Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
            //    sendData();
            //}
            //else 
            //{
            //    MessageBox.Show("请输入发送数据！");
            //}

            if (this.send_rtb.Text == "")
            {
                MessageBox.Show("请输入发送数据！");
            }
            else if(!serialPort1.IsOpen)
            {
                MessageBox.Show("请打开串口调试助手！");
            }
            else
            {
                
                Console.WriteLine(Transform.ToHexString(sendBuffer.ToArray()));
                sendData();
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)//数据接收
        {
            if (isRxShow == false) return;
            byte[] dataTemp = new byte[serialPort1.BytesToRead];
            serialPort1.Read(dataTemp, 0, dataTemp.Length);//读取串口数据
            reciveBuffer.AddRange(dataTemp);//存入缓存区

            reciveCount += dataTemp.Length;//计算长度

            /*-------------异步线程更新------------*/

            this.Invoke(new EventHandler(delegate
            {
                //显示接收数据长度
                recivecount_tssl.Text=reciveCount.ToString();

                if(!recivehex_chb.Checked)//检测是否勾选十六进制
                {
                  string str = Encoding.GetEncoding("gb2312").GetString(dataTemp);
//                    string str = Encoding.GetEncoding("utf8").GetString(dataTemp);
                    // 0x00 -> \0 结束 不会显示
                    str =str.Replace("\0", "\\0");

                    recive_rtb.AppendText(str);//将文本追加至接收区
                }
                else
                {
                    //勾选了十六进制
                    recive_rtb.AppendText(Transform.ToHexString(dataTemp, " "));//直接转化为十六进制字符串
                    
                }
                
            }
                ));
            //string dataRecive = serialPort1.ReadExisting();
            //recive_rtb.AppendText(dataRecive);
        }

        private void stop_btn_Click(object sender, EventArgs e)
        {
            if(isRxShow == true) 
            { 
                isRxShow = false;
                stop_btn.Text = "取消暂停";
            }
            else
            {
                isRxShow = true;
                stop_btn.Text = "暂停";
            }
        }

        private void recive_rtb_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void send_rtb_TextChanged(object sender, EventArgs e)//发送区文本改变时
        {
            //十六进制切换会出现问题 0X00转换
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void recivehex_chb_CheckedChanged(object sender, EventArgs e)//十六进制切换
        {
            if(recive_rtb.Text == null) return;//接收文本框中无数据，直接退出。
            if(recivehex_chb.Checked) 
            {
                recive_rtb.Text = Transform.ToHexString(reciveBuffer.ToArray(), " ");//显示十六进制字符串
            }
            else
            {
                recive_rtb.Text = Encoding.GetEncoding("gb2312").GetString(reciveBuffer.ToArray()).Replace("\0","\\0");//将buffer缓存区的内容以字符形式显示出来
//                recive_rtb.Text = Encoding.GetEncoding("utf8").GetString(reciveBuffer.ToArray()).Replace("\0", "\\0");//将buffer缓存区的内容以字符形式显示出来
            }
        }

        private void clear_btn_Click(object sender, EventArgs e)//手动清空
        {
            reciveBuffer.Clear();//清空缓存区
            reciveCount = 0;
            recivecount_tssl.Text = "0";
            recive_rtb.Text= null;//清空接收区内容
        }

        private void timer1_Tick(object sender, EventArgs e)//计时器自动清空
        {
            if(recive_rtb.Text.Length >= 4096)
            {
                reciveBuffer.Clear();
                recive_rtb.Text = null;
                reciveCount = 0;
                recivecount_tssl.Text = "0";
            }
        }

        private void send_rtb_Leave(object sender, EventArgs e)//发送区焦点离开后触发
        {
            if(sendhex_chb.CheckState == CheckState.Checked)
            {
                if (DataEncoding.IsHexString(send_rtb.Text.Replace(" ", "")))//判断是否是正确的十六进制数据
                {
                    sendBuffer.Clear();
                    sendBuffer.AddRange(Transform.ToBytes(send_rtb.Text.Replace(" ", "")));//传入数据并做数据转换（替换空格，转换为Bytes数据，添加至缓存区）
                }
                else
                {
                    MessageBox.Show("请输入正确的十六进制数据！");
                    send_rtb.Select();//光标返回至窗体
                }
            }
            else
            {
                sendBuffer.Clear();
                sendBuffer.AddRange(Encoding.GetEncoding("gb2312").GetBytes(send_rtb.Text));//将字符串以gb2312的编码格式转换为Bytes数据并存人缓存区
            }
        }

        private void sendhex_chb_CheckedChanged(object sender, EventArgs e)//勾选十六进制后
        {
            if (send_rtb.Text == null) return;
            if(sendhex_chb.Checked ==true) 
            {
                send_rtb.Text = Transform.ToHexString(sendBuffer.ToArray()," ");
            }
            else
            { 
                send_rtb.Text = Encoding.GetEncoding("gb2312").GetString(sendBuffer.ToArray()).Replace("\0","\\0");

            }
        }

        private void sendclear_btn_Click(object sender, EventArgs e)
        {
            sendBuffer.Clear();

            send_rtb.Text=null;

            sendCount = 0;

            sendcount_tssl.Text = "0";
        }
    }
}
