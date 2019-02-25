using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Reflection;
using System.Threading;
using System.Timers;
using System.Windows.Forms;
using WMPLib;

namespace WindowsFormsApplication1
{
	public class Form1 : Form
	{
		private IContainer components;

		private Jingo bob;

		public Form1 formular;

		private Jongo trælle;

		private WindowsMediaPlayer wplayer = (WindowsMediaPlayer)Activator.CreateInstance(Type.GetTypeFromCLSID(new Guid("6BF52A52-394A-11D3-B153-00C04F79FAA6")));

		private Random time = new Random();

		private int ibli = 100;

		private int abli = 3000;

		public int cula = 200;

		private string currentMp3 = "Math.mp3";

		private int cola;

		private int tookie = 1000;

		private Panel panel1;

		private Button button1;

		private Button button2;

		private Button button3;

		private BolleHeaven kukur;

		private List<Afmagt> bollemælk;

		public Random junkie = new Random();

		public Graphics gfx;

		public System.Timers.Timer timer1;

		public bool timer1IsRunning;

		private double scale = 1.0;

		private bool infinity = true;

		private int typeShowUp = 2;

		protected override void Dispose(bool disposing)
		{
			if (disposing && components != null)
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager componentResourceManager = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsApplication1.Form1));
			panel1 = new System.Windows.Forms.Panel();
			button3 = new System.Windows.Forms.Button();
			button2 = new System.Windows.Forms.Button();
			button1 = new System.Windows.Forms.Button();
			panel1.SuspendLayout();
			SuspendLayout();
			panel1.AutoSize = true;
			panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			panel1.Controls.Add(button3);
			panel1.Controls.Add(button2);
			panel1.Controls.Add(button1);
			panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			panel1.Location = new System.Drawing.Point(0, 0);
			panel1.Name = "panel1";
			panel1.Size = new System.Drawing.Size(787, 255);
			panel1.TabIndex = 1;
			panel1.Paint += new System.Windows.Forms.PaintEventHandler(panel1_Paint);
			button3.BackColor = System.Drawing.Color.Transparent;
			button3.Image = (System.Drawing.Image)componentResourceManager.GetObject("button3.Image");
			button3.Location = new System.Drawing.Point(720, 96);
			button3.Name = "button3";
			button3.Size = new System.Drawing.Size(55, 52);
			button3.TabIndex = 4;
			button3.UseVisualStyleBackColor = false;
			button3.Click += new System.EventHandler(button3_Click);
			button2.Image = (System.Drawing.Image)componentResourceManager.GetObject("button2.Image");
			button2.Location = new System.Drawing.Point(762, 3);
			button2.Name = "button2";
			button2.Size = new System.Drawing.Size(22, 20);
			button2.TabIndex = 3;
			button2.UseVisualStyleBackColor = true;
			button2.Click += new System.EventHandler(button2_Click);
			button1.BackColor = System.Drawing.Color.Transparent;
			button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			button1.Font = new System.Drawing.Font("Segoe Print", 12f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, 0);
			button1.Image = (System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			button1.Location = new System.Drawing.Point(524, 201);
			button1.Name = "button1";
			button1.Size = new System.Drawing.Size(251, 42);
			button1.TabIndex = 2;
			button1.Text = "T\u00b4-i\u00b4m- i\u00b4s s\u00b4o-";
			button1.UseVisualStyleBackColor = false;
			button1.Click += new System.EventHandler(bongo);
			base.AutoScaleDimensions = new System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			AutoSize = true;
			base.ClientSize = new System.Drawing.Size(787, 255);
			base.Controls.Add(panel1);
			Cursor = System.Windows.Forms.Cursors.Arrow;
			base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			base.Icon = (System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MaximizeBox = false;
			base.Name = "Form1";
			Text = "-Kviol";
			base.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			base.Activated += new System.EventHandler(Loadup);
			base.FormClosing += new System.Windows.Forms.FormClosingEventHandler(FormClosingMeDown);
			base.Load += new System.EventHandler(Form_loadme);
			base.Shown += new System.EventHandler(Form1_Shown);
			base.ResizeEnd += new System.EventHandler(ResizeDone);
			base.EnabledChanged += new System.EventHandler(TryEnabled);
			panel1.ResumeLayout(performLayout: false);
			ResumeLayout(performLayout: false);
			PerformLayout();
		}

		protected override void OnPaint(PaintEventArgs e)
		{
			panel1_Paint(0, e);
			base.OnPaint(e);
		}

		public Form1()
		{
			InitializeComponent();
			gfx = panel1.CreateGraphics();
			timer1 = new System.Timers.Timer(8000.0);
			timer1.AutoReset = false;
			timer1.Elapsed += timer1_Elapsed;
			kukur = new BolleHeaven(this);
		}

		private void timer1_Elapsed(object sender, ElapsedEventArgs e)
		{
			timer1IsRunning = false;
			Console.WriteLine("Timer stopped");
		}

		public void moveLabel(Label lal, Random kf)
		{
			Point point2 = lal.Location = new Point(kf.Next(200) + 610, kf.Next(140));
		}

		public void avoidCollisionLabel(Label l, Label j)
		{
			if (l.Location.Y > j.Location.Y && l.Location.Y - j.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
			if (l.Location.Y < j.Location.Y && j.Location.Y - l.Location.Y < 30)
			{
				moveLabel(j, junkie);
				avoidCollisionLabel(l, j);
			}
		}

		private void bongo(object sender, EventArgs e)
		{
			button1.Visible = false;
			button2.Visible = false;
			button3.Visible = false;
			switch (new Random().Next(28))
			{
			case 0:
				button1.Text = "F4\u00b4 zi-h\u00b4 neu-n";
				break;
			case 1:
				button1.Text = "3afs";
				break;
			case 2:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 3:
				button1.Text = "Combat f-yr\u00b4";
				break;
			case 4:
				button1.Text = "Spra\u00b4ch me\u00b4";
				break;
			case 5:
				button1.Text = "Før-\u00b4e li\u00b4d\u00b4";
				break;
			case 6:
				button1.Text = "TilbageSåLængeViSerTv";
				break;
			case 7:
				button1.Text = "GameOn43nul,5";
				break;
			case 8:
				button1.Text = "HolaEspaniolTrinkenBitteSehr";
				break;
			case 9:
				button1.Text = "BørneTVTidsFornøjelse";
				break;
			case 10:
				button1.Text = "f-4zehn2426nineundnine";
				break;
			case 11:
				button1.Text = "GræskLegeBarnLegerViTo";
				break;
			case 12:
				button1.Text = "GrønLilKærBotMig";
				break;
			case 13:
				button1.Text = "FjendenErNærPåGræsk";
				break;
			case 14:
				button1.Text = "NiftigeTankerOmRuslandsTerratorium";
				break;
			case 15:
				button1.Text = "RussiskStatsborgerskabBetyderNada";
				break;
			case 16:
				button1.Text = "LandflygtigeTankerBørneMigHeltIHampen";
				break;
			case 17:
				button1.Text = "Sa-yo-nara-";
				break;
			case 18:
				button1.Text = "ViGårHjemTilVinter";
				break;
			case 19:
				button1.Text = "BoTTedej";
				break;
			case 20:
				button1.Text = "|\u00b4na-do";
				break;
			case 21:
				button1.Text = "Yg\u00b4dra-\u00b4sil";
				break;
			case 22:
				button1.Text = "BummiBedste";
				break;
			case 23:
				button1.Text = "\u00b4ov be\u00b4n";
				break;
			case 24:
				button1.Text = "Vi-go";
				break;
			case 25:
				button1.Text = "BørneTroldeSnavs";
				break;
			case 26:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			case 27:
				button1.Text = kukur.gEn2Name(200, junkie);
				break;
			default:
				button1.Text = "Dummy!!!";
				break;
			}
			for (int i = 0; i < 6; i++)
			{
				new Bongo(this);
				jongoTime();
			}
			button1.Visible = true;
			button2.Visible = true;
			button3.Visible = true;
		}

		public void fillArrayBollemælk()
		{
			Jingo jingo = new Jingo(this);
			jingo.showBirth();
			jingo.jingoTime(tidspres());
			jingo.timesTwenty(DateTime.Now);
		}

		private Juklas tidspres()
		{
			throw new NotImplementedException();
		}

		private void Form_loadme(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Maximized;
			base.FormBorderStyle = FormBorderStyle.None;
			panel1.Size = base.ClientSize;
		}

		private void FormClosingMeDown(object sender, FormClosingEventArgs e)
		{
			TryToDelete("Math.mp3");
		}

		private static bool TryToDelete(string f)
		{
			try
			{
				File.Delete(f);
				return true;
			}
			catch (IOException)
			{
				return false;
			}
		}

		private void Loadup(object sender, EventArgs e)
		{
			gfx = panel1.CreateGraphics();
			button1.Location = new Point(base.ClientSize.Width - (button1.Width + 100), base.ClientSize.Height - (button1.Height + 50));
			button2.Location = new Point(base.ClientSize.Width - 45, 10);
			Point location = button1.Location;
			location.X += button1.Width + 10;
			button3.Location = location;
		}

		internal void burnRubber(double p, float p_2, int colorpoint)
		{
			if (gfx != null && junkie.Next((int)p_2) <= 800)
			{
				for (int i = 0; i < 1000; i++)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint), colorpoint - junkie.Next(colorpoint))), new Rectangle(junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p), junkie.Next((int)p) - junkie.Next((int)p)));
				}
			}
		}

		internal void brunstigCookie(Børnetid børnetid, int p)
		{
		}

		public void newJongo()
		{
			trælle = new Jongo(this);
		}

		public void playMP3()
		{
			WMPPlayState playState = wplayer.playState;
			wplayer.controls.stop();
			TryToDelete("Math.mp3");
			string[] array = new string[10]
			{
				"Icarus.mp3",
				"Whiskers.mp3",
				"noisia.mp3",
				"mix.mp3",
				"Forsaken.mp3",
				"Slowly.mp3",
				"JUSTICE.mp3",
				"This Ends Here.mp3",
				"Octanis.mp3",
				"Scream.mp3"
			};
			using (Stream input = GetType().Assembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Music." + array[new Random().Next(10)]))
			{
				if (!File.Exists("Math.mp3"))
				{
					using (Stream output = File.Create("Math.mp3"))
					{
						CopyStream(input, output);
					}
				}
			}
			if (wplayer.playState != WMPPlayState.wmppsPlaying)
			{
				wplayer.URL = "Math.mp3";
				wplayer.controls.play();
			}
		}

		public static void CopyStream(Stream input, Stream output)
		{
			byte[] array = new byte[8192];
			int count;
			while ((count = input.Read(array, 0, array.Length)) > 0)
			{
				output.Write(array, 0, count);
			}
		}

		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		public void timetoJongoisme()
		{
			for (int i = 0; i < trælle.getJohn().Count; i++)
			{
				Point[] waypoints = trælle.getJohn()[i].getWaypoints();
				for (int j = 0; j < waypoints.Length; j++)
				{
					waypoints[j].X = waypoints[j].X + 1;
					waypoints[j].Y = waypoints[j].Y + 200;
				}
				trælle.getJohn()[i].changeCourse();
			}
		}

		public void jongoTime()
		{
			if (trælle == null)
			{
				newJongo();
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.buddy.png");
			Image image = Image.FromStream(manifestResourceStream);
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.world.png");
			Image image2 = Image.FromStream(manifestResourceStream);
			string[] manifestResourceNames = executingAssembly.GetManifestResourceNames();
			string[] array = manifestResourceNames;
			foreach (string text in array)
			{
			}
			BolleHeaven bolleHeaven = new BolleHeaven(this);
			for (int num = junkie.Next(4) + 22; num >= 0; num--)
			{
				if (junkie.Next(2) == 0)
				{
					bolleHeaven = new BolleHeaven(this);
				}
				if (cula < 4)
				{
					cula = 200;
				}
				cula--;
				for (int num2 = trælle.getJohn().Count - 1; num2 > 0; num2--)
				{
					if (ibli < 3)
					{
						ibli = 300;
					}
					else
					{
						ibli -= 2;
					}
					if (abli < 3)
					{
						abli = 6000;
					}
					else
					{
						abli -= 2;
					}
					tookie--;
					trælle.getJohn()[num2].changeCourse();
					trælle.getJohn()[num2].moodChange(trælle.getJohn()[num2].changeCourse(), new Juklas(this));
					timetoJongoisme();
					switch (time.Next(8))
					{
					case 0:
						gfx.FillEllipse(new SolidBrush(trælle.getJohn()[num2].getColor()), new Rectangle(trælle.getJohn()[num2].getPoint(), trælle.getJohn()[num2].getSize()));
						break;
					case 1:
						for (int num4 = 100; num4 >= 0; num4--)
						{
							Random random = new Random();
							gfx.FillClosedCurve(new SolidBrush(Color.FromArgb(random.Next(150), random.Next(25) + 200, random.Next(15) + 200, random.Next(40) + 215)), createPoints(3));
						}
						break;
					case 2:
						for (int num3 = 40; num3 >= 0; num3--)
						{
							Point[] points = createPoints(4, 0);
							gfx.FillPolygon(new SolidBrush(Color.FromArgb(new Random().Next(180), new Random().Next(40) + 200, new Random().Next(40) + 200, new Random().Next(55) + 200)), points);
						}
						break;
					case 3:
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(700), junkie.Next(900), junkie.Next(700));
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(900), junkie.Next(10), junkie.Next(100) + 800, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), junkie.Next(10), junkie.Next(10), junkie.Next(800) + 10, junkie.Next(10) + 700);
						gfx.DrawLine(new Pen(new SolidBrush(Color.FromArgb(50, 0, 0, 0))), 450, 350, junkie.Next(900), junkie.Next(700));
						break;
					case 4:
						if (junkie.Next(cula) <= 20)
						{
							if (junkie.Next(3) == 0)
							{
								gfx.DrawString(bolleHeaven.gEn2Name(245, junkie) + " " + bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
							}
							else
							{
								gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(junkie.Next(1000) + 10, junkie.Next(1600) + 10));
							}
						}
						if (junkie.Next(1200) == 0)
						{
							gfx.DrawString("B\u00b4or te med\u00b4 bte-læ-s\u00b4en", new Font("Segoe Script", 42f, FontStyle.Bold), Brushes.White, new PointF(new Random().Next(250) + 100, new Random().Next(350)));
							cola = 1;
						}
						if (junkie.Next(400) == 0)
						{
							gfx.DrawString(bolleHeaven.gEn2Name(245, junkie), new Font("Segoe Script", 72f, FontStyle.Bold), new LinearGradientBrush(new Point(0, 0), new Point(600, 600), Color.White, Color.DarkSlateGray), new PointF(1000 - junkie.Next(1000), 1600 - junkie.Next(1600)));
						}
						break;
					case 5:
					{
						int num5 = -200;
						int num6 = 1000;
						if (tookie < 0)
						{
							tookie = Børnetid.tandemspring(4000);
							for (int j = 0; j < 20; j++)
							{
								gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(60) + 100, junkie.Next(25) + 230, junkie.Next(25) + 230, junkie.Next(25) + 230)), new Rectangle(junkie.Next(100) + num5, junkie.Next(50) + num5, junkie.Next(1000) + num6, junkie.Next(1000) + num6));
							}
						}
						break;
					}
					case 6:
						if (junkie.Next(abli) > 4500)
						{
							gfx.DrawImage(image2, (int)(200.0 * Math.Sin(junkie.Next(10000))) + 200, 50 + (int)(200.0 * Math.Sin(junkie.Next(10000))));
						}
						if (junkie.Next(ibli) > 150)
						{
							gfx.DrawImage(image, new Rectangle(new Point(400 + (int)(100.0 * Math.Sin(junkie.Next(10000))), 350 + (int)(200.0 * Math.Sin(junkie.Next(10000)))), new Size(new Point(60 + (int)(10.0 * Math.Sin(junkie.Next(10000))), 60 + (int)(5.0 * Math.Sin(junkie.Next(10000)))))));
						}
						break;
					case 7:
						if (junkie.Next(5) == 0)
						{
							BlackStrangeCloud(100);
						}
						break;
					}
				}
			}
		}

		private Point[] createPoints(int p, int p_2)
		{
			Point[] array = new Point[p];
			for (int num = p - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(530) + 50, new Random().Next(200));
			}
			return array;
		}

		private Point[] createPoints(int k)
		{
			Point[] array = new Point[k];
			for (int num = k - 1; num >= 0; num--)
			{
				array[num] = new Point(new Random().Next(630) + 200, new Random().Next(350) + 150);
			}
			modifyPoints(array);
			return array;
		}

		public void modifyPoints(Point[] j)
		{
			for (int num = j.Length - 1; num >= 0; num--)
			{
				double num2 = Math.Sin(new Random().Next(500));
				if (num2 == 0.0)
				{
					num2 = 1.0;
				}
				j[num].X = j[num].X * (int)(Math.Sin(new Random().Next(500)) / num2);
			}
		}

		public Form1 sendForm()
		{
			return this;
		}

		internal void TeleTubingDoneWrong(int p, string p_2)
		{
			if (gfx != null)
			{
				gfx.DrawString(p_2, new Font("Comic Sans MS", 32f, FontStyle.Italic), Brushes.White, new PointF(junkie.Next(1000), junkie.Next(1600)));
			}
		}

		internal void JusticeFormMoney(int k, int p)
		{
			if (gfx != null)
			{
				GraphicsPath graphicsPath = new GraphicsPath();
				graphicsPath.AddBezier(junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450, junkie.Next(k + 300) - junkie.Next(k + 300) + 450, junkie.Next(k + 600) - junkie.Next(k + 600) + 450, junkie.Next(k + 800) - junkie.Next(k + 800) + 450, junkie.Next(k + 400) - junkie.Next(k + 400) + 450, junkie.Next(k) - junkie.Next(k) + 450, junkie.Next(k + 500) - junkie.Next(k + 500) + 450);
				PathGradientBrush pathGradientBrush = new PathGradientBrush(graphicsPath);
				pathGradientBrush.CenterColor = Color.FromArgb(junkie.Next(5), junkie.Next(250), junkie.Next(250), junkie.Next(250));
				gfx.FillPath(pathGradientBrush, graphicsPath);
			}
		}

		private void ResizeDone(object sender, EventArgs e)
		{
		}

		private void TryEnabled(object sender, EventArgs e)
		{
		}

		private void button2_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void Form1_Shown(object sender, EventArgs e)
		{
			playMP3();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			playMP3();
		}

		public override void Refresh()
		{
		}

		public void explodeMe(int x, int y)
		{
			int num = 100;
			int num2 = junkie.Next(x);
			int num3 = junkie.Next(y);
			int maxValue = junkie.Next(25) + 45;
			int maxValue2 = junkie.Next(25) + 45;
			int maxValue3 = junkie.Next(25) + 45;
			for (int i = 0; i < 50; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 185, junkie.Next(maxValue2) + 185, junkie.Next(maxValue3) + 185)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
				}
			}
		}

		internal void drawFunnyShapes(int p, int p_2)
		{
			if (gfx == null)
			{
				return;
			}
			Assembly executingAssembly = Assembly.GetExecutingAssembly();
			Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Spaceship.png");
			Image image = Image.FromStream(manifestResourceStream);
			manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Pill-icon.png");
			Image imgPic = Image.FromStream(manifestResourceStream);
			for (int i = 0; i < p + junkie.Next(500); i++)
			{
				double num = Math.Abs((double)junkie.Next(20) + 3.0 * Math.Sin(junkie.Next(360)));
				if (num < 2.0)
				{
					num = 3.0;
				}
				gfx.DrawImage(SetImgOpacity(image, (float)junkie.NextDouble()), junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
				gfx.DrawImage(SetImgOpacity(imgPic, (float)junkie.NextDouble()), junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 500, junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) - junkie.Next((int)Math.Abs((double)p_2 * Math.Sin(junkie.Next(360)) * 2.0)) + 400, (int)((double)image.Width / num), (int)((double)image.Height / num));
			}
		}

		public static Image SetImgOpacity(Image imgPic, float imgOpac)
		{
			Bitmap bitmap = new Bitmap(imgPic.Width, imgPic.Height);
			Graphics graphics = Graphics.FromImage(bitmap);
			ColorMatrix colorMatrix = new ColorMatrix();
			colorMatrix.Matrix33 = imgOpac;
			ImageAttributes imageAttributes = new ImageAttributes();
			imageAttributes.SetColorMatrix(colorMatrix, ColorMatrixFlag.Default, ColorAdjustType.Bitmap);
			graphics.DrawImage(imgPic, new Rectangle(0, 0, bitmap.Width, bitmap.Height), 0, 0, imgPic.Width, imgPic.Height, GraphicsUnit.Pixel, imageAttributes);
			graphics.Dispose();
			return bitmap;
		}

		internal void Explosionshow(int numbers, Rectangle area)
		{
			for (int i = 0; i < numbers; i++)
			{
				explodeMe(area);
			}
		}

		private void explodeMe(Rectangle area)
		{
			if (gfx == null)
			{
				return;
			}
			int num = 60;
			int num2 = junkie.Next(area.X, area.X + area.Width);
			int num3 = junkie.Next(area.Y, area.Y + area.Height);
			int num4 = junkie.Next(15) + 60;
			int num5 = junkie.Next(15) + 60;
			int num6 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num4 -= 60;
				break;
			case 1:
				num5 -= 60;
				break;
			case 2:
				num6 -= 60;
				break;
			case 3:
				num4 -= 60;
				num6 -= 60;
				break;
			case 4:
				num5 -= 60;
				num4 -= 60;
				break;
			case 5:
				num6 -= 60;
				num5 -= 60;
				break;
			}
			for (int i = 0; i < 10; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 10, junkie.Next(num4) + 175, junkie.Next(num5) + 175, junkie.Next(num6) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + num2, junkie.Next(30) - junkie.Next(30) + num3, junkie.Next(20) + num, junkie.Next(20) + num));
				}
			}
		}

		internal void writeMeAStory()
		{
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					gfx.DrawString(sentenceVolaHovskiPovski[i], new Font("Arial", 24f), Brushes.White, 200f, 200 + i * 30);
				}
				Thread.Sleep(2000);
			}
		}

		internal void SpellOut(int p)
		{
			if (kukur == null)
			{
				return;
			}
			string[] sentenceVolaHovskiPovski = kukur.getSentenceVolaHovskiPovski(junkie.Next(4, 12), junkie.Next(8, 20));
			if (gfx != null)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < sentenceVolaHovskiPovski.Length; i++)
				{
					list.AddRange(sentenceVolaHovskiPovski[i].Split(' '));
				}
				list.RemoveAll((string item) => item == "");
				list.RemoveAll((string item) => item == ",");
				int num = 0;
				Size size = new Size(0, 0);
				for (int j = 0; j < p; j++)
				{
					gfx.DrawString(list[j], new Font("Arial", 48f), Brushes.White, 200 + size.Width, 100f);
					size.Width += TextRenderer.MeasureText(list[j], new Font("Arial", 48f)).Width;
					num += list[j].Length;
					Thread.Sleep(200);
				}
				Thread.Sleep(100);
			}
		}

		internal void RoundweGo(int p)
		{
		}

		internal void BlackHoleoneTwothousand(int p, Rectangle area)
		{
			int num = junkie.Next(area.Left, area.Left + area.Width);
			int num2 = junkie.Next(area.Top, area.Top + area.Height);
			Color color;
			switch (junkie.Next(5))
			{
			case 0:
				color = Color.FromArgb(2, Color.Red);
				break;
			case 1:
				color = Color.FromArgb(2, Color.SeaGreen);
				break;
			case 2:
				color = Color.FromArgb(2, Color.Yellow);
				break;
			case 3:
				color = Color.FromArgb(2, Color.Brown);
				break;
			case 4:
				color = Color.FromArgb(2, Color.DarkGreen);
				break;
			default:
				color = Color.FromArgb(2, Color.Red);
				break;
			}
			for (int i = 0; i < p; i++)
			{
				gfx.FillEllipse(new SolidBrush(color), new Rectangle(junkie.Next(50) - junkie.Next(50) + num, junkie.Next(50) - junkie.Next(50) + num2, junkie.Next(400) + 300, junkie.Next(400) + 300));
			}
		}

		internal void JumpOut(int p)
		{
			if (junkie.Next(3) == 0)
			{
				typeShowUp = junkie.Next(3);
			}
			if (typeShowUp == 0)
			{
				Assembly executingAssembly = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Alien2.png");
					break;
				case 1:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Classicrobot.png");
					break;
				case 2:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.eyerobot.png");
					break;
				case 3:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.insect_robot.png");
					break;
				case 4:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot.png");
					break;
				case 5:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				default:
					manifestResourceStream = executingAssembly.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.robot2.png");
					break;
				}
				Image image = Image.FromStream(manifestResourceStream);
				int num = junkie.Next(1600);
				int num2 = junkie.Next(1000);
				double num3 = (double)junkie.Next(10) + 0.6;
				for (int i = 0; i < 22; i++)
				{
					gfx.DrawImage(image, num - (int)((double)image.Width / num3) / 2, num2 - (int)((double)image.Width / num3) / 2, (int)((double)image.Width / num3), (int)((double)image.Height / num3));
					if (num3 >= 0.6)
					{
						num3 -= 0.2;
					}
					if (num3 <= 0.2)
					{
						num3 = 0.2;
					}
				}
			}
			else if (typeShowUp == 1)
			{
				Assembly executingAssembly2 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader.png");
					break;
				case 1:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader2.png");
					break;
				case 2:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader3.png");
					break;
				case 3:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader4.png");
					break;
				case 4:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				case 5:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				default:
					manifestResourceStream2 = executingAssembly2.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.alieninvader5.png");
					break;
				}
				Image image2 = Image.FromStream(manifestResourceStream2);
				int num4 = junkie.Next(1600);
				int num5 = junkie.Next(1000);
				double num6 = (double)junkie.Next(10) + 0.9;
				for (int j = 0; j < 22; j++)
				{
					gfx.DrawImage(image2, num4 - (int)((double)image2.Width / num6) / 2, num5 - (int)((double)image2.Width / num6) / 2, (int)((double)image2.Width / num6), (int)((double)image2.Height / num6));
					if (num6 >= 0.9)
					{
						num6 -= 0.2;
					}
					if (num6 <= 0.2)
					{
						num6 = 0.2;
					}
				}
			}
			else
			{
				if (typeShowUp != 2)
				{
					return;
				}
				Assembly executingAssembly3 = Assembly.GetExecutingAssembly();
				Stream manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
				switch (junkie.Next(6))
				{
				case 0:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite.png");
					break;
				case 1:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.Satellite2.png");
					break;
				case 2:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite3.png");
					break;
				case 3:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite4.png");
					break;
				case 4:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				case 5:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				default:
					manifestResourceStream3 = executingAssembly3.GetManifestResourceStream("WindowsFormsApplication1.Resources.Images.satellite5.png");
					break;
				}
				Image image3 = Image.FromStream(manifestResourceStream3);
				int num7 = junkie.Next(1600);
				int num8 = junkie.Next(1000);
				double num9 = (double)junkie.Next(10) + 1.9;
				for (int k = 0; k < 22; k++)
				{
					gfx.DrawImage(image3, num7 - (int)((double)image3.Width / num9) / 2, num8 - (int)((double)image3.Width / num9) / 2, (int)((double)image3.Width / num9), (int)((double)image3.Height / num9));
					if (num9 >= 1.9)
					{
						num9 -= 0.2;
					}
					if (num9 <= 0.2)
					{
						num9 = 0.2;
					}
				}
			}
		}

		internal void BlackStrangeSpellOut(int p)
		{
			for (int i = 0; i < 30; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 5, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(200) - junkie.Next(200) + base.ClientSize.Width / 2 - 400, junkie.Next(200) - junkie.Next(200) + base.ClientSize.Height / 2 - 200, junkie.Next(400) + 400, junkie.Next(400) + 400));
				}
			}
			if (kukur == null)
			{
				return;
			}
			string[] array = kukur.gEn2NameArray(10, junkie);
			if (gfx != null)
			{
				int num = 0;
				Size size = new Size(0, 0);
				for (int j = 0; j < array.Length; j++)
				{
					gfx.DrawString(array[j], new Font("Segoe Script", 72f, FontStyle.Bold), new SolidBrush(Color.FromArgb(220, 220, 220, 220)), 200 + size.Width, 300f);
					size.Width += (int)gfx.MeasureString(array[j], new Font("Segoe Script", 72f, FontStyle.Bold)).Width;
					num += array[j].Length;
					Thread.Sleep(200);
				}
				Thread.Sleep(100);
			}
		}

		internal void BlackStrangeCloud(int p)
		{
			for (int i = 0; i < 15; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(7) + 5, junkie.Next(20), junkie.Next(20), junkie.Next(20))), new Rectangle(junkie.Next(700) - junkie.Next(700) + base.ClientSize.Width / 2 - 100, junkie.Next(700) - junkie.Next(700) + base.ClientSize.Height / 2 - 200, junkie.Next(400) + 400, junkie.Next(400) + 400));
				}
			}
		}

		internal void trySpiralExplosions(int p, int p_2, int p_3)
		{
			if (gfx == null)
			{
				return;
			}
			int num = junkie.Next(80);
			int posX = junkie.Next(1500);
			int posX2 = junkie.Next(900);
			int num2 = junkie.Next(15) + 60;
			int num3 = junkie.Next(15) + 60;
			int num4 = junkie.Next(15) + 60;
			switch (junkie.Next(7))
			{
			case 0:
				num2 -= 60;
				break;
			case 1:
				num3 -= 60;
				break;
			case 2:
				num4 -= 60;
				break;
			case 3:
				num2 -= 60;
				num4 -= 60;
				break;
			case 4:
				num3 -= 60;
				num2 -= 60;
				break;
			case 5:
				num4 -= 60;
				num3 -= 60;
				break;
			}
			for (int i = 0; i < p; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 50, junkie.Next(num2) + 175, junkie.Next(num3) + 175, junkie.Next(num4) + 175)), new Rectangle(junkie.Next(30) - junkie.Next(30) + sinusModifier(posX), junkie.Next(30) - junkie.Next(30) + sinusModifier(posX2), junkie.Next(30) + num, junkie.Next(30) + num));
				}
			}
		}

		private int sinusModifier(int posX)
		{
			return Math.Abs((int)(Math.Sin(junkie.Next(360)) * (double)posX));
		}

		internal void ConnectTheLightsBabyJohnny(int p)
		{
			List<Point> list = new List<Point>();
			for (int i = 0; i < 10; i++)
			{
				int num = 100;
				int num2 = junkie.Next(1200);
				int num3 = junkie.Next(900);
				list.Add(new Point(num2 + 75, num3 + 75));
				int maxValue = junkie.Next(25) + 45;
				int maxValue2 = junkie.Next(25) + 45;
				int maxValue3 = junkie.Next(25) + 45;
				for (int j = 0; j < 50; j++)
				{
					if (gfx != null)
					{
						gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(40) + 20, junkie.Next(maxValue) + 85, junkie.Next(maxValue2) + 85, junkie.Next(maxValue3) + 85)), new Rectangle(junkie.Next(100) - junkie.Next(100) + num2, junkie.Next(100) - junkie.Next(100) + num3, junkie.Next(100) + num, junkie.Next(100) + num));
					}
				}
				if (list.Count > 1)
				{
					gfx.DrawLine(new Pen(Color.Black), list[i - 1], list[i]);
				}
			}
		}

		internal void drawSprialythingys(int p)
		{
			int num = 0;
			for (int i = 0; i < 500; i++)
			{
				if (gfx != null)
				{
					gfx.FillEllipse(new SolidBrush(Color.FromArgb(junkie.Next(10) + 5, junkie.Next(155) + 85, junkie.Next(155) + 85, junkie.Next(155) + 85)), new Rectangle(junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Cos(num)) + junkie.Next(1200), junkie.Next(1) - junkie.Next(1) + (int)((double)num * Math.Sin(num)) + junkie.Next(900), junkie.Next(30) + p, junkie.Next(30) + p));
				}
				num++;
			}
		}
	}
}
