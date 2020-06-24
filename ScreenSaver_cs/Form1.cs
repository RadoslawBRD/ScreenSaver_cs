using System;
using System.Collections.Generic;
using System.ComponentModel;

using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Drawing.Imaging;



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {

        [DllImport("user32.dll")]
        public static extern bool GetWindowRect(IntPtr hwnd, ref Rect rectangle);
        public List<Process> procesy = new List<Process>();
        //public static String png_folder; // for production
        public static String png_folder= "c:\\Temp";

        Rect rect = new Rect();
        public int counter = 0;
        string curDate;
        Boolean errors = false;

        public Form1()
        {
           InitializeComponent();

           comboBox1.DataSource = procesy;
           Process[] processList = get_proc();

            foreach (Process process in processList)
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                    procesy.Add(process);
                    
                
            comboBox1.DisplayMember = "MainWindowTitle";
            comboBox1.ValueMember = "Id";

            update_info("Ready...");
            Console.WriteLine("Ready");
        }
       
        public struct Rect
        {
            public int Left { get; set; }
            public int Top { get; set; }
            public int Right { get; set; }
            public int Bottom { get; set; }
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            get_ss(rect);
            //threaded_loop();/////////////////Start main loop and hide button
         
        }
        private Process[] get_proc()
        {
            return Process.GetProcesses();
        }
      
        public void get_ss(Rect rect)
        {
            Size size = new Size((rect.Right- rect.Left-110),(rect.Bottom-rect.Top-120));
            
            //var bmp = new Bitmap(1420, 950, PixelFormat.Format24bppRgb);
            var bmp = new Bitmap(size.Width, size.Height,PixelFormat.Format24bppRgb);

            float x = 24;//float.Parse(textResX.Text);
            bmp.SetResolution(x, x); //(x,y)
                      
            Graphics graphics = Graphics.FromImage(bmp);
            
            graphics.CopyFromScreen(rect.Left+110, rect.Top+120, 0,0, size,CopyPixelOperation.SourceCopy);

            ImageCodecInfo imageFormat = GetEncoder(ImageFormat.Png);
            EncoderParameters myEncoderParameters = new EncoderParameters(2);

            int q = 10;//int.Parse(textQual.Text);
            int c = 3;//int.Parse(textComp.Text);

            myEncoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, (long)q);
            myEncoderParameters.Param[1] = new EncoderParameter(System.Drawing.Imaging.Encoder.Compression, (Byte)c);
            //System.Drawing.Imaging.Encoder

            //bmp.Save("c:\\TSBackup\\Zrzuty\\test.png", imageFormat, myEncoderParameters);

            bmp.Save("c:\\Temp\\test.png", imageFormat, myEncoderParameters);
            bmp.Save("c:\\Temp\\test.jpg", imageFormat, myEncoderParameters);
            save_ss(imageFormat, myEncoderParameters,bmp);
            float fsize = new System.IO.FileInfo("c:\\Temp\\test.png").Length;
            update_info("Size: "+(fsize/1024).ToString());
            //dispose
            bmp.Dispose();
            graphics.Dispose();
            
        }

        public void threaded_loop()////////////////////////MAIN LOOOOP
        {
            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(10);

            var timer = new System.Threading.Timer((e) =>
            {
                while (DateTime.Now.Second % 10 != 0)
                { }
                if (errors)
                    this.Dispose();
                else
                    get_ss(rect);
            }, null, startTimeSpan, periodTimeSpan);

        }
        public void save_ss(ImageCodecInfo imageFormat, EncoderParameters myEncoderParameters, Bitmap bmp)
        {
            curDate = calculate_time();
            bmp.Save(png_folder+"\\"+curDate+".png", imageFormat, myEncoderParameters);

        }
        private string calculate_time()
        {
            DateTime newDate = DateTime.Now;
            int d1 = newDate.Day / 10;
            int d2 = newDate.Day % 10;
             
            int h1 = newDate.Hour / 10;
            int h2 = newDate.Hour % 10;
             
            int m1 = newDate.Minute / 10;
            int m2 = newDate.Minute % 10;
             
            int s1 = newDate.Second / 10 * 10;
             
            int month = newDate.Month;

            return  d1.ToString() + d2.ToString() + month.ToString() + h1.ToString() + h2.ToString() + m1.ToString() + m2.ToString() + s1.ToString();
        }


        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
                if (codec.FormatID == format.Guid)
                    return codec;

            return null;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine(comboBox1.SelectedValue.ToString());
            IntPtr ptr = Process.GetProcessById(int.Parse(comboBox1.SelectedValue.ToString())).MainWindowHandle;

            if(GetWindowRect(ptr, ref rect))
            {
                update_info("Window selected...");
                Console.WriteLine("Window selected "+ rect.Top);

            }
        }


        private void update_info(string info)
        {
            label1.Text = "Console: "+ info;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            fbd.Description = "Folder picker";
            fbd.ShowNewFolderButton = false;
            if (fbd.ShowDialog() == DialogResult.OK)
                png_folder= fbd.SelectedPath.ToString();
            System.Console.WriteLine(png_folder);
            fbd.Dispose();

        }
        public static void png_view()
        {
            var PNG_Viewer = new PNG_Viewer().ShowDialog();
            //PNG_Viewer.ShowDialog();                              
        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(png_view));
            t.Start();
        }
    }
}
