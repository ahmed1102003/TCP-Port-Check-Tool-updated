using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TCP_Check_Port_tool07
{
    public partial class Form1 : Form
    {
        static Socket s;

        List<int> portlist = new List<int>();
           
        public Form1()
        {
            InitializeComponent();
            txtportnumber.MaxLength = 5;
        }

 
         

        private void txtipaddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtportnumber_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtipaddress.Text == "" )
            {
                MessageBox.Show("Error , Please enter IP address and port Number");
                return;
            }
            else 
            {
                //get the ip or host name and save it in String var
                string pattern = @"\d\d?\d?\.\d\d?\d?\.\d\d?\d?\.\d\d?\d?";
                Regex regex = new Regex(pattern);
                 Match match = regex.Match(txtipaddress.Text);

                if (match.Success == false)
                {
                 txtipaddress.Text =   Dns.GetHostEntry(txtipaddress.Text).AddressList[0].ToString();
                }

            }

            if (txtportnumber.Text == "" || portlist.Count== 0)
            {
                MessageBox.Show("Error , Please add port Number or select one of the check list ");
                return;
            }

            

            if (txtportnumber.Text != "")
            {

                portlist.Add(Convert.ToInt32(txtportnumber.Text));
            }
            
            foreach(int i in portlist)
            {

                opensocketforhttp(i);

            }
            portlist.Clear();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
           if (httpcheckbox.Checked == true)
            {
                portlist.Add(80);
            }
            else
            {
                portlist.Remove(80);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
           if( httpscheckbox.Checked == true)
            {
                portlist.Add(443);
            }
           else
            {
                portlist.Remove(443);
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (restcheckbox.Checked == true)
            {
                portlist.Add(9080);
            }
            else
            {
                portlist.Remove(9080);
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if(ippscheckbox.Checked == true)
            {
                portlist.Add(613);
            }
            else{

                portlist.Remove(613);
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            ldpcheckbox.Checked = true;
        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {
            ippcheckbox.Checked = true;
        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {
            ftpcheckbox.Checked = true;
        }

        private void httpresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void httpsresult_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ippsresult_TextChanged(object sender, EventArgs e)
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

        private void button2_Click(object sender, EventArgs e)
        {
          

        }



        private void opensocketforhttp(int x)

        {


            String ip = txtipaddress.Text;
            Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            IPEndPoint localEndPoint = new IPEndPoint(IPAddress.Parse(ip), x);

            try
            {
                s.Connect(localEndPoint);

                switch (x)
                {
                    case 80:
                        httpresult.Text = "HTTP Connection is ok using port =  " + x;
                        break;

                    case 443:
                        httpsresult.Text = "HTTPS Connection is ok using port =  " + x;
                        break;

                    case 9080:
                        restresult.Text = "REST Connection is ok using port =  " + x;
                        break;

                    case  613:
                        ippresult.Text = "IPP Connection is ok using port =  " + x;
                        break;

                }
                   
            }

            catch (Exception ex)
            {
                switch (x)
                {
                    case 80:
                        httpresult.Text = "HTTP Erro Connection using port =  " + x;
                        break;

                    case 443:
                        httpsresult.Text = "HTTPS Error Connection using port =  " + x;
                        break;

                    case 9080:
                        restresult.Text = "REST Error Connection using port =  " + x;
                        break;

                    case 613:
                        ippresult.Text = "IPP Error Connection using port =  " + x;
                        break;

                }
            }
            finally
            {
                s.Close();
            }


        }

        private void button2_Click_1(object sender, EventArgs e)
        {
           

            txtipaddress.Clear();
            txtportnumber.Clear();
            httpresult.Clear();
            httpcheckbox.Checked = false;

        }
    }
}
