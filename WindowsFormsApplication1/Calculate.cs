using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{

	enum operations { empty, sum, dif, mult, div, sq_root, root, sq, exponent };

	class Calculate
	{
		double first = 0;
		double second = 0;
		operations operation = operations.empty;

		void set_first(double first)
		{
			this.first = first;
		}

		void set_second(double second)
		{
			this.second = second;
		}

		void set_oper(operations operation)
		{
			this.operation = operation;
		}

		public void clear()
		{
			this.first = 0;
			this.second = 0;
			this.operation = operations.empty;
		}

		void f_calculate()
		{
			switch (operation)
			{
				case (operations.sum):
					this.first = this.first + this.second;
					set_second(0);
					break;
				case (operations.dif):
					this.first = this.first - this.second;
					set_second(0);
					break;
				case (operations.mult):
					if(this.first != 0 && this.second != 0)
					{
						this.first = this.first * this.second;
						set_second(0);
					}
					break;
				case (operations.div):
					if (this.first != 0 && this.second != 0)
					{
						this.first = this.first / this.second;
						set_second(0);
					}
					break;
				case (operations.sq_root):
					if(this.first >= 0)
					{
						this.first = Math.Sqrt(this.first) ;
						set_second(0);
					}
					break;
				case (operations.root):
					this.second = Math.Pow(this.second, -1);
					this.first = Math.Pow(this.first, this.second);
					set_second(0);
					break;
				case (operations.sq):
					this.first = Math.Pow(this.first, 2);
					set_second(0);
					break;
				case (operations.exponent):
					this.first = Math.Pow(this.first, this.second);
					set_second(0);
					break;
			}
		}

		public string input(string number, operations operation)
		{
			double value = Convert.ToDouble(number);
			return Convert.ToString( logik(value, operation));
		}

		private double logik(double value, operations operation)
		{
			if (this.first == 0)
			{
				set_first(value);
				set_oper(operation);
				if(operation == operations.sq_root || operation == operations.sq)
				{
					f_calculate();
				}
				return this.first;
			}
			if (this.operation != operations.empty)
			{
				set_second(value);
				f_calculate();
				set_oper(operation);
				if (operation == operations.sq_root || operation == operations.sq)
				{
					f_calculate();
				}
				return this.first;
			}
			else
			{
				if(value != this.first)
				{
					this.first = value;
				}
				set_oper(operation);
				return this.first;
			}
		}
	}
}
