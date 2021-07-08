using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Basic_Traffic_Simulator
{
    public partial class main : Form
    {
        static int[] TimeElapsed = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; 
        public static int[] timestamp = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };

        TrafficLight t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12;
      //  TrafficLight[] trafficLights;


        void setLight(PictureBox light, Color c)
        {
            light.BackColor = c;
        }
        void clearLight(PictureBox light)
        {
            light.BackColor = Color.FromName(this.BackColor.ToString());
        }

        //TrafficLight[] tl = { t1, t2, t3 }; 
       // List<TrafficLight> trafficlights = new List<int>() 
       

        public class TrafficLight 
        {
            private System.Windows.Forms.PictureBox _red;
            private System.Windows.Forms.PictureBox _yellow;
            private System.Windows.Forms.PictureBox _green;

            public TrafficLight(System.Windows.Forms.PictureBox red, System.Windows.Forms.PictureBox yellow, System.Windows.Forms.PictureBox green)
            {
                setLights(red, yellow, green);
            }
            public void setLights(System.Windows.Forms.PictureBox red, System.Windows.Forms.PictureBox yellow, System.Windows.Forms.PictureBox green)
            {
                _red = red;
                _yellow = yellow;
                _green = green;
            }

            void setLight(PictureBox light, Color c)
            {
                light.BackColor = c;
            }
            void clearLight(PictureBox light)
            {
                light.BackColor = Color.FromName(light.BackColor.ToString());//Color.FromName(light.BackColor.ToString());
            }

            public void setGreen()
            {
                setLight(_green, Color.Green);
                clearLight(_red);
                clearLight(_yellow);
            }
            void setRed()
            {
                setLight(_red, Color.Red);
                clearLight(_green);
                clearLight(_yellow);
            }
            public void setYellow()
            {
                setLight(_yellow, Color.Yellow);
                clearLight(_green);
                clearLight(_red);
            }



            public void NextColor(int time4, int time1, int time2, int time3, ref int timeElapsed, int delay, ref int timestamp)
            {
                timestamp = delay;
                if (delay <= timeElapsed)
                {
                   
                    timestamp = time1 + delay;

                    setGreen();
                    if (time1 + delay <= timeElapsed)
                    {
                        timestamp = time2 + time1 + delay;
                        setYellow();
                    }
                    if (time2 + time1 + delay <= timeElapsed)
                    {
                        timestamp = time3 + time2 + time1 + delay;
                        setRed();
                    }
                    if (time2 + time1 + time3 + delay <= timeElapsed)
                    {
                        timestamp = time3 + time2 + time1 + time3 + delay;
                        setYellow();

                    }

                    if (time3 + time2 + time1 + time2 + delay <= timeElapsed)
                    {
                        timeElapsed = delay;
                        timestamp = time1 + delay;
                        setGreen();

                    }
                }
            }
            
        }
        public main()
        {

            InitializeComponent();

            System.Drawing.Drawing2D.GraphicsPath Path = new System.Drawing.Drawing2D.GraphicsPath();
            Path.AddEllipse(0, 0, redlight.Width, redlight.Height);
            redlight.Region = new Region(Path);
            yellowlight.Region = new Region(Path);
            greenlight.Region = new Region(Path);
            lbl_remTime.Text = timestamp.ToString();


            System.Drawing.Drawing2D.GraphicsPath Path2 = new System.Drawing.Drawing2D.GraphicsPath();
            Path2.AddEllipse(0, 0, redlight2.Width, redlight2.Height);
            redlight2.Region = new Region(Path2);
            yellowlight2.Region = new Region(Path2);
            greenlight2.Region = new Region(Path2);
            lbl_remTime2.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path3 = new System.Drawing.Drawing2D.GraphicsPath();
            Path3.AddEllipse(0, 0, redlight3.Width, redlight3.Height);
            redlight3.Region = new Region(Path3);
            yellowlight3.Region = new Region(Path3);
            greenlight3.Region = new Region(Path3);
            lbl_remTime3.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path4 = new System.Drawing.Drawing2D.GraphicsPath();
            Path4.AddEllipse(0, 0, redlight4.Width, redlight4.Height);
            redlight4.Region = new Region(Path4);
            yellowlight4.Region = new Region(Path4);
            greenlight4.Region = new Region(Path4);
            lbl_remTime4.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path5 = new System.Drawing.Drawing2D.GraphicsPath();
            Path5.AddEllipse(0, 0, redlight5.Width, redlight5.Height);
            redlight5.Region = new Region(Path5);
            yellowlight5.Region = new Region(Path5);
            greenlight5.Region = new Region(Path5);
            lbl_remTime5.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path6 = new System.Drawing.Drawing2D.GraphicsPath();
            Path6.AddEllipse(0, 0, redlight6.Width, redlight6.Height);
            redlight6.Region = new Region(Path6);
            yellowlight6.Region = new Region(Path6);
            greenlight6.Region = new Region(Path6);
            lbl_remTime6.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path7 = new System.Drawing.Drawing2D.GraphicsPath();
            Path7.AddEllipse(0, 0, redlight7.Width, redlight7.Height);
            redlight7.Region = new Region(Path7);
            yellowlight7.Region = new Region(Path7);
            greenlight7.Region = new Region(Path7);
            lbl_remTime7.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path8 = new System.Drawing.Drawing2D.GraphicsPath();
            Path8.AddEllipse(0, 0, redlight8.Width, redlight8.Height);
            redlight8.Region = new Region(Path8);
            yellowlight8.Region = new Region(Path8);
            greenlight8.Region = new Region(Path8);
            lbl_remTime8.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path9 = new System.Drawing.Drawing2D.GraphicsPath();
            Path9.AddEllipse(0, 0, redlight9.Width, redlight9.Height);
            redlight9.Region = new Region(Path9);
            yellowlight9.Region = new Region(Path9);
            greenlight9.Region = new Region(Path9);
            lbl_remTime9.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path10 = new System.Drawing.Drawing2D.GraphicsPath();
            Path10.AddEllipse(0, 0, redlight10.Width, redlight10.Height);
            redlight10.Region = new Region(Path10);
            yellowlight10.Region = new Region(Path10);
            greenlight10.Region = new Region(Path10);
            lbl_remTime10.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path11 = new System.Drawing.Drawing2D.GraphicsPath();
            Path11.AddEllipse(0, 0, redlight11.Width, redlight11.Height);
            redlight11.Region = new Region(Path11);
            yellowlight11.Region = new Region(Path11);
            greenlight11.Region = new Region(Path11);
            lbl_remTime11.Text = timestamp.ToString();

            System.Drawing.Drawing2D.GraphicsPath Path12 = new System.Drawing.Drawing2D.GraphicsPath();
            Path12.AddEllipse(0, 0, redlight12.Width, redlight12.Height);
            redlight12.Region = new Region(Path12);
            yellowlight12.Region = new Region(Path12);
            greenlight12.Region = new Region(Path12);
            lbl_remTime12.Text = timestamp.ToString();

            //this.t1 = new TrafficLight(redlight, yellowlight, greenlight);
            //t1.NextColor(10, 3, 10, TimeElapsed, "RED");
            

        t1 = new TrafficLight(redlight, yellowlight, greenlight);
        t2 = new TrafficLight(redlight2, yellowlight2, greenlight2);
        t3 = new TrafficLight(redlight3, yellowlight3, greenlight3);
        t4 = new TrafficLight(redlight4, yellowlight4, greenlight4);
        t5 = new TrafficLight(redlight5, yellowlight5, greenlight5);
        t6 = new TrafficLight(redlight6, yellowlight6, greenlight6);
        t7 = new TrafficLight(redlight7, yellowlight7, greenlight7);
        t8 = new TrafficLight(redlight8, yellowlight8, greenlight8);
        t9 = new TrafficLight(redlight9, yellowlight9, greenlight9);
        t10 = new TrafficLight(redlight10, yellowlight10, greenlight10);
        t11 = new TrafficLight(redlight11, yellowlight11, greenlight11);
        t12 = new TrafficLight(redlight12, yellowlight12, greenlight12);

        //TrafficLight[] trafficLights = { t1, t2, t3, t4, t5, t6, t7, t8, t9, t10, t11, t12 };


        }

    private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
            redlight.BackColor = Color.Red;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            redlight2.BackColor = Color.Red;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            redlight3.BackColor = Color.Red;
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            redlight4.BackColor = Color.Red;
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            redlight5.BackColor = Color.Red;
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            redlight6.BackColor = Color.Red;
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            redlight7.BackColor = Color.Red;
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            redlight8.BackColor = Color.Red;
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            redlight9.BackColor = Color.Red;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            redlight10.BackColor = Color.Red;
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            redlight11.BackColor = Color.Red;
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            redlight12.BackColor = Color.Red;
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                TimeElapsed[i]++;
                //trafficLights[i].NextColor;
            }
                t1.NextColor(3, 15, 3, 84, ref TimeElapsed[0], 66 + 8, ref timestamp[0]);
                t2.NextColor(3, 30, 3, 69, ref TimeElapsed[1], 0 + 8, ref timestamp[1]);
                t3.NextColor(3, 30, 3, 69, ref TimeElapsed[2], 0 + 8, ref timestamp[2]);
                t4.NextColor(3, 15, 3, 84, ref TimeElapsed[3], 84 + 8, ref timestamp[3]);
                t5.NextColor(3, 30, 3, 69, ref TimeElapsed[4], 33 + 8, ref timestamp[4]);
                t6.NextColor(3, 30, 3, 69, ref TimeElapsed[5], 33 + 8, ref timestamp[5]);
                t7.NextColor(3, 15, 3, 84, ref TimeElapsed[6], 66 + 8, ref timestamp[6]);
                t8.NextColor(3, 30, 3, 69, ref TimeElapsed[7], 0 + 8, ref timestamp[7]);
                t9.NextColor(3, 30, 3, 69, ref TimeElapsed[8], 0 + 8, ref timestamp[8]);
                t10.NextColor(3, 15, 3, 84, ref TimeElapsed[9], 84 + 8, ref timestamp[9]);
                t11.NextColor(3, 30, 3, 69, ref TimeElapsed[10], 33 + 8, ref timestamp[10]);
                t12.NextColor(3, 30, 3, 69, ref TimeElapsed[11], 33 + 8, ref timestamp[11]);
           


            lbl_remTime.Text = (timestamp[0] - TimeElapsed[0]).ToString();
            lbl_remTime2.Text = (timestamp[1] - TimeElapsed[1]).ToString();
            lbl_remTime3.Text = (timestamp[2] - TimeElapsed[2]).ToString();
            lbl_remTime4.Text = (timestamp[3] - TimeElapsed[3]).ToString();
            lbl_remTime5.Text = (timestamp[4] - TimeElapsed[4]).ToString();
            lbl_remTime6.Text = (timestamp[5] - TimeElapsed[5]).ToString();
            lbl_remTime7.Text = (timestamp[6] - TimeElapsed[6]).ToString();
            lbl_remTime8.Text = (timestamp[7] - TimeElapsed[7]).ToString();
            lbl_remTime9.Text = (timestamp[8] - TimeElapsed[8]).ToString();
            lbl_remTime10.Text = (timestamp[9] - TimeElapsed[9]).ToString();
            lbl_remTime11.Text = (timestamp[10] - TimeElapsed[10]).ToString();
            lbl_remTime12.Text = (timestamp[11] - TimeElapsed[11]).ToString();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void greenlight2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox18_Click(object sender, EventArgs e)
        {

        }

        private void panel5_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void redlight2_Click(object sender, EventArgs e)
        {

        }
    }
}

