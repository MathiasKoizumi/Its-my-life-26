using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Jonga
	{
		private int p;

		private Form1 form1;

		public Jonga(int p, Form1 form1)
		{
			this.p = p;
			this.form1 = form1;
		}

		internal int getNumbing(int p)
		{
			return p + 1000;
		}

		public void horizontalBlowUP(int divisions, int explosions, int direction)
		{
			int num = form1.ClientSize.Width / divisions;
			switch (direction)
			{
			case 0:
				for (int j = 0; j < divisions; j++)
				{
					form1.Explosionshow(explosions, new Rectangle(j * num, 0, divisions, form1.ClientSize.Height));
				}
				break;
			case 1:
				for (int l = 0; l < divisions; l++)
				{
					form1.Explosionshow(explosions, new Rectangle(form1.ClientSize.Width - l * num, 0, divisions, form1.ClientSize.Height));
				}
				break;
			case 2:
				for (int m = 0; m < divisions; m++)
				{
					form1.Explosionshow(explosions, new Rectangle(0, m * num, form1.ClientSize.Width, divisions));
				}
				break;
			case 3:
				for (int k = 0; k < divisions; k++)
				{
					form1.Explosionshow(explosions, new Rectangle(0, form1.ClientSize.Height - k * num, form1.ClientSize.Width, divisions));
				}
				break;
			default:
				for (int i = 0; i < divisions; i++)
				{
					form1.Explosionshow(explosions, new Rectangle(i * num, 0, divisions, form1.ClientSize.Height));
				}
				break;
			}
		}
	}
}
