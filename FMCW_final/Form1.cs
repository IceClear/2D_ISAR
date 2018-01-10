using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CCWin;
using System.Diagnostics;
using MathWorks.MATLAB.NET.Arrays;
using MathWorks.MATLAB.NET.Utility;
using System.Threading;
using IronPython.Hosting;
using Microsoft.Scripting.Hosting;
using System.Net;
using System.Net.Sockets;
using System.Windows;
using System.IO;
using ISARtest;

namespace FMCW_final
{
    public partial class MainF : Skin_Mac
    {
        System.Timers.Timer t;
        Thread keyDetectThread;
        UdpServerOfKeyDetecter keyDetecter;
        public MainF()
        {
            InitializeComponent();
            t = new System.Timers.Timer();//实例化Timer类，设置时间间隔
        }

        Pen p = new Pen(Color.Red, 2);//定义了一个蓝色,宽度为的画笔
        private void Form1_Load(object sender, EventArgs e)
        {
            //FlashBox.Movie = Application.StartupPath + "\\FMCW.swf";
            //Bitmap bitmap = new Bitmap(this.oscil.Width, this.oscil.Height);
            //Graphics g = Graphics.FromImage(bitmap);
            //oscil.Image = bitmap;

        }
        private void skinCode1_Click(object sender, EventArgs e)
        {

        }

        private void skinAlphaWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void skinWaterTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void lab_Click(object sender, EventArgs e)
        {

            ISARtest.ISAR isar = new ISAR();
            MWArray i1 = 0;
            MWArray i2 = 3;
            MWArray r1 = 15;
            MWArray r2 = 12;
            MWArray thr = 0.2;

            try {
                 i1 = Convert.ToInt32(a_box.Text);
                 i2 = Convert.ToInt32(b_box.Text);
                 r1 = Convert.ToInt32(c_box.Text);
                 r2 = Convert.ToInt32(d_box.Text);
                 thr = float.Parse(e_box.Text);
            }
            catch
            {
                //MessageBox.Show("请输入相关参数！", "警告");
            }
            isar.ISARtest(i1, i2, r1, r2, thr); 
        }

        private void wav_Click(object sender, EventArgs e)
        {
            keyDetectThread.Abort();
            Thread.Sleep(100);
        }

        private void a_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void X_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void a_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        
        private void audio(object source, System.Timers.ElapsedEventArgs e)
        {
                try
                {
                    /*readAudio.readaudio output = new readAudio.readaudio();
                    MWArray Fre = Convert.ToInt32(Fre_box.Text);
                    MWArray bit = Convert.ToInt32(bit_box.Text);
                    MWArray chn = Convert.ToInt32(Chn_box.Text);
                    MWArray time = float.Parse(Time_box.Text);
                    output.readAudio(Fre, bit, chn, time);*/
                }
                catch
                {
                   // MessageBox.Show("数据有误", "警告");
                }
            
        }

        private void data()
        {
            try
            {
                readData.readdata output = new readData.readdata();
                MWArray a = a_box.Text;
                MWArray X = Convert.ToInt32(b_box.Text);
                MWArray n = Convert.ToInt32(c_box.Text);
                MWArray dim = Convert.ToInt32(d_box.Text);
                output.readData(a, X, n, dim);
            }
            catch
            {
                MessageBox.Show("数据有误", "警告");
            }
        }

        private void X_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void Audio_start_Click(object sender, EventArgs e)
        {
                t.Interval = 100;
                t.Elapsed += new System.Timers.ElapsedEventHandler(audio);//到达时间的时候执行事件
                t.AutoReset = true;//设置是执行一次（false）还是一直执行(true)
                t.Enabled = true;//是否执行System.Timers.Timer.Elapsed事件
                
        }

        private void Audio_stop_Click(object sender, EventArgs e)
        {
            t.Interval = 100000;
            t.Enabled = false;
        }

        private void n_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void dim_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void Fre_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Fre_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void bit_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void Chn_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8))
                e.Handled = true;  
        }

        private void Time_box_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar < 48 || e.KeyChar > 57) && (e.KeyChar != 8) && (e.KeyChar != 46))
                e.Handled = true;
        }

        private void axShockwaveFlash1_Enter(object sender, EventArgs e)
        {

        }

        private void axShockwaveFlash1_Enter_1(object sender, EventArgs e)
        {
           
        }

        private void axShockwaveFlash1_Enter_2(object sender, EventArgs e)
        {

        }


        private void axShockwaveFlash1_Enter_3(object sender, EventArgs e)
        {

        }

        private void FlashBox_Enter(object sender, EventArgs e)
        {

        }
   
        private void StartA_Click(object sender, EventArgs e)
        {
          
        }

        private void closeA_Click(object sender, EventArgs e)
        {
            keyDetectThread.Abort();
            Thread.Sleep(100);
        }

        public static void Delay(int milliSecond)
        {
            int start = Environment.TickCount;
            while (Math.Abs(Environment.TickCount - start) < milliSecond)
            {
                Application.DoEvents();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }


        private void skinButton1_Click(object sender, EventArgs e)
        {
            keyDetecter = new UdpServerOfKeyDetecter();
            // Create the thread object
            keyDetectThread = new Thread(new ThreadStart(keyDetecter.UdpServerCreate));
            // Start the thread
            keyDetectThread.Start();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            //Console.WriteLine(Application.StartupPath);
        }

        private void MainF_Activated(object sender, EventArgs e)
        {
            pictureBox1.Focus();
            pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\tank.gif");
        }

        private void pictureBox1_LoadCompleted(object sender, AsyncCompletedEventArgs e)
        {

        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
           // pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\tank.gif");
        }

        private void pictureBox1_Layout(object sender, LayoutEventArgs e)
        {
           // pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\tank.gif");
        }

        private void pictureBox1_Validated(object sender, EventArgs e)
        {
           // pictureBox1.Image = Image.FromFile(Application.StartupPath + "\\tank.gif");
        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }
    }

    public class UdpServerOfKeyDetecter
    {
        private TcpListener myListener;
        private TcpClient newClient;
        public BinaryReader br;
        public BinaryWriter bw;

        int recv;
        byte[] data;
        IPEndPoint ipep;
        Socket newsock;

        public UdpServerOfKeyDetecter(){
            IPAddress ip = IPAddress.Parse("0.0.0.0");//服务器端ip
            myListener = new TcpListener(ip, 8080);//创建TcpListener实例
            myListener.Start();//start
            newClient = myListener.AcceptTcpClient();//等待客户端连接
            Console.WriteLine("OK");
            ////设置TCP ip 地址和端口号         
            //ipep = new IPEndPoint(IPAddress.Parse("0.0.0.0"), 8080);
            //newsock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ////绑定网络地址
            //newsock.Bind(ipep);
        }


        public void UdpServerCreate()
        {

            //data = new byte[1024];
         
            ////构建TCP 服务器



            //Console.WriteLine("This is a Server, host name is {0}", Dns.GetHostName());



            ////等待客户机连接

            //Console.WriteLine("Waiting for a client");



            ////得到客户机IP

            //IPEndPoint sender = new IPEndPoint(IPAddress.Any,8080);

            //EndPoint Remote = (EndPoint)(sender);
            //Console.WriteLine(sender);
            //recv = newsock.ReceiveFrom(data, ref Remote);

            //Console.WriteLine("Message received from {0}: ", Remote.ToString());

            //Console.WriteLine(Encoding.ASCII.GetString(data, 0, recv));



            //客户机连接成功后，发送欢迎信息

            //string welcome = "Welcome ! ";



            //字符串与字节数组相互转换

            //data = Encoding.ASCII.GetBytes(welcome);



            //发送信息

           // newsock.SendTo(data, data.Length, SocketFlags.None, Remote);
            int i_data;
            Byte[] bytes = new Byte[256];
            while (true)
            {
                NetworkStream clientStream = newClient.GetStream();//利用TcpClient对象GetStream方法得到网络流
                br = new BinaryReader(clientStream);
                string receive = null;
                //if (br!=null) receive = br.ReadString();//读取
                while ((i_data = clientStream.Read(bytes, 0, bytes.Length)) != 0)
                {
                    // Translate data bytes to a ASCII string.
                    receive = System.Text.Encoding.UTF8.GetString(bytes, 0, i_data);
                    Console.WriteLine(receive);
                }
            }

        }
    }

}