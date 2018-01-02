using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C51_control
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            My_init();
        }
        private void My_init()
        {
            Scomcbox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
            if(Scomcbox.Items.Count>0)
                Scomcbox.SelectedIndex= 0;

            BTcbox.Items.AddRange(new object [] {"9600", "4800" });
            BTcbox.SelectedIndex = 0;

            Datacbox.Items.AddRange(new object[] { "8", "7", "6" });
            Datacbox.SelectedIndex = 0;

            JYcbox.Items.AddRange(new object[] { "Even", "Mark", "None", "Odd", "Space" });
            JYcbox.SelectedIndex = 2;
            JYcbox.Enabled = false;

            Stopcbox.Items.AddRange(new object[] { "1", "2" });
            Stopcbox.SelectedIndex = 0;
        }
        bool Senddata(byte[] data) {
            try
            {
                serialPort1.Write(data, 0, data.Length);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        byte[] Light = { 0x55, 0x00 };
        bool[] Lstat = { false, false, false, false, false, false, false, false };
        private void Light_Click(object sender, EventArgs e)
        {
            PictureBox Btn = (PictureBox)sender;
            int key = Convert.ToInt32(Btn.Tag.ToString())-1;
            Light[1] ^= Convert.ToByte(0x01<<key);
            if (Senddata(Light))
            {
                Btn.Image = Lstat[key] ? C51_control.Properties.Resources._562803 : C51_control.Properties.Resources._562419;
                Lstat[key] = !Lstat[key];
            }               
        }
        private void SwitchBtn_Click(object sender, EventArgs e)
        {
            if (!serialPort1.IsOpen)
            {
                serialPort1.PortName = Scomcbox.SelectedItem.ToString();
                serialPort1.BaudRate = Convert.ToInt32(BTcbox.SelectedItem.ToString());
                serialPort1.DataBits = Convert.ToInt32(Datacbox.SelectedItem.ToString());
                //serialPort1.Parity = (System.IO.Ports.Parity)Convert.ToInt32(JYcbox.SelectedItem.ToString());
                serialPort1.Parity = System.IO.Ports.Parity.None;
                serialPort1.StopBits = (System.IO.Ports.StopBits)Convert.ToInt32(Stopcbox.SelectedItem.ToString());
                try
                {
                    serialPort1.Open();
                    switchBtn.Image = C51_control.Properties.Resources._1131027;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                serialPort1.Close();
                switchBtn.Image = C51_control.Properties.Resources._1131028;
            }
        }

        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControl1.SelectedIndex == 1)
            {
                if (!Senddata(Light))
                    MessageBox.Show("请连接串口", "Error", MessageBoxButtons.OK);
            }
            if (tabControl1.SelectedIndex == 2)
            {
                if (!Senddata(new byte[] { 0xaa, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0 }))
                {
                    MessageBox.Show("请连接串口", "Error", MessageBoxButtons.OK);
                }
                NumView.Text = "000000";
            }
            if (tabControl1.SelectedIndex == 3)
            {
                sdata[1] = 0x00;
                if (!Senddata(sdata))
                    MessageBox.Show("请连接串口", "Error", MessageBoxButtons.OK);
                pictureBox1.Image = C51_control.Properties.Resources._1200695;
            }
        }
        //byte[] num = { 0x40, 0x79, 0x24, 0x30, 0x19, 0x12, 0x02, 0x78, 0x00, 0x10 };
        byte[] num = { 0xc0, 0xf9, 0xa4, 0xb0, 0x99, 0x92, 0x82, 0xf8, 0x80, 0x90 };
        private void Button1_Click(object sender, EventArgs e)
        {
            byte[] ndata = { 0xaa, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0, 0xc0 };
            String input = maskedTextBox1.Text;
            int index = input.Length - 1;
            for (int i = ndata.Length - 1; i > 0; i--)
            {
                ndata[i] = num[Convert.ToInt32(input[index].ToString())];
                index--;
                if (index < 0)
                    break;
            }
            if (Senddata(ndata))
                NumView.Text = input;
        }
        byte[] sdata = { 0xa5, 0x00 };
        private void PictureBox1_Click(object sender, EventArgs e)
        {
            sdata[1] ^= Convert.ToByte(0x01 << 6);
            if (Senddata(sdata))
                pictureBox1.Image = sdata[1] == 0x00 ? C51_control.Properties.Resources._1200695 : C51_control.Properties.Resources._1200696;
        }
        byte[] jdata = { 0x5a, 0x00 };
        private void PictureBox2_Click(object sender, EventArgs e)
        {
            jdata[1] ^= Convert.ToByte(0x01);
            if (Senddata(jdata))
                Jstat.Text = jdata[1] == 0x00 ? "off" : "on";
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Scomcbox.Items.AddRange(System.IO.Ports.SerialPort.GetPortNames());
        }
    }

}
