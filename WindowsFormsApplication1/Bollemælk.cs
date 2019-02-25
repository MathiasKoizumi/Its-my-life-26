using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Bollemælk
	{
		private Form1 form1;

		public Bollemælk(Form1 form)
		{
			form1 = form;
			new JoyRomeo(form1);
			form1.JumpOut(10);
			form1.trySpiralExplosions(100, 500, 400);
		}

		internal Juklas effectShow()
		{
			if (form1.gfx == null)
			{
				return null;
			}
			form1.Explosionshow(form1.junkie.Next(250), new Rectangle(form1.junkie.Next(form1.ClientSize.Width), form1.junkie.Next(form1.ClientSize.Height), form1.junkie.Next(form1.ClientSize.Width), form1.junkie.Next(form1.ClientSize.Height)));
			form1.burnRubber(850.0, 300f, 200);
			if (form1.junkie.Next(1) == 0)
			{
				form1.writeMeAStory();
			}
			return new Juklas(form1);
		}

		internal void TrinityJoyBomb(int p, int p_2, int p_3)
		{
			for (int i = 0; i < 1; i++)
			{
				form1.JumpOut(10);
				new Spaceship1(form1);
				new Lingo(p, new Børnetid(new Afmagt(200.0, 5000f, form1), form1), 400, form1);
			}
		}
	}
}
