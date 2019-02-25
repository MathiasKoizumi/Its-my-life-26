namespace WindowsFormsApplication1
{
	internal class Børneleg
	{
		private Form1 form1;

		public Børneleg(Form1 form)
		{
			form1 = form;
			new Bollemælk(form1).TrinityJoyBomb(400, 5000, 600);
		}

		internal int passMeTheSugar(int p)
		{
			form1.drawFunnyShapes(400, 400);
			new Bolledej(600.0, "FiretursindeÅrsPåske", form1).tumbeDej();
			p += p;
			p = p * p - p;
			return p / 2;
		}
	}
}
