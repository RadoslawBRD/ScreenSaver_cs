using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class PNG_Viewer : Form
    {
        string[] month_tab = new string[] { "Styczen","Luty","Marzec","Kwiecień","Maj","Czerwiec","Lipiec","Sierpień","Wrzesień","Październik","Listopad","Grudzień" };
        int d1, d2, h1, h2, m1, m2, s1, month;
        DateTime initDate;
        DateTime newDate;
        public Size img_size = new Size(50,50);
        public Size loaded_size;
        string png_folder = Form1.png_folder;
        public string file_name;
        Bitmap ss_holder;
        public PNG_Viewer()
        {
            InitializeComponent();
            initDate = DateTime.Now;
            newDate = initDate;
            calculate_time(initDate);
            update_date_form();

        }
        private void lm1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left) {
            newDate = newDate.AddMinutes(10);
            
            update_date_form();
        }else{
            newDate = newDate.AddMinutes(-10);
            
            update_date_form();
            }
        }
        private void lm2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddMinutes(1);
                
                update_date_form();
            }
            else
            {
                newDate = newDate.AddMinutes(-1);
                
                update_date_form();
            }
        }
        private void ls1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddSeconds(10);
                
                update_date_form();
            }
            
            else
            {
                newDate = newDate.AddSeconds(-10);
                
                update_date_form();
            }
        }
        private void lmonth_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            Console.Write(me.Button.ToString());
            if (me.Button == MouseButtons.Left)
            {
                Console.WriteLine("Zmieniam");
                newDate = newDate.AddMonths(1);
                
                update_date_form();
            }else {
                newDate = newDate.AddMonths(-1);
                
                update_date_form();
            }
            Console.Write(newDate.Month);

        }

        

        private void lh2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddHours(1);
                
                update_date_form();
            }else {
                newDate = newDate.AddHours(-1);
                
                update_date_form();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void update_info(string info)
        {
            try
            {
                label1.Text = "Console: " + info;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                
            }
        }
        private void lh1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddHours(10);
                
                update_date_form();
            }
            else {
                newDate = newDate.AddHours(-10);
                
                update_date_form();
            }
        }
        private void ld2_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddDays(1);
                
                update_date_form();
            }
            else {
                newDate = newDate.AddDays(-1);
                
                update_date_form();
            }
        }
        private void ld1_Click(object sender, EventArgs e)
        {
            MouseEventArgs me = (MouseEventArgs)e;
            if (me.Button == System.Windows.Forms.MouseButtons.Left)
            {
                newDate = newDate.AddDays(10);
                
                update_date_form();
            }
            else {
                newDate = newDate.AddDays(-10);
                
                update_date_form();
            }
        }

        private void calculate_time(DateTime newDate )
        {
            d1 = newDate.Day / 10;
            d2 = newDate.Day % 10;

            h1 = newDate.Hour / 10;
            h2 = newDate.Hour % 10;

            m1 = newDate.Minute / 10;
            m2 = newDate.Minute % 10;

            s1 = newDate.Second / 10 * 10;

            month = newDate.Month;
        }

        private void update_date_form()
        {

            Console.WriteLine(newDate);
           string vld1 = (newDate.Day / 10).ToString();
           string vld2  = (newDate.Day % 10).ToString();
           string vlh1  = (newDate.Hour / 10).ToString();
           string vlh2  = (newDate.Hour % 10).ToString();
           string vlm1  = (newDate.Minute / 10).ToString();
           string vlm2  = (newDate.Minute % 10).ToString();
           string vls1  = (newDate.Second / 10 * 10).ToString();
           string vlmonth =  newDate.Month.ToString();

            ld1.Text = vld1;
            ld2.Text = vld2;
            lh1.Text = vlh1;
            lh2.Text = vlh2;
            lm1.Text = vlm1;
            lm2.Text = vlm2;
            ls1.Text = vls1;

            lmonth.Text = month_tab[newDate.Month - 1];


            file_name = vld1 + vld2 + vlmonth +  vlh1 + vlh2 + vlm1 + vlm2 + vls1;
            if (PNG_Viewer.ActiveForm != null)
                print_ss();
            else
                Console.WriteLine("No form with png");

        }
        
        private void print_ss()
        {
            try
            {
                Console.WriteLine(png_folder + "\\" + file_name + ".png");
                string temp = png_folder + "\\" + file_name + ".png";
                using (Image ss = Image.FromFile(temp))
                {   //double hei = ss.Height*(Convert.ToDouble(trackBar1.Value) / 10);
                    
                    img_size.Height = Convert.ToInt32(ss.Height * (Convert.ToDouble(trackBar1.Value) / 10));
                    img_size.Width = Convert.ToInt32(ss.Width * (Convert.ToDouble(trackBar1.Value) / 10));


                    //img_size.Height = Convert.ToInt32((double)(ss.Height*(trackBar1.Value / 10)));
                    //img_size.Width = Convert.ToInt32((double)(ss.Width* (trackBar1.Value / 10)));

                    //ss_holder = new Bitmap(ss, img_size);
                    //////////////////////MEMORY LEAK
                    try
                    {
                        if (ss_holder != null)
                            ss_holder.Dispose();
                        ss_holder = new Bitmap(ss, img_size);
                        

                            pictureBox1.Image = ss_holder;
                        
                        //ssss(ss_holder);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    }
                    //pictureBox1.Image = new Bitmap();
                    update_info(/*file_name + */   ".png");
                
            }
            catch (Exception e)
            {
                update_info("Brak pliku");
                System.Console.WriteLine(e.Message.ToString());
            }
        }
        private void ssss(Bitmap bp)
        {
            {
                pictureBox1.Image = bp;
            }           
            
        }
        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //img_size.Height = trackBar1.Value;
            //img_size.Width = trackBar1.Value;
            print_ss();
        }
    }

}
