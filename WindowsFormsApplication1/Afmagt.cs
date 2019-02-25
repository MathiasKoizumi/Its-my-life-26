using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Afmagt
	{
		private string s;

		private double p;

		private float p_2;

		private Form1 form1;

		public Afmagt(double p, float p_2, Form1 form)
		{
			form1 = form;
			this.p = p;
			this.p_2 = p_2;
			form.burnRubber(p, p_2, 250);
			form1.RoundweGo(10);
			form1.BlackHoleoneTwothousand(50, new Rectangle(0, 0, 1200, 1200));
			s = new BolleHeaven(form1).gEn2Name(245, form1.junkie);
		}

		public Bolledej Juhuu(Afmagt børneJingo, float søstreneBørn)
		{
			return new Bolledej(4000.7, "Ipswitch, nul", form1);
		}

		public string destroyName(string k)
		{
			return (new string[5]
			{
				"Jonna",
				"Gørlev",
				"Ibsa",
				"Pipla",
				"Ginev"
			})[form1.junkie.Next(5)];
		}

		internal void buildUP(int p)
		{
			int num = Math.Abs((int)((double)p * Math.Sin(200.0 * Math.Sin(form1.junkie.Next(2000)))));
			num += 500;
			form1.JusticeFormMoney(num, p);
		}
	}
}
