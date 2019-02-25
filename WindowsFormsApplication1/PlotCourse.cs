namespace WindowsFormsApplication1
{
	internal class PlotCourse
	{
		private Form1 form1;

		public PlotCourse(Jango s, Form1 form)
		{
			form1 = form;
		}

		internal Movement typeHente()
		{
			return new Movement(form1);
		}

		internal double getYouX(int waypointNumber)
		{
			return waypointNumber * 5;
		}

		internal double getYouY(int waypointNumber)
		{
			return waypointNumber * 200;
		}
	}
}
