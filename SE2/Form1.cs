using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SE2 {
	public partial class Form1 : Form {
		public static int number = 0;
		public Form1() {
			InitializeComponent();
		}
		
		private void button1_Click(object sender, EventArgs e) {
			Graphics g = pictureBox1.CreateGraphics();
			Pen p = new Pen(Color.Blue, 2);//定义了一个蓝色,宽度为的画笔
			p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
			g.DrawLine(p, 10, 10, 100, 100);//在画板上画直线,起始坐标为(10,10),终点坐标为(100,100)
			g.DrawLine(p, 100, 10, 10, 100);
			g.DrawRectangle(p, 10, 10, 90, 90);//在画板上画矩形,起始坐标为(10,10),
			g.DrawEllipse(p, 10, 10, 90, 90);//在画板上画椭圆,起始坐标为(10,10),外接矩形的宽为,高为
			Font drawFont = new Font("Arial", 10);
			SolidBrush drawBrush = new SolidBrush(Color.Black);
			g.DrawString("HelloWorld", drawFont, drawBrush, 100,100);
		}

		private void button2_Click(object sender, EventArgs e) {
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(Color.White);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			Console.WriteLine("输出");
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			Graphics g = pictureBox1.CreateGraphics();
			g.Clear(Color.White);
			Font drawFont = new Font("Arial", 18);
			SolidBrush drawBrush = new SolidBrush(Color.Black);
			g.DrawString("["+number+"]", drawFont, drawBrush, 100, 100);
			number++;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{

		}
	}
}
