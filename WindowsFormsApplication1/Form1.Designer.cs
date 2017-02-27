namespace WindowsFormsApplication1
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Button Go;
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.sq_root = new System.Windows.Forms.Button();
			this.exponent = new System.Windows.Forms.Button();
			this.root = new System.Windows.Forms.Button();
			this.sq = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.button11 = new System.Windows.Forms.Button();
			this.backspace = new System.Windows.Forms.Button();
			this.clear = new System.Windows.Forms.Button();
			this.button7 = new System.Windows.Forms.Button();
			this.div = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.mult = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.diff = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.sum = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button5 = new System.Windows.Forms.Button();
			this.button9 = new System.Windows.Forms.Button();
			this.button6 = new System.Windows.Forms.Button();
			this.button8 = new System.Windows.Forms.Button();
			Go = new System.Windows.Forms.Button();
			this.panel1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// Go
			// 
			Go.Location = new System.Drawing.Point(158, 143);
			Go.Name = "Go";
			Go.Size = new System.Drawing.Size(45, 25);
			Go.TabIndex = 14;
			Go.Text = "=";
			Go.UseVisualStyleBackColor = true;
			Go.Click += new System.EventHandler(this.Go_Click);
			// 
			// textBox1
			// 
			this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBox1.Location = new System.Drawing.Point(39, 25);
			this.textBox1.Margin = new System.Windows.Forms.Padding(7);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(347, 30);
			this.textBox1.TabIndex = 0;
			this.textBox1.Text = "0";
			this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// panel1
			// 
			this.panel1.AutoSize = true;
			this.panel1.Controls.Add(this.groupBox2);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Location = new System.Drawing.Point(12, 65);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(326, 290);
			this.panel1.TabIndex = 1;
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.sq_root);
			this.groupBox2.Controls.Add(this.exponent);
			this.groupBox2.Controls.Add(this.root);
			this.groupBox2.Controls.Add(this.sq);
			this.groupBox2.Location = new System.Drawing.Point(218, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(46, 183);
			this.groupBox2.TabIndex = 15;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "groupBox2";
			// 
			// sq_root
			// 
			this.sq_root.Location = new System.Drawing.Point(-1, 18);
			this.sq_root.Name = "sq_root";
			this.sq_root.Size = new System.Drawing.Size(45, 25);
			this.sq_root.TabIndex = 0;
			this.sq_root.Text = "²√¯";
			this.sq_root.UseVisualStyleBackColor = true;
			this.sq_root.Click += new System.EventHandler(this.sq_root_Click);
			// 
			// exponent
			// 
			this.exponent.Location = new System.Drawing.Point(0, 111);
			this.exponent.Name = "exponent";
			this.exponent.Size = new System.Drawing.Size(45, 25);
			this.exponent.TabIndex = 3;
			this.exponent.Text = "^";
			this.exponent.UseVisualStyleBackColor = true;
			this.exponent.Click += new System.EventHandler(this.exponent_Click);
			// 
			// root
			// 
			this.root.Location = new System.Drawing.Point(0, 49);
			this.root.Name = "root";
			this.root.Size = new System.Drawing.Size(45, 25);
			this.root.TabIndex = 1;
			this.root.Text = "√¯";
			this.root.UseVisualStyleBackColor = true;
			this.root.Click += new System.EventHandler(this.root_Click);
			// 
			// sq
			// 
			this.sq.Location = new System.Drawing.Point(0, 80);
			this.sq.Name = "sq";
			this.sq.Size = new System.Drawing.Size(45, 25);
			this.sq.TabIndex = 2;
			this.sq.Text = "^²";
			this.sq.UseVisualStyleBackColor = true;
			this.sq.Click += new System.EventHandler(this.sq_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.button11);
			this.groupBox1.Controls.Add(this.backspace);
			this.groupBox1.Controls.Add(this.clear);
			this.groupBox1.Controls.Add(Go);
			this.groupBox1.Controls.Add(this.button7);
			this.groupBox1.Controls.Add(this.div);
			this.groupBox1.Controls.Add(this.button1);
			this.groupBox1.Controls.Add(this.mult);
			this.groupBox1.Controls.Add(this.button2);
			this.groupBox1.Controls.Add(this.diff);
			this.groupBox1.Controls.Add(this.button3);
			this.groupBox1.Controls.Add(this.sum);
			this.groupBox1.Controls.Add(this.button4);
			this.groupBox1.Controls.Add(this.button10);
			this.groupBox1.Controls.Add(this.button5);
			this.groupBox1.Controls.Add(this.button9);
			this.groupBox1.Controls.Add(this.button6);
			this.groupBox1.Controls.Add(this.button8);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(209, 184);
			this.groupBox1.TabIndex = 14;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "groupBox1";
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(57, 143);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(45, 25);
			this.button11.TabIndex = 17;
			this.button11.Text = ",";
			this.button11.UseVisualStyleBackColor = true;
			this.button11.Click += new System.EventHandler(this.button11_Click);
			// 
			// backspace
			// 
			this.backspace.Location = new System.Drawing.Point(56, 19);
			this.backspace.Name = "backspace";
			this.backspace.Size = new System.Drawing.Size(45, 25);
			this.backspace.TabIndex = 16;
			this.backspace.Text = "<--";
			this.backspace.UseVisualStyleBackColor = true;
			this.backspace.UseWaitCursor = true;
			this.backspace.Click += new System.EventHandler(this.backspace_Click);
			// 
			// clear
			// 
			this.clear.Location = new System.Drawing.Point(107, 19);
			this.clear.Name = "clear";
			this.clear.Size = new System.Drawing.Size(45, 25);
			this.clear.TabIndex = 15;
			this.clear.Text = "clear";
			this.clear.UseVisualStyleBackColor = true;
			this.clear.UseWaitCursor = true;
			this.clear.Click += new System.EventHandler(this.clear_Click);
			// 
			// button7
			// 
			this.button7.Location = new System.Drawing.Point(6, 50);
			this.button7.Name = "button7";
			this.button7.Size = new System.Drawing.Size(45, 25);
			this.button7.TabIndex = 6;
			this.button7.Text = "7";
			this.button7.UseVisualStyleBackColor = true;
			this.button7.Click += new System.EventHandler(this.button7_Click);
			// 
			// div
			// 
			this.div.Location = new System.Drawing.Point(158, 112);
			this.div.Name = "div";
			this.div.Size = new System.Drawing.Size(45, 25);
			this.div.TabIndex = 13;
			this.div.Text = ":";
			this.div.UseVisualStyleBackColor = true;
			this.div.Click += new System.EventHandler(this.div_Click);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(6, 112);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(45, 25);
			this.button1.TabIndex = 0;
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// mult
			// 
			this.mult.Location = new System.Drawing.Point(158, 81);
			this.mult.Name = "mult";
			this.mult.Size = new System.Drawing.Size(45, 25);
			this.mult.TabIndex = 12;
			this.mult.Text = "x";
			this.mult.UseVisualStyleBackColor = true;
			this.mult.Click += new System.EventHandler(this.mult_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(56, 112);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(45, 25);
			this.button2.TabIndex = 1;
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// diff
			// 
			this.diff.Location = new System.Drawing.Point(158, 50);
			this.diff.Name = "diff";
			this.diff.Size = new System.Drawing.Size(45, 25);
			this.diff.TabIndex = 11;
			this.diff.Text = "-";
			this.diff.UseVisualStyleBackColor = true;
			this.diff.Click += new System.EventHandler(this.diff_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(107, 112);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(45, 25);
			this.button3.TabIndex = 2;
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// sum
			// 
			this.sum.Location = new System.Drawing.Point(158, 19);
			this.sum.Name = "sum";
			this.sum.Size = new System.Drawing.Size(45, 25);
			this.sum.TabIndex = 10;
			this.sum.Text = "+";
			this.sum.UseVisualStyleBackColor = true;
			this.sum.Click += new System.EventHandler(this.sum_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(6, 81);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(45, 25);
			this.button4.TabIndex = 3;
			this.button4.Text = "4";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(6, 143);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(45, 25);
			this.button10.TabIndex = 9;
			this.button10.Text = "0";
			this.button10.UseVisualStyleBackColor = true;
			this.button10.Click += new System.EventHandler(this.button10_Click);
			// 
			// button5
			// 
			this.button5.Location = new System.Drawing.Point(56, 81);
			this.button5.Name = "button5";
			this.button5.Size = new System.Drawing.Size(45, 25);
			this.button5.TabIndex = 4;
			this.button5.Text = "5";
			this.button5.UseVisualStyleBackColor = true;
			this.button5.Click += new System.EventHandler(this.button5_Click);
			// 
			// button9
			// 
			this.button9.Location = new System.Drawing.Point(107, 50);
			this.button9.Name = "button9";
			this.button9.Size = new System.Drawing.Size(45, 25);
			this.button9.TabIndex = 8;
			this.button9.Text = "9";
			this.button9.UseVisualStyleBackColor = true;
			this.button9.Click += new System.EventHandler(this.button9_Click);
			// 
			// button6
			// 
			this.button6.Location = new System.Drawing.Point(107, 81);
			this.button6.Name = "button6";
			this.button6.Size = new System.Drawing.Size(45, 25);
			this.button6.TabIndex = 5;
			this.button6.Text = "6";
			this.button6.UseVisualStyleBackColor = true;
			this.button6.Click += new System.EventHandler(this.button6_Click);
			// 
			// button8
			// 
			this.button8.Location = new System.Drawing.Point(56, 50);
			this.button8.Name = "button8";
			this.button8.Size = new System.Drawing.Size(45, 25);
			this.button8.TabIndex = 7;
			this.button8.Text = "8";
			this.button8.UseVisualStyleBackColor = true;
			this.button8.Click += new System.EventHandler(this.button8_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 367);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.panel1.ResumeLayout(false);
			this.groupBox2.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button9;
		private System.Windows.Forms.Button button8;
		private System.Windows.Forms.Button button7;
		private System.Windows.Forms.Button button6;
		private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Button div;
		private System.Windows.Forms.Button mult;
		private System.Windows.Forms.Button diff;
		private System.Windows.Forms.Button sum;
		private System.Windows.Forms.Button clear;
		private System.Windows.Forms.Button backspace;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button exponent;
		private System.Windows.Forms.Button sq;
		private System.Windows.Forms.Button root;
		private System.Windows.Forms.Button sq_root;
		private System.Windows.Forms.GroupBox groupBox2;
	}
}

