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
			JoyCon1 = new Math3D.Math3D.Cube(200, 100, 20);

		}

		JoyconManager joyconManager = new JoyconManager();

		Point drawOrigin;
		Math3D.Math3D.Cube JoyCon1;

		private void buttonScan_Click(object sender, EventArgs e)
		{
			joyconManager.Scan();

			UpdateDebugType();
			UpdateInfo();
		}

		private void UpdateDebugType()
		{
			foreach (var j in joyconManager.j)
			{ 
				j.debug_type = Joycon.DebugType.NONE;
			}
		}

		private void buttonStart_Click(object sender, EventArgs e)
		{
			joyconManager.Start();
			timerUpdate.Enabled = true;
		}

		private void timerUpdate_Tick(object sender, EventArgs e)
		{
			joyconManager.Update();

			UpdateInfo();
		}

		private void UpdateInfo()
		{
			if (joyconManager.j.Count != 0)
			{
				var j = joyconManager.j[0];

				JoyCon1.InitializeCube();
				JoyCon1.RotateX = (float)(j.GetVector().eulerAngles.Y * 180.0f / Math.PI);
				JoyCon1.RotateY = (float)(j.GetVector().eulerAngles.Z * 180.0f / Math.PI);
				JoyCon1.RotateZ = (float)(j.GetVector().eulerAngles.X * 180.0f / Math.PI);

				picture1.Image = JoyCon1.DrawCube(drawOrigin);
			}
		}
    }
}
