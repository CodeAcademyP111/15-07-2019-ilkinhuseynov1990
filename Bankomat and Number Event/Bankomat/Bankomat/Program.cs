using System;

namespace Bankomat
{
	class Program
	{
		static void Main(string[] args)
		{
			Terminal terminal = new Terminal(10);

			terminal.EnoughMoney += n =>
			{
				Console.WriteLine($"Bankomatda sizin isdediyiniz geder pul yoxdur. Hal hazirda bankomatda {n} pul var");
			};

			terminal.CompareMoney(0);


			NewMath newMath = new NewMath(5);

			newMath.check = newMath.checkPosition;
			newMath.check += newMath.simpleNum;
			newMath.check += newMath.EvenorOdd;
			newMath.check(newMath.Number);
		}
	}


	public class Terminal
	{
		public event Action<int> EnoughMoney;
		public int Money;

		public Terminal(int money)
		{
			Money = money;
		}


		public void CompareMoney(int mymoney)
		{
			if(mymoney > Money)
			{
				EnoughMoney(Money);
			}
			else
			{
				Money -= mymoney;
				Console.WriteLine("Sizin cari balansiniz " + Money);
			}
			
		}
	}


	public class NewMath {

		public Action<int> check;

		public int Number;

		public NewMath(int num)
		{
			Number = num;
		}


		public void checkPosition(int num)
		{
			if (num < 0)
			{
				Console.WriteLine("Eded Menfidir");
			}
			else
			{
				Console.WriteLine("Musbet ededdir");
			}
		}

		public void simpleNum(int num)
		{
			int count = 0;

			for (int i = 1; i <= num; i++)
			{
				if (num % i == 0)
				{
					count++;
				}
			}


			if (count > 2)
			{
				Console.WriteLine("Murekkeb ededdir");
			}
			else
			{
				Console.WriteLine("Sade ededir");
			}
		}

		public void EvenorOdd(int num)
		{
			if (num%2==0)
			{
				Console.WriteLine("cut ededdir");
			}
			else
			{
				Console.WriteLine("Tek ededdir");
			}
		}
	}
}
