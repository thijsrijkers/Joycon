using Joycon4CS;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace JoyConForm
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();

			drawOrigin = new Point(picture1.Width / 2, picture1.Height / 2);
			joycon = new Math3D.Math3D.Cube(200, 100, 20);

		}

		JoyconManager manager = new JoyconManager();

		Point drawOrigin;
		Math3D.Math3D.Cube joycon;

		private void buttonScan_Click(object sender, EventArgs e)
		{
			manager.Scan();

			UpdateDebug();
			InfoRefresh();

			manager.Start();
			timerUpdate.Enabled = true;
		}

		private void UpdateDebug()
		{
			foreach (var j in manager.j)
			{ 
				j.debug_type = Joycon.DebugType.NONE;
			}
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			manager.Update();

			InfoRefresh();
		}

		private void InfoRefresh()
		{
			if (manager.j.Count != 0)
			{
				var j = manager.j[0];

				joycon.InitializeCube();
				joycon.RotateX = (float)(j.GetVector().eulerAngles.Y * 180.0f / Math.PI);
				joycon.RotateY = (float)(j.GetVector().eulerAngles.Z * 180.0f / Math.PI);
				joycon.RotateZ = (float)(j.GetVector().eulerAngles.X * 180.0f / Math.PI);

				picture1.Image = joycon.DrawCube(drawOrigin);
			}
		}
    }
}
