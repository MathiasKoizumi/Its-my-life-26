using System;
using System.Drawing;

namespace WindowsFormsApplication1
{
	internal class Movement
	{
		private Jongo collision;

		private PlotCourse time;

		private Point point;

		private Form1 form1;

		public Movement(Form1 form)
		{
			form1 = form;
		}

		public int getSpeedChange()
		{
			int num = 500;
			return num + 400;
		}

		public void setLife(Array a)
		{
		}

		public Point addForce(int force, Point cord)
		{
			cord.X += force;
			cord.Y += force;
			return cord;
		}

		public int Bezier2D(double[] b, int cpts, double[] p)
		{
			int num = b.Length / 2;
			int num2 = 0;
			double num3 = 0.0;
			double num4 = 1.0 / (double)(cpts - 1);
			for (int i = 0; i != cpts; i++)
			{
				if (1.0 - num3 < 5E-06)
				{
					num3 = 1.0;
				}
				int num5 = 0;
				p[num2] = 0.0;
				p[num2 + 1] = 0.0;
				for (int j = 0; j != num; j++)
				{
					double num6 = Bernstein(num - 1, j, num3);
					p[num2] += num6 * b[num5];
					p[num2 + 1] += num6 * b[num5 + 1];
					num5 += 2;
				}
				num2 += 2;
				num3 += num4;
			}
			return num;
		}

		private double Bernstein(int p, int i, double t)
		{
			throw new NotImplementedException();
		}

		internal int getSpeedChangeY(PlotCourse y, PlotCourse x)
		{
			return point.Y;
		}

		internal int getSpeedChangeX(PlotCourse x)
		{
			return (int)x.getYouX(8);
		}

		internal int getSpeedChangeX(PlotCourse course, PlotCourse course_2)
		{
			return (int)Math.Sin(4.0) * 4 + 400;
		}
	}
}
