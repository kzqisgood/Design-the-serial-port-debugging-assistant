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
        public Form1()
        {
            InitializeComponent();
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

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

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
          /*-------------数据初始化------------*/
            this.port_cbb.SelectedIndex = 0;//端口
            
            this.baud_cbb.SelectedIndex = 1;//波特率
            
            this.check_cbb.SelectedIndex = 0;//校验位

            this.databit_cbb.SelectedIndex = 3;//数据位

            this.stopbit_cbb.SelectedIndex = 0;//停止位
        }
    }
}
