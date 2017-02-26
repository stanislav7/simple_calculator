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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		Calculate  calculate = new Calculate();

		bool flag;

		private void button_handler(string digit)
		{
			if (flag)
			{
				textBox1.Text = "0";
				flag = false;
			}
			if (textBox1.Text == "0")
			{
				textBox1.Text = digit;
			}
			else
			{
				textBox1.Text = string.Concat(textBox1.Text, digit);
			}
		}

		private void button_handler(operations operation)
		{
			textBox1.Text = calculate.input(textBox1.Text, operation);
			flag = true;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button_handler("1");
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button_handler("2");
		}

		private void button3_Click(object sender, EventArgs e)
		{
			button_handler("3");
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button_handler("4");
		}

		private void button5_Click(object sender, EventArgs e)
		{
			button_handler("5");
		}

		private void button6_Click(object sender, EventArgs e)
		{
			button_handler("6");
		}

		private void button7_Click(object sender, EventArgs e)
		{
			button_handler("7");
		}

		private void button8_Click(object sender, EventArgs e)
		{
			button_handler("8");
		}

		private void button9_Click(object sender, EventArgs e)
		{
			button_handler("9");
		}

		private void button10_Click(object sender, EventArgs e)
		{
			button_handler("0");
		}
		private void button11_Click(object sender, EventArgs e)
		{
			button_handler(",");
		}
		private void sum_Click(object sender, EventArgs e)
		{
			button_handler(operations.sum);
		}

		private void diff_Click(object sender, EventArgs e)
		{
			button_handler(operations.dif);
		}

		private void mult_Click(object sender, EventArgs e)
		{
			button_handler(operations.mult);
		}

		private void div_Click(object sender, EventArgs e)
		{
			button_handler(operations.div);
		}

		private void Go_Click(object sender, EventArgs e)
		{
			button_handler(operations.empty);
		}

		private void clear_Click(object sender, EventArgs e)
		{
			calculate.clear();
			textBox1.Text = "0";
		}

		private void backspace_Click(object sender, EventArgs e)
		{
			int l = textBox1.Text.Length - 1;
			textBox1.Text = textBox1.Text.Remove(l);
		}

		
	}
}
