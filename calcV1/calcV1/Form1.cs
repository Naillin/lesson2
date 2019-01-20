using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcV1
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button3_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button8_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button9_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button10_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button11_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button12_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button13_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + (sender as Button).Text;
		}

		private void button20_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + 0;
		}

		private void button29_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + Math.PI;
		}

		private void button26_Click(object sender, EventArgs e)
		{
			textBox1.Text = textBox1.Text + ",";
		}

		double a, b;
		int count;
		bool Z = true;
		string SS;

		private void button4_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			textBox1.Clear();
			count = 1;
			textBox1.Text = a.ToString() + "+";
			//label1.Text = "+" + a.ToString();
			Z = true;
		}

		private void button5_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 2;
			textBox1.Text = a.ToString() + "-";
			Z = true;
		}

		private void button6_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 3;
			textBox1.Text = a.ToString() + "*";
			Z = true;
		}

		private void button7_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 4;
			textBox1.Text = a.ToString() + "/";
			Z = true;
		}

		private void button19_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 5;
			textBox1.Text = a.ToString() + "^";
			Z = true;
		}

		private void button18_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 6;
			textBox1.Text = "sqrt(" + a.ToString() + ")";
			Z = true;
		}

		private void button17_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 7;
			textBox1.Text = "lg("+a.ToString() + ")";
			Z = true;
		}

		private void button16_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 8;
			textBox1.Text = a.ToString() + "!";
			Z = true;
		}

		private void button25_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 9;
			textBox1.Text = "1/" + a.ToString();
			Z = true;
		}

		private void button21_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 10;
			textBox1.Text = "sin(" + a.ToString() + ")";
			Z = true;
		}

		private void button22_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 11;
			textBox1.Text = "cos(" + a.ToString() + ")";
			Z = true;
		}

		private void button23_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 12;
			textBox1.Text = "tg(" + a.ToString() + ")";
			Z = true;
		}

		private void button27_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 13;
			textBox1.Text = "ctg(" + a.ToString() + ")";
			Z = true;
		}

		private void button28_Click(object sender, EventArgs e)
		{
			a = float.Parse(textBox1.Text);
			count = 14;
			textBox1.Text = "Grad = " + a.ToString();
			Z = true;
		}

		private void button15_Click(object sender, EventArgs e)
		{
			if (Z == true)
			{
				textBox1.Text = "-" + textBox1.Text;
				Z = false;
			}
			else if (Z == false)
			{
				textBox1.Text = textBox1.Text.Replace("-", "");
				Z = true;
			}
		}

		private void Core()
		{
			string DEiStv;
			string[] A;
			double a1;
			double a2;
			switch (count)
			{
				case 1:
					DEiStv = textBox1.Text;
					A = DEiStv.Split('+');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = a1 + a2;
					//double a2 = float.Parse(textBox1.Text);
					//label1.Clear();
					textBox1.Text = b.ToString();
					break;
				case 2:
					DEiStv = textBox1.Text;
					A = DEiStv.Split('-');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = a1 - a2;
					//b = a - float.Parse(textBox1.Text);
					textBox1.Text = b.ToString();
					break;
				case 3:
					DEiStv = textBox1.Text;
					A = DEiStv.Split('*');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = a1 * a2;
					textBox1.Text = b.ToString();
					break;
				case 4:
					DEiStv = textBox1.Text;
					A = DEiStv.Split('/');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = a1 / a2;
					textBox1.Text = b.ToString();
					break;
				case 5:
					DEiStv = textBox1.Text;
					A = DEiStv.Split('^');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = Math.Pow(a1, a2);
					//int l = (int)(Math.Pow(a, float.Parse(textBox1.Text)));
					textBox1.Text = b.ToString();
					break;
				case 6:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 5);
					A = DEiStv.Split(')');
					a1 = Convert.ToDouble(A[0]);
					a2 = Convert.ToDouble(A[1]);
					b = Math.Pow(a1, 1/a2);
					textBox1.Text = b.ToString();
					break;
				case 7:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 3);
					DEiStv = DEiStv.TrimEnd(')');
					a1 = Convert.ToDouble(DEiStv);
					b = Math.Log(a1);
					textBox1.Text = b.ToString();
					break;
				case 8:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.TrimEnd('!');
					a1 = Convert.ToDouble(DEiStv);
					int a1Int = Convert.ToInt32(DEiStv);
					b = 1;
					for (int i=a1Int; i>1;  i--)
					{
						b = b * i;
					}
					textBox1.Text = b.ToString();
					break;
				case 9:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 2);
					a1 = Convert.ToDouble(DEiStv);
					b = 1 / a1;
					textBox1.Text = b.ToString();
					break;
				case 10:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 4);
					DEiStv = DEiStv.TrimEnd(')');
					a1 = Convert.ToDouble(DEiStv);
					b = Math.Sin(a1);
					textBox1.Text = b.ToString();
					break;
				case 11:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 4);
					DEiStv = DEiStv.TrimEnd(')');
					a1 = Convert.ToDouble(DEiStv);
					b = Math.Cos(a1);
					textBox1.Text = b.ToString();
					break;
				case 12:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 3);
					DEiStv = DEiStv.TrimEnd(')');
					a1 = Convert.ToDouble(DEiStv);
					b = Math.Tan(a1);
					textBox1.Text = b.ToString();
					break;
				case 13:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 4);
					DEiStv = DEiStv.TrimEnd(')');
					a1 = Convert.ToDouble(DEiStv);
					b = 1/Math.Tan(a1);
					textBox1.Text = b.ToString();
					break;
				case 14:
					DEiStv = textBox1.Text;
					DEiStv = DEiStv.Remove(0, 7);
					a1 = Convert.ToDouble(DEiStv);
					b = (a1 * 180) / Math.PI;
					textBox1.Text = b.ToString();
					break;
				default:
					break;
			}
		}

		private void button24_Click(object sender, EventArgs e)
		{
			textBox1.Clear();
		}

		//private void button29_Click(object sender, EventArgs e)
		//{

		//}

		//private void button28_Click(object sender, EventArgs e)
		//{

		//}

		//private void button22_Click(object sender, EventArgs e)
		//{

		//}

		//private void button23_Click(object sender, EventArgs e)
		//{

		//}

		//private void button27_Click(object sender, EventArgs e)
		//{

		//}

		//private void button21_Click(object sender, EventArgs e)
		//{

		//}

		private void button14_Click(object sender, EventArgs e)
		{
			Core();
		}
	}
}
