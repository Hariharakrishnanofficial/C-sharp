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
using System.Linq.Expressions;
using System.Net;
using System.Reflection;
using System.Web;
using System.Windows;
using CefSharp;
using CefSharp.WinForms;
using System.Threading;

namespace servo_tracker
{
    public partial class Form1 : Form
    {
        int position0, position1, a, b, c, forward, backward, stop, right, left, on,Click=0;
        public Form1()
        {
            this.KeyPreview = true;
            InitializeComponent();
            //if (forwardClick||backward_Click\\)
            //{
              //  serialPort1.WriteLine("-5");//led
            //}
            
        }
        
        public CefSharp.WinForms.ChromiumWebBrowser browser;
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports) ;
            comboBox1.Items.Add(ports);
            trackBar1.Minimum = 1;
            trackBar1.Maximum = 180;
            //(http://192.168.43.206/)
            browser = new CefSharp.WinForms.ChromiumWebBrowser("https://google.com/");
            {
                Dock = DockStyle.Fill;
                Size = new Size(600, 600);
                Location = new Point(200, 200);
            };
            this.panel1.Controls.Add(browser);
            Thread.Sleep(10000);
        }


        private void SEND_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.PortName = comboBox1.Text;
                    serialPort1.BaudRate = 115200;
                    serialPort1.Parity = Parity.None;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Open();
                    label1.Text = "START";
                    label1.ForeColor = System.Drawing.Color.Green;
                    SEND.Text = "start";
                }
                else
                {
                    label1.Text = "ERROR";
                    label1.ForeColor = System.Drawing.Color.Red;
                    SEND.Text = "ERROR";
                    serialPort1.Close();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }
        private void write_angle(int value)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(value.ToString());
                    DEGREE.Text = "action" + value.ToString() + "'";
                }
            }
            catch (Exception ex2)
            {
                MessageBox.Show(ex2.Message, "READY");
            }
        }

        private void write_angle1(int value1)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.WriteLine(value1.ToString());
                    label3.Text = "action" + value1.ToString() + "'";
                }
            }
            catch (Exception ex3)
            {
                MessageBox.Show(ex3.Message, "READY");
            }
        }
        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            position1 = trackBar2.Value;
            write_angle1(position1);
        }

        private void ON_Click(object sender, EventArgs e)
        {        
              serialPort1.WriteLine("-8");
        }

        private void OFF_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-9");
        }

        

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                //MessageBox.Show("ff");
                f.PerformClick();
            }
            if (e.KeyCode == Keys.A)
            {
                //MessageBox.Show("rr");
                rr.PerformClick();
            }
            
            if (e.KeyCode == Keys.D)
            {
                //MessageBox.Show("ll");
                lll.PerformClick();
            }
            if (e.KeyCode == Keys.S)
            {
                //MessageBox.Show("ss");
               bb.PerformClick();
            }
            if(e.KeyCode==Keys.O)
            {
                ON.PerformClick();
            }
            if(e.KeyCode == Keys.Q )
            {
                serialPort1.Write("-6");
            }
            if (e.KeyCode == Keys.E)
            {
                serialPort1.Write("-7");
            }
        }

        private void f_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-3");
        }

        private void ss_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-5");
        }

        private void rr_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-1");
        }

        private void lll_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-2");
        }

        private void bb_Click(object sender, EventArgs e)
        {
            serialPort1.WriteLine("-4");
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                OFF.PerformClick();
            }
            if (e.KeyCode == Keys.W)
            {
                ss.PerformClick();
              //  MessageBox.Show("ss");
            }
            if (e.KeyCode == Keys.A)
            {
            //    MessageBox.Show("ss");
                ss.PerformClick();
            }

            if (e.KeyCode == Keys.D)
            {
          //      MessageBox.Show("ss");
                ss.PerformClick();
            }
            if (e.KeyCode == Keys.S)
            {
        //        MessageBox.Show("ss");
                ss.PerformClick();
            }
            if (e.KeyCode == Keys.E)
            {
           //     MessageBox.Show("w and d");
                ss.PerformClick();
                //lll.PerformClick();
            }
            if (e.KeyCode == Keys.Q )
            {
         //       MessageBox.Show(" w and a");
                ss.PerformClick();
                //rr.PerformClick();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try 
            {
                if (0 == Click)
                {
                    serialPort1.WriteLine("999");
                    Click++;
                }
                else if (Click == 1) 
                {
                    serialPort1.WriteLine("X");
                    Click--;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "error");
            }
        }

        private void ON_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                serialPort1.WriteLine("-8");
                //      on++;
            }
        }

        private void ON_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.O)
            {
                    serialPort1.WriteLine("-9");
              //      on++;
            }
            /*else//(on==1)
             {
                serialPort1.WriteLine("-9");
                on--;
            }

            if(e.KeyCode == Keys.P)
            {
                serialPort1.WriteLine("-9");

            }*/
        }

        private void forwardClick(object sender, EventArgs e)
        {
            if(forward==0)
            {
//                serialPort1.Open();
                serialPort1.WriteLine("-3");//led
 //              serialPort1.Close();
                forward++;
            }
            else
            {
                serialPort1.WriteLine("-5");
                forward--;
            }
            /*        catch(Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }*/

        }

        private void backward_Click(object sender, EventArgs e)
        {

          if(backward==0)
            {
                serialPort1.WriteLine("-4");//led
                backward++;
            }
            else
            {
                serialPort1.WriteLine("-5");
                backward--;
            }
            /*catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }*/

        }
       
        private void SEARCH_Click(object sender, EventArgs e)
        {
         //   webBrowser1.Navigate(textBox1.Text);
            browser.Load(textBox1.Text);
        }
  


        private void RIGHT_Click(object sender, EventArgs e)
        {
            if(right==0)
            {
                serialPort1.WriteLine("-1");//led
                right++;
                
            }
            else//(right==1)
            {
                serialPort1.WriteLine("-5");
                right--;
            }
            /* catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }   */
        }

        private void LEFT_Click(object sender, EventArgs e)
        {
            if(left==0)
            {
                serialPort1.WriteLine("-2");//led
                left++;
            }
            else
            {
                serialPort1.WriteLine("-5");
                left--;
            }
//            catch (Exception ex)
  //          {
      //          MessageBox.Show(ex.Message);
    //        }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_ControlAdded(object sender, ControlEventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            position0 = trackBar1.Value;
            write_angle(position0);
        }
    }
    
}
