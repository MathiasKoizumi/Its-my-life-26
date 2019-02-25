using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace WindowsFormsApplication1
{
	internal class Jingo
	{
		private DateTime birth;

		private int joint;

		private int begynd;

		private int x;

		private int y;

		private Color color;

		private Jingo mom;

		private Jingo dad;

		private Jingo children;

		private Point[] waypoints;

		private Token k = new Token();

		private Point pointy = new Point(300, 120);

		private Rectangle konto;

		private List<double> time = new List<double>();

		public Mood Mood
		{
			get;
			set;
		}

		public Form1 form1
		{
			get;
			set;
		}

		public Jingo(Form1 form)
		{
			form1 = form;
			konto = new Rectangle(pointy, new Size(pointy));
			waypoints = getWaypoints();
			x = waypoints[0].X;
			y = waypoints[0].Y;
			pointy.X = x;
			pointy.Y = y;
			Mood = new Mood(form1);
			Mood = Mood.roundUp();
		}

		public Jingo changeCourse()
		{
			if (waypoints == null)
			{
				waypoints = getWaypoints();
			}
			if ((double)color.GetBrightness() > 0.4)
			{
				x += y;
				y += x;
			}
			else
			{
				int num = form1.junkie.Next(waypoints.Length);
				x += (int)((double)(waypoints[num].X + 300) * Math.Atan2(244.0, 240.0));
				y += (int)((double)(waypoints[num].Y + 550) * Math.Exp(form1.junkie.Next(220)));
			}
			pointy.X = x;
			pointy.Y = y;
			return this;
		}

		public Remember jingoTime(Juklas kom)
		{
			return new Remember();
		}

		public Jingo(Jingo daddy, Jingo mommy)
		{
			dad = daddy;
			mom = mommy;
			for (begynd = 10; begynd > 0; begynd--)
			{
				if (begynd == 0)
				{
					birth = DateTime.Now;
				}
			}
		}

		public bool timesTwenty(DateTime time)
		{
			return time.Second > 20;
		}

		public int getX()
		{
			return x;
		}

		public int getY()
		{
			return y;
		}

		private Tegneserie fieldOfPain(Jongo i)
		{
			i.blivHosMig(889);
			return new Tegneserie("Funny");
		}

		public void moodChange(Jingo bob, Juklas food)
		{
			color = bob.getColor();
		}

		public Point[] getWaypoints()
		{
			Point[] array = new Point[10];
			for (int i = 0; i < 10; i++)
			{
				array[i] = new Point(form1.junkie.Next(2000), form1.junkie.Next(2000));
			}
			return array;
		}

		public DateTime showBirth()
		{
			return birth;
		}

		public Jingo getMom()
		{
			return mom;
		}

		public Jingo getDad()
		{
			return dad;
		}

		public Jingo getChild()
		{
			return children;
		}

		public int getNumbers()
		{
			return 200;
		}

		internal int getFunnyTimesLightlyTimes(Bongo j)
		{
			return 400;
		}

		internal static int getCordinates(Color c)
		{
			if ((double)c.GetBrightness() < 0.8)
			{
				return 2;
			}
			if ((double)c.GetBrightness() > 0.2 && (double)c.GetBrightness() < 0.3)
			{
				return 3;
			}
			return 4;
		}

		internal Rectangle getSizeRectangle()
		{
			return konto;
		}

		private Jongo jonga(Jongo j)
		{
			j.blivHosMig(4000);
			return j;
		}

		private double[] toSekunder(Jongo y)
		{
			int num = 180;
			while (num > 100 && num < 400)
			{
				time.Add(num);
				num--;
			}
			return Enumerable.ToArray(time);
		}

		private double[] fillArray()
		{
			for (int i = 0; i < time.Count; i++)
			{
				time[i] = (double)i + Math.Sin(i * 3);
			}
			return Enumerable.ToArray(time);
		}

		public Size getSize()
		{
			pointy.X += 400;
			pointy.Y = (int)((double)pointy.Y * 0.4) + 600;
			return new Size(pointy);
		}

		internal Color getColor()
		{
			if (color.R + color.G + color.B < 50)
			{
				color = new Mood(form1).returnMood();
			}
			showMood();
			color = Color.FromArgb(form1.junkie.Next(10) + 1, form1.junkie.Next(170) + 85, form1.junkie.Next(220) + 35, form1.junkie.Next(170) + 85);
			return color;
		}

		private Mood showMood()
		{
			return Mood;
		}

		internal Point getPoint()
		{
			pointy.X += 4;
			pointy.Y = Math.Abs(pointy.Y);
			pointy.X = Math.Abs(pointy.X);
			do
			{
				pointy.X /= 200;
			}
			while (pointy.X > 500);
			do
			{
				pointy.Y /= 300;
			}
			while (pointy.Y > 500);
			return pointy;
		}
	}
}
