using System;

namespace WindowsFormsApplication1
{
	internal class Børnetid
	{
		private Afmagt def;

		private static int BillyTo;

		private Form1 form1;

		public static double Pingoleg
		{
			get;
			set;
		}

		public Børnetid(Afmagt def, Form1 form)
		{
			this.def = def;
			form1 = form;
		}

		internal void lightly(string p)
		{
			if (form1.junkie.Next(3) == 0)
			{
				form1.TeleTubingDoneWrong(form1.junkie.Next(800), p);
			}
		}

		internal void bolMe(int p)
		{
			new Tegneserie(new JoyRomeo(form1), form1).lineUpSi((double)p * Math.Sin(p), (double)p * Math.Sin(p + 30));
		}

		internal Børnetid jongaWonga(int p, string p_2)
		{
			int billyTo = (int)((double)p + 500.0 * Math.Tan(500.0));
			p_2 = billyTo.ToString() + p_2;
			BillyTo = billyTo;
			return this;
		}

		internal static int tandemspring(int p)
		{
			p = (int)((double)p * Math.Sin(new Random().Next(2000))) + 200;
			return p;
		}
	}
}
